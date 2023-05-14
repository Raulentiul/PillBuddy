using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedstuffPrincipal
{
    public partial class form_login_patient : Form
    {
        public form_login_patient()
        {
            InitializeComponent();
        }

        private void button_login_patient_Click(object sender, EventArgs e)
        {
            string email = text_box_email_patient.Text;
            string password = text_box_password_patient.Text;
            if(email=="a" && password=="a")
            {
                form_profile_patient form_profile_patient = new form_profile_patient();
                form_profile_patient.Show();
                this.Close();
            }
            else if(email=="" && password=="")
            {
                this.Close();
            }
            else if(email != "a" || password != "a")
            {
                MessageBox.Show("Invalid Email/Password");
            }
        }

        private void button_create_account_Click(object sender, EventArgs e)
        {
            form_create_account form_create_account = new form_create_account();
            form_create_account.Show();
            this.Close();
        }

        private void back_button_patient_login_Click(object sender, EventArgs e)
        {
            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 10;
            fadeTimer.Tick += async (s, args) =>
            {
                Opacity -= 0.05; // Adjust the fading speed as desired
                if (Opacity <= 0)
                {
                    fadeTimer.Stop();

                    Form1 Form1 = new Form1();
                    Form1.StartPosition = FormStartPosition.CenterScreen;
                    Form1.Show();
                    await Task.Delay(1000); // Delay before closing the current form (adjust as needed)
                }
            };
            fadeTimer.Start();
            if (fadeTimer.Interval == 0)
            {
                this.Close();
            }
        }

        private void text_box_email_patient_TextChanged(object sender, EventArgs e)
        {
        }

        private void text_box_password_patient_TextChanged(object sender, EventArgs e)
        {
            text_box_password_patient.UseSystemPasswordChar = true;
        }

        private void label_login_patient_Click(object sender, EventArgs e)
        {
            string email = text_box_email_patient.Text;
            string password = text_box_password_patient.Text;
            if (email == "a" && password == "a")
            {
                form_profile_patient form_profile_patient = new form_profile_patient();
                form_profile_patient.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Email/Password");
            }
        }

        private void label_create_account_Click(object sender, EventArgs e)
        {
            form_create_account form_create_account = new form_create_account();
            form_create_account.Show();
            this.Close();
        }
    }
}
