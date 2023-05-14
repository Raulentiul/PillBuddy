namespace MedstuffPrincipal
{
    partial class form_profile_doctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_profile_doctor));
            this.panel_profile_doctor = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listPatient1 = new MedstuffPrincipal.ListPatient();
            this.listPatient2 = new MedstuffPrincipal.ListPatient();
            this.listPatient4 = new MedstuffPrincipal.ListPatient();
            this.listPatient5 = new MedstuffPrincipal.ListPatient();
            this.picture_doctor_profile = new System.Windows.Forms.PictureBox();
            this.picture_box_settings_doctor = new System.Windows.Forms.PictureBox();
            this.label_name_profile_doctor = new System.Windows.Forms.Label();
            this.label_email_profile_doctor = new System.Windows.Forms.Label();
            this.label_phone_number_profile_doctor = new System.Windows.Forms.Label();
            this.label_logout_doctor_profile = new System.Windows.Forms.Label();
            this.label_name_name_profile_doctor = new System.Windows.Forms.Label();
            this.label_email_email_profile_doctor = new System.Windows.Forms.Label();
            this.label_phone_number_phone_number_profile_doctor = new System.Windows.Forms.Label();
            this.listPatient3 = new MedstuffPrincipal.ListPatient();
            this.panel_profile_doctor.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_doctor_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_settings_doctor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_profile_doctor
            // 
            this.panel_profile_doctor.Controls.Add(this.flowLayoutPanel1);
            this.panel_profile_doctor.Location = new System.Drawing.Point(300, -3);
            this.panel_profile_doctor.Name = "panel_profile_doctor";
            this.panel_profile_doctor.Size = new System.Drawing.Size(1000, 680);
            this.panel_profile_doctor.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.listPatient1);
            this.flowLayoutPanel1.Controls.Add(this.listPatient2);
            this.flowLayoutPanel1.Controls.Add(this.listPatient4);
            this.flowLayoutPanel1.Controls.Add(this.listPatient5);
            this.flowLayoutPanel1.Controls.Add(this.listPatient3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(997, 680);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // listPatient1
            // 
            this.listPatient1.Affections = "Affections information";
            this.listPatient1.Code = "01";
            this.listPatient1.Email = "alex01@gmail.com";
            this.listPatient1.Location = new System.Drawing.Point(3, 3);
            this.listPatient1.Name = "listPatient1";
            this.listPatient1.NamePacient = "Vlad Popescu";
            this.listPatient1.Phone = "0879324657";
            this.listPatient1.Size = new System.Drawing.Size(725, 150);
            this.listPatient1.TabIndex = 0;
            this.listPatient1.Treatment = "Treatment information";
            // 
            // listPatient2
            // 
            this.listPatient2.Affections = "Affections information";
            this.listPatient2.Code = "02";
            this.listPatient2.Email = "sebastian@yahoo.com";
            this.listPatient2.Location = new System.Drawing.Point(3, 159);
            this.listPatient2.Name = "listPatient2";
            this.listPatient2.NamePacient = "Sebastian";
            this.listPatient2.Phone = "932410041";
            this.listPatient2.Size = new System.Drawing.Size(725, 150);
            this.listPatient2.TabIndex = 1;
            this.listPatient2.Treatment = "Treatment information";
            // 
            // listPatient4
            // 
            this.listPatient4.Affections = "Affections information";
            this.listPatient4.Code = "03";
            this.listPatient4.Email = "vartejcris@yahoo.com";
            this.listPatient4.Location = new System.Drawing.Point(3, 315);
            this.listPatient4.Name = "listPatient4";
            this.listPatient4.NamePacient = "Cristian Vartej";
            this.listPatient4.Phone = "0987654321";
            this.listPatient4.Size = new System.Drawing.Size(725, 150);
            this.listPatient4.TabIndex = 3;
            this.listPatient4.Treatment = "Treatment information";
            // 
            // listPatient5
            // 
            this.listPatient5.Affections = "Affections information";
            this.listPatient5.Code = "04";
            this.listPatient5.Email = "carnmiruna@yahoo.com";
            this.listPatient5.Location = new System.Drawing.Point(3, 471);
            this.listPatient5.Name = "listPatient5";
            this.listPatient5.NamePacient = "Miruna Carnagiu";
            this.listPatient5.Phone = "1230984756";
            this.listPatient5.Size = new System.Drawing.Size(725, 150);
            this.listPatient5.TabIndex = 4;
            this.listPatient5.Treatment = "Treatment information";
            // 
            // picture_doctor_profile
            // 
            this.picture_doctor_profile.BackColor = System.Drawing.Color.Transparent;
            this.picture_doctor_profile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_doctor_profile.BackgroundImage")));
            this.picture_doctor_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_doctor_profile.Location = new System.Drawing.Point(43, 12);
            this.picture_doctor_profile.Name = "picture_doctor_profile";
            this.picture_doctor_profile.Size = new System.Drawing.Size(202, 148);
            this.picture_doctor_profile.TabIndex = 0;
            this.picture_doctor_profile.TabStop = false;
            // 
            // picture_box_settings_doctor
            // 
            this.picture_box_settings_doctor.BackColor = System.Drawing.Color.Transparent;
            this.picture_box_settings_doctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_box_settings_doctor.BackgroundImage")));
            this.picture_box_settings_doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_box_settings_doctor.Location = new System.Drawing.Point(12, 599);
            this.picture_box_settings_doctor.Name = "picture_box_settings_doctor";
            this.picture_box_settings_doctor.Size = new System.Drawing.Size(78, 62);
            this.picture_box_settings_doctor.TabIndex = 1;
            this.picture_box_settings_doctor.TabStop = false;
            this.picture_box_settings_doctor.Click += new System.EventHandler(this.picture_box_settings_doctor_Click);
            // 
            // label_name_profile_doctor
            // 
            this.label_name_profile_doctor.AutoSize = true;
            this.label_name_profile_doctor.BackColor = System.Drawing.Color.Transparent;
            this.label_name_profile_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label_name_profile_doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.label_name_profile_doctor.Location = new System.Drawing.Point(8, 209);
            this.label_name_profile_doctor.Name = "label_name_profile_doctor";
            this.label_name_profile_doctor.Size = new System.Drawing.Size(196, 20);
            this.label_name_profile_doctor.TabIndex = 2;
            this.label_name_profile_doctor.Text = "Neimulescu Prenumescu";
            // 
            // label_email_profile_doctor
            // 
            this.label_email_profile_doctor.AutoSize = true;
            this.label_email_profile_doctor.BackColor = System.Drawing.Color.Transparent;
            this.label_email_profile_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_email_profile_doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.label_email_profile_doctor.Location = new System.Drawing.Point(8, 299);
            this.label_email_profile_doctor.Name = "label_email_profile_doctor";
            this.label_email_profile_doctor.Size = new System.Drawing.Size(186, 20);
            this.label_email_profile_doctor.TabIndex = 3;
            this.label_email_profile_doctor.Text = "soricioaica12@swag.eu";
            // 
            // label_phone_number_profile_doctor
            // 
            this.label_phone_number_profile_doctor.AutoSize = true;
            this.label_phone_number_profile_doctor.BackColor = System.Drawing.Color.Transparent;
            this.label_phone_number_profile_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_phone_number_profile_doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.label_phone_number_profile_doctor.Location = new System.Drawing.Point(8, 395);
            this.label_phone_number_profile_doctor.Name = "label_phone_number_profile_doctor";
            this.label_phone_number_profile_doctor.Size = new System.Drawing.Size(118, 20);
            this.label_phone_number_profile_doctor.TabIndex = 4;
            this.label_phone_number_profile_doctor.Text = "+40728633355";
            // 
            // label_logout_doctor_profile
            // 
            this.label_logout_doctor_profile.AutoSize = true;
            this.label_logout_doctor_profile.BackColor = System.Drawing.Color.Transparent;
            this.label_logout_doctor_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_logout_doctor_profile.ForeColor = System.Drawing.SystemColors.Window;
            this.label_logout_doctor_profile.Location = new System.Drawing.Point(150, 614);
            this.label_logout_doctor_profile.Name = "label_logout_doctor_profile";
            this.label_logout_doctor_profile.Size = new System.Drawing.Size(92, 29);
            this.label_logout_doctor_profile.TabIndex = 6;
            this.label_logout_doctor_profile.Text = "LogOut";
            this.label_logout_doctor_profile.Click += new System.EventHandler(this.label_logout_doctor_profile_Click);
            // 
            // label_name_name_profile_doctor
            // 
            this.label_name_name_profile_doctor.AutoSize = true;
            this.label_name_name_profile_doctor.BackColor = System.Drawing.Color.Transparent;
            this.label_name_name_profile_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name_name_profile_doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.label_name_name_profile_doctor.Location = new System.Drawing.Point(7, 173);
            this.label_name_name_profile_doctor.Name = "label_name_name_profile_doctor";
            this.label_name_name_profile_doctor.Size = new System.Drawing.Size(78, 29);
            this.label_name_name_profile_doctor.TabIndex = 7;
            this.label_name_name_profile_doctor.Text = "Name";
            // 
            // label_email_email_profile_doctor
            // 
            this.label_email_email_profile_doctor.AutoSize = true;
            this.label_email_email_profile_doctor.BackColor = System.Drawing.Color.Transparent;
            this.label_email_email_profile_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_email_email_profile_doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.label_email_email_profile_doctor.Location = new System.Drawing.Point(7, 261);
            this.label_email_email_profile_doctor.Name = "label_email_email_profile_doctor";
            this.label_email_email_profile_doctor.Size = new System.Drawing.Size(74, 29);
            this.label_email_email_profile_doctor.TabIndex = 0;
            this.label_email_email_profile_doctor.Text = "Email";
            // 
            // label_phone_number_phone_number_profile_doctor
            // 
            this.label_phone_number_phone_number_profile_doctor.AutoSize = true;
            this.label_phone_number_phone_number_profile_doctor.BackColor = System.Drawing.Color.Transparent;
            this.label_phone_number_phone_number_profile_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_phone_number_phone_number_profile_doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.label_phone_number_phone_number_profile_doctor.Location = new System.Drawing.Point(7, 356);
            this.label_phone_number_phone_number_profile_doctor.Name = "label_phone_number_phone_number_profile_doctor";
            this.label_phone_number_phone_number_profile_doctor.Size = new System.Drawing.Size(176, 29);
            this.label_phone_number_phone_number_profile_doctor.TabIndex = 8;
            this.label_phone_number_phone_number_profile_doctor.Text = "Phone Number";
            // 
            // listPatient3
            // 
            this.listPatient3.Affections = "Affections information";
            this.listPatient3.Code = "00";
            this.listPatient3.Email = "mironsara@gmail.com";
            this.listPatient3.Location = new System.Drawing.Point(3, 627);
            this.listPatient3.Name = "listPatient3";
            this.listPatient3.NamePacient = "Sara Miron";
            this.listPatient3.Phone = "1234569870";
            this.listPatient3.Size = new System.Drawing.Size(725, 150);
            this.listPatient3.TabIndex = 5;
            this.listPatient3.Treatment = "Treatment information";
            // 
            // form_profile_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label_phone_number_phone_number_profile_doctor);
            this.Controls.Add(this.label_email_email_profile_doctor);
            this.Controls.Add(this.label_name_name_profile_doctor);
            this.Controls.Add(this.label_logout_doctor_profile);
            this.Controls.Add(this.label_phone_number_profile_doctor);
            this.Controls.Add(this.label_email_profile_doctor);
            this.Controls.Add(this.label_name_profile_doctor);
            this.Controls.Add(this.picture_box_settings_doctor);
            this.Controls.Add(this.picture_doctor_profile);
            this.Controls.Add(this.panel_profile_doctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_profile_doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_profile_doctor";
            this.panel_profile_doctor.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_doctor_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_settings_doctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_profile_doctor;
        private System.Windows.Forms.PictureBox picture_doctor_profile;
        private System.Windows.Forms.PictureBox picture_box_settings_doctor;
        private System.Windows.Forms.Label label_name_profile_doctor;
        private System.Windows.Forms.Label label_email_profile_doctor;
        private System.Windows.Forms.Label label_phone_number_profile_doctor;
        private System.Windows.Forms.Label label_logout_doctor_profile;
        private System.Windows.Forms.Label label_name_name_profile_doctor;
        private System.Windows.Forms.Label label_email_email_profile_doctor;
        private System.Windows.Forms.Label label_phone_number_phone_number_profile_doctor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ListPatient listPatient1;
        private ListPatient listPatient2;
        private ListPatient listPatient4;
        private ListPatient listPatient5;
        private ListPatient listPatient3;
    }
}