using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseWork.Posts
{
    public partial class PostsForm : MaterialForm
    {
        DataTable PostsTable = new DataTable();

        public PostsForm()
        {
            InitializeComponent();

            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);

            if (Program.DataAuth.Role_user == 2)
                MainToolStripMenuItem.Visible = false;
        }

        // При загрузки формы
        private void PostsForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDatePosts();
        }

        // Добавление данных из базы данных в dataGridView
        private void SelectDatePosts()
        {
            ConnectionDB connection = new ConnectionDB();
            
            SqlCommand command = new SqlCommand("SELECT * " +
                "FROM Posts", connection.GetSqlConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            PostsTable = new DataTable();

            connection.OpenConnect();

            adapter.Fill(PostsTable);

            dataGridViewPosts.DataSource = PostsTable.DefaultView;

            connection.CloseConnect();
        }

        // Поиск по dataGridу
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataView view = PostsTable.DefaultView;

            view.RowFilter = string.Format("post_name like '%{0}%' ", textBoxSearch.Text);

            dataGridViewPosts.DataSource = view.ToTable();
        }

        // Функция удаления строки
        private void DeleteRowPosts()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeletePost", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_post", Convert.ToInt32(dataGridViewPosts.CurrentRow.Cells[0].Value));

            command.ExecuteNonQuery();

            connection.CloseConnect();

            SelectDatePosts();
        }

        // При клике на "Правка" -> "Добавить" открывается форма для добавления
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostsFormAdd formAdd = new PostsFormAdd();

            formAdd.ShowDialog();

            SelectDatePosts();
        }

        // При нажатии на клавишу Ins(Insert) открывается форма добавления
        private void dataGridViewPosts_KeyDown(object sender, KeyEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
                if (e.KeyCode == Keys.Insert)
                {
                    PostsFormAdd formAdd = new PostsFormAdd();

                    formAdd.ShowDialog();

                    SelectDatePosts();
                }
        }

        // При клике на "Правка" -> "Изменить" открывается форма для изменения
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostsFormEdit formEdit = new PostsFormEdit();

            Program.DataPosts.Id = Convert.ToInt32(dataGridViewPosts.CurrentRow.Cells[0].Value);
            Program.DataPosts.Name = Convert.ToString(dataGridViewPosts.CurrentRow.Cells[1].Value);

            formEdit.ShowDialog();

            SelectDatePosts();
        }

        // При 2-ом клике на ячейку можно провести редактирование строки
        private void dataGridViewPosts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
                if (e.RowIndex != -1)
                {
                    DataGridViewRow view = dataGridViewPosts.Rows[e.RowIndex];

                    Program.DataPosts.Id = Convert.ToInt32(view.Cells[0].Value);
                    Program.DataPosts.Name = view.Cells[1].Value.ToString();

                    PostsFormEdit formEdit = new PostsFormEdit();

                    formEdit.ShowDialog();

                    SelectDatePosts();
                }
        }

        // При клике на "Правка" -> "Удалить" вызывается функция удаления
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowPosts();
            else
                return;
        }

        // При выделение строки и нажатии на клавишу Del(Delete) вызывается функция удаления
        private void dataGridViewPosts_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (Program.DataAuth.Role_user != 2)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DeleteRowPosts();

                e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
