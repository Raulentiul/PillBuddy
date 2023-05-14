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
    public partial class form_profile_doctor : Form
    {
        public form_profile_doctor()
        {
            InitializeComponent();
        }

        private void picture_box_settings_doctor_Click(object sender, EventArgs e)
        {

            // create a new instance of a Form object
            Form popup = new Form();

            // set the properties of the form
            popup.Text = "Check Account";
            popup.Width = 300;
            popup.Height = 200;
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.StartPosition = FormStartPosition.CenterScreen;
            popup.MaximizeBox = false;

            // add a TextBox control to the form
            TextBox text_box_popup = new TextBox();
            text_box_popup.Text = "";
            text_box_popup.Size = new Size(120, 20);
            text_box_popup.Location = new Point(80, 40);
            popup.Controls.Add(text_box_popup);
            text_box_popup.UseSystemPasswordChar = true;

            // add a Button control to the form
            Button button = new Button();
            button.Text = "Check";
            button.DialogResult = DialogResult.OK;
            button.Location = new Point(100, 100);
            popup.Controls.Add(button);

            // display the popup window and wait for it to be closed
            popup.ShowDialog();

            string password = text_box_popup.Text;
            if (password == "1")
            {
                form_settings_doctor form_settings_doctor = new form_settings_doctor();
                form_settings_doctor.Show();
                this.Close();
            }
            else if(password!="1" && password!="")
            {
                MessageBox.Show("Invalid Password");
            }
        }

        private void label_logout_doctor_profile_Click(object sender, EventArgs e)
        {
            form_login_doctor form_login_doctor = new form_login_doctor();
            form_login_doctor.Show();
            this.Close();
            ///bla bla bal
        }

        private void listPatient1_Load(object sender, EventArgs e)
        {
            send_messagecs.send_sms();
        }
    }
}
