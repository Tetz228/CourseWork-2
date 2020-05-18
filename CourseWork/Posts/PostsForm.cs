using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;

namespace CourseWork.Posts
{
    public partial class PostsForm : MaterialForm
    {
        public PostsForm()
        {
            InitializeComponent();

            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
            pictureBoxSearch.BackColor = Color.FromArgb(230, 108, 0);
        }

        // При загрузки формы
        private void PostsForm_Load(object sender, EventArgs e)
        {
            this.dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            SelectDatePosts();
        }

        DataTable PostsTable = new DataTable("Posts");

        // Добавление данных из базы данных в dataGridView
        private void SelectDatePosts()
        {
            ConnectionDB connection = new ConnectionDB();
            
            SqlCommand command = new SqlCommand("SELECT * FROM Posts", connection.GetSqlConnect());
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            connection.OpenConnect();

            adapter.Fill(PostsTable);

            dataGridViewPosts.DataSource = PostsTable.DefaultView;

            connection.CloseConnect();
        }

        // Функция удаления строки
        private void DeleteRowPosts()
        {
            ConnectionDB connection = new ConnectionDB();
            SqlCommand command = new SqlCommand("DeletePost", connection.GetSqlConnect());

            connection.OpenConnect();

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id_post", Convert.ToInt32(dataGridViewPosts.CurrentRow.Cells["Column_id_post"].Value));

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

            Program.DataEditPostsId.Value = Convert.ToString(dataGridViewPosts.CurrentRow.Cells["Column_id_post"].Value);
            Program.DataEditPostsName.Value = Convert.ToString(dataGridViewPosts.CurrentRow.Cells["Column_post_name"].Value);

            formEdit.ShowDialog();

            SelectDatePosts();
        }

        // При 2-ом клике на ячейку можно провести редактирование
        private void dataGridViewPosts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Если не выбрана строка, содержащие заголовки
            if (e.RowIndex != -1)
            {
                DataGridViewRow view = dataGridViewPosts.Rows[e.RowIndex];

                Program.DataEditPostsId.Value = view.Cells[0].Value.ToString();
                Program.DataEditPostsName.Value = view.Cells[1].Value.ToString();

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
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                DeleteRowPosts();

            e.Cancel = true;
        }

        DataTable data = new DataTable("Posts");

        //private void PostsSearch()
        //{
        //    ConnectionDB connection = new ConnectionDB();
            
        //    SqlDataAdapter command = new SqlDataAdapter("select * from Posts", connection.GetSqlConnect());

        //    connection.OpenConnect();

        //    command.SelectCommand.Parameters.AddWithValue("@post_name", textBoxSearch.Text);

        //    command.Fill(data);

        //    //dataGridViewPosts.Rows.Clear();

        //    dataGridViewPosts.DataSource = data;

        //    connection.CloseConnect();
        //}

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            DataView view = PostsTable.DefaultView;
            view.RowFilter = string.Format("post_name like '%{0}%' ", textBoxSearch.Text);
            dataGridViewPosts.DataSource = view.ToTable();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //PostsSearch();
            //e.SuppressKeyPress = true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //PostsSearch();
            DataView view = PostsTable.DefaultView;
            view.RowFilter = string.Format("post_name like '%{0}%' ", textBoxSearch.Text);
            dataGridViewPosts.DataSource = view.ToTable();
        }
        
        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    DataView view = PostsTable.DefaultView;
            //    view.RowFilter = string.Format("post_name like '%{0}%' ", textBoxSearch.Text);
            //    dataGridViewPosts.DataSource = view.ToTable();
            //}
        }
    }
}
