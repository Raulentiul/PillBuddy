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
    public partial class form_settings_patient : Form
    {
        public form_settings_patient()
        {
            InitializeComponent();
        }

        private void back_button_settings_patient_Click(object sender, EventArgs e)
        {
            form_profile_patient form_profile_patient = new form_profile_patient();
            form_profile_patient.Show();
            this.Close();
        }

        private void label_change_phone_number_settings_patient_Click(object sender, EventArgs e)
        {
            // create a new instance of a Form object
            Form popup = new Form();

            // set the properties of the form
            popup.Text = "Change Phone Number";
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
            text_box_popup.UseSystemPasswordChar = false;

            // add a Button control to the form
            Button button = new Button();
            button.Text = "Change";
            button.DialogResult = DialogResult.OK;
            button.Location = new Point(100, 100);
            popup.Controls.Add(button);

            // display the popup window and wait for it to be closed
            popup.ShowDialog();
            string new_phone_number = text_box_popup.Text;
            if (new_phone_number != "")
                MessageBox.Show("Changed!");
        }

        private void label_change_password_patient_Click(object sender, EventArgs e)
        {
            // create a new instance of a Form object
            Form popup = new Form();

            // set the properties of the form
            popup.Text = "Change Password";
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
            button.Text = "Change";
            button.DialogResult = DialogResult.OK;
            button.Location = new Point(100, 100);
            popup.Controls.Add(button);

            // display the popup window and wait for it to be closed
            popup.ShowDialog();
            string new_password = text_box_popup.Text;
            if (new_password != "")
                MessageBox.Show("Changed!");
        }

        private void label_change_email_patient_Click(object sender, EventArgs e)
        {
            // create a new instance of a Form object
            Form popup = new Form();

            // set the properties of the form
            popup.Text = "Change Email";
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

            // add a Button control to the form
            Button button = new Button();
            button.Text = "Change";
            button.DialogResult = DialogResult.OK;
            button.Location = new Point(100, 100);
            popup.Controls.Add(button);

            // display the popup window and wait for it to be closed
            popup.ShowDialog();
            string new_email = text_box_popup.Text;
            if (new_email != "")
                MessageBox.Show("Changed!");
        }
    }
}
