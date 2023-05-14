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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MedstuffPrincipal
{
    public partial class form_login_doctor : Form
    {
        public form_login_doctor()
        {
            InitializeComponent();
        }

        private void button_login_doctor_Click(object sender, EventArgs e)
        {
            string code = text_box_code_doctor.Text;
            string password = text_box_password_doctor.Text;
            if(code=="Xj91S08!" && password=="1")
            {
                form_profile_doctor form_profile_doctor = new form_profile_doctor();
                form_profile_doctor.Show();
                this.Close();
            }
            else if(code == "" && password == "")
            {
                this.Close();
            }
            else if (code != "a" || password != "a")
            {
                MessageBox.Show("Invalid Email/Password");
            }
        }

        private void back_button_doctor_login_Click(object sender, EventArgs e)
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
    

        private void label_login_doctor_Click(object sender, EventArgs e)
        {
            string code = text_box_code_doctor.Text;
            string password = text_box_password_doctor.Text;
            if (code == "Xj91S08!" && password == "1")
            {
                form_profile_doctor form_profile_doctor = new form_profile_doctor();
                form_profile_doctor.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Code/Password");
            }
        }

        private void text_box_password_doctor_TextChanged(object sender, EventArgs e)
        {
            text_box_password_doctor.UseSystemPasswordChar = true;
        }

        private void text_box_code_doctor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
