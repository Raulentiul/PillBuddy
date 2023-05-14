using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedstuffPrincipal
{
    public partial class form_create_account : Form
    {
        public form_create_account()
        {
            InitializeComponent();
        }

        private void back_button_create_account_Click(object sender, EventArgs e)
        {
            form_login_patient form_login_patient = new form_login_patient();
            form_login_patient.Show();
            this.Close();
        }

        private void label_create_account_create_account_Click(object sender, EventArgs e)
        {
            string name = text_box_name_create_account.Text;
            string email = text_box_email_create_account.Text;
            string phone_number = text_box_phone_number_create_account.Text;
            string password = text_box_password_create_account.Text; ;
            string verify_password = text_box_verify_password_create_account.Text; ;
            if(name!="" && email!="" && phone_number!="" && password!="" && verify_password!="")
            {
                if (password != verify_password)
                {
                    MessageBox.Show("Password doesn't match!");
                }
                else
                {
                    MessageBox.Show("Account Created!");
                    form_login_patient form_login_patient = new form_login_patient();
                    form_login_patient.Show();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Fill all TextBoxes!");
        }

        private void text_box_password_create_account_TextChanged(object sender, EventArgs e)
        {
            text_box_password_create_account.UseSystemPasswordChar = true;
        }

        private void text_box_verify_password_create_account_TextChanged(object sender, EventArgs e)
        {
            text_box_verify_password_create_account.UseSystemPasswordChar = true;
        }
    }
}
