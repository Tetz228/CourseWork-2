using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace CourseWork.Authorization_Registration_Forgot_pass
{
    public partial class ForgotPassFormCode : MaterialForm
    {
        string global;

        public ForgotPassFormCode()
        {
            InitializeComponent();

            var material = MaterialSkinManager.Instance;

            material.AddFormToManage(this);
            material.Theme = MaterialSkinManager.Themes.DARK;
            material.ColorScheme = new ColorScheme(Primary.Orange900, Primary.Orange800, Primary.Orange400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void ForgotPassFormCode_Load(object sender, EventArgs e)
        {
            linkLabelConfirmationCode.Text = "Отправить код\nещё раз";
            

            //СonfirmationСode();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Получение кода подтвеждения с помощью глобальной переменной 
        private void СonfirmationСode()
        {
            ConfirmationMailForm mailForm = new ConfirmationMailForm();

            global = mailForm.SendingCode(Program.DataEmailPass.Value);
        }

        private void ForgotPassFormCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form authorization = Application.OpenForms[0];

            authorization.StartPosition = FormStartPosition.Manual;
            authorization.Left = this.Left;
            authorization.Top = this.Top;
            authorization.Show();
        }

        
    }
}
