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
    public partial class form_profile_patient : Form
    {
        public form_profile_patient()
        {
            InitializeComponent();
        }

        private void label_logout_profile_patient_Click(object sender, EventArgs e)
        {
            form_login_patient form_login_patient = new form_login_patient();
            form_login_patient.Show();
            this.Close();
        }

        private void picture_box_settings_profile_patient_Click(object sender, EventArgs e)
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
            if (password == "a")
            {
                form_settings_patient form_settings_patient = new form_settings_patient();
                form_settings_patient.Show();
                this.Close();
            }
            else if (password != "a" && password != "")
            {
                MessageBox.Show("Invalid Password");
            }
        }
    }
}
