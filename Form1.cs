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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void picture_patient_form1_Click(object sender, EventArgs e)
        {
            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 10;
            fadeTimer.Tick += async (s, args) =>
            {
                Opacity -= 0.05; // Adjust the fading speed as desired

                if (Opacity <= 0)
                {
                    fadeTimer.Stop();
                    form_login_patient formLoginPatient = new form_login_patient();
                    formLoginPatient.StartPosition = FormStartPosition.CenterScreen;
                    formLoginPatient.Show();
                    await Task.Delay(1000); // Delay before closing the current form (adjust as needed)

                }
            };

            fadeTimer.Start();
            if (fadeTimer.Interval == 0)
            {
                this.Hide();
            }
            
        }

        private void picture_doctor_form1_Click(object sender, EventArgs e)
        {
            Timer fadeTimer = new Timer();
            fadeTimer.Interval = 10;
            fadeTimer.Tick += async (s, args) =>
            {
                Opacity -= 0.05; // Adjust the fading speed as desired

                if (Opacity <= 0)
                {
                    fadeTimer.Stop();

                    form_login_doctor form_login_doctor = new form_login_doctor();
                    form_login_doctor.StartPosition = FormStartPosition.CenterScreen;
                    form_login_doctor.Show();
                    await Task.Delay(1000); // Delay before closing the current form (adjust as needed)
                }
            };
            fadeTimer.Start();
            if (fadeTimer.Interval == 0)
            {
                this.Hide();
            }

        }



        private void label_who_Click(object sender, EventArgs e)
        {

        }
    }
}

