namespace MedstuffPrincipal
{
    partial class form_login_patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login_patient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_button_patient_login = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture_patient_login = new System.Windows.Forms.PictureBox();
            this.text_box_email_patient = new System.Windows.Forms.TextBox();
            this.text_box_password_patient = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_email_patient_login = new System.Windows.Forms.Label();
            this.label_password_patient_login = new System.Windows.Forms.Label();
            this.label_login_patient = new System.Windows.Forms.Label();
            this.label_create_account = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button_patient_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_patient_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.back_button_patient_login);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 144);
            this.panel1.TabIndex = 0;
            // 
            // back_button_patient_login
            // 
            this.back_button_patient_login.BackColor = System.Drawing.Color.Transparent;
            this.back_button_patient_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_button_patient_login.BackgroundImage")));
            this.back_button_patient_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button_patient_login.Location = new System.Drawing.Point(1150, 72);
            this.back_button_patient_login.Name = "back_button_patient_login";
            this.back_button_patient_login.Size = new System.Drawing.Size(100, 56);
            this.back_button_patient_login.TabIndex = 0;
            this.back_button_patient_login.TabStop = false;
            this.back_button_patient_login.Click += new System.EventHandler(this.back_button_patient_login_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 529);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 144);
            this.panel2.TabIndex = 1;
            // 
            // picture_patient_login
            // 
            this.picture_patient_login.BackColor = System.Drawing.Color.Transparent;
            this.picture_patient_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_patient_login.BackgroundImage")));
            this.picture_patient_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_patient_login.Location = new System.Drawing.Point(913, 207);
            this.picture_patient_login.Name = "picture_patient_login";
            this.picture_patient_login.Size = new System.Drawing.Size(337, 267);
            this.picture_patient_login.TabIndex = 2;
            this.picture_patient_login.TabStop = false;
            // 
            // text_box_email_patient
            // 
            this.text_box_email_patient.Location = new System.Drawing.Point(536, 230);
            this.text_box_email_patient.Name = "text_box_email_patient";
            this.text_box_email_patient.Size = new System.Drawing.Size(262, 22);
            this.text_box_email_patient.TabIndex = 3;
            this.text_box_email_patient.TextChanged += new System.EventHandler(this.text_box_email_patient_TextChanged);
            // 
            // text_box_password_patient
            // 
            this.text_box_password_patient.Location = new System.Drawing.Point(536, 309);
            this.text_box_password_patient.Name = "text_box_password_patient";
            this.text_box_password_patient.Size = new System.Drawing.Size(262, 22);
            this.text_box_password_patient.TabIndex = 4;
            this.text_box_password_patient.TextChanged += new System.EventHandler(this.text_box_password_patient_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 404);
            this.panel3.TabIndex = 6;
            // 
            // label_email_patient_login
            // 
            this.label_email_patient_login.AutoSize = true;
            this.label_email_patient_login.BackColor = System.Drawing.Color.Transparent;
            this.label_email_patient_login.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_email_patient_login.ForeColor = System.Drawing.SystemColors.Window;
            this.label_email_patient_login.Location = new System.Drawing.Point(370, 225);
            this.label_email_patient_login.Name = "label_email_patient_login";
            this.label_email_patient_login.Size = new System.Drawing.Size(145, 27);
            this.label_email_patient_login.TabIndex = 8;
            this.label_email_patient_login.Text = "Enter email:";
            // 
            // label_password_patient_login
            // 
            this.label_password_patient_login.AutoSize = true;
            this.label_password_patient_login.BackColor = System.Drawing.Color.Transparent;
            this.label_password_patient_login.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password_patient_login.ForeColor = System.Drawing.SystemColors.Window;
            this.label_password_patient_login.Location = new System.Drawing.Point(327, 304);
            this.label_password_patient_login.Name = "label_password_patient_login";
            this.label_password_patient_login.Size = new System.Drawing.Size(188, 27);
            this.label_password_patient_login.TabIndex = 9;
            this.label_password_patient_login.Text = "Enter password:";
            // 
            // label_login_patient
            // 
            this.label_login_patient.AutoSize = true;
            this.label_login_patient.BackColor = System.Drawing.Color.Transparent;
            this.label_login_patient.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login_patient.ForeColor = System.Drawing.SystemColors.Window;
            this.label_login_patient.Location = new System.Drawing.Point(629, 378);
            this.label_login_patient.Name = "label_login_patient";
            this.label_login_patient.Size = new System.Drawing.Size(73, 27);
            this.label_login_patient.TabIndex = 10;
            this.label_login_patient.Text = "LogIn";
            this.label_login_patient.Click += new System.EventHandler(this.label_login_patient_Click);
            // 
            // label_create_account
            // 
            this.label_create_account.AutoSize = true;
            this.label_create_account.BackColor = System.Drawing.Color.Transparent;
            this.label_create_account.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_create_account.ForeColor = System.Drawing.SystemColors.Window;
            this.label_create_account.Location = new System.Drawing.Point(532, 441);
            this.label_create_account.Name = "label_create_account";
            this.label_create_account.Size = new System.Drawing.Size(281, 20);
            this.label_create_account.TabIndex = 11;
            this.label_create_account.Text = "Don\'t have an account? Create One";
            this.label_create_account.Click += new System.EventHandler(this.label_create_account_Click);
            // 
            // form_login_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label_create_account);
            this.Controls.Add(this.label_login_patient);
            this.Controls.Add(this.label_password_patient_login);
            this.Controls.Add(this.label_email_patient_login);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.text_box_password_patient);
            this.Controls.Add(this.text_box_email_patient);
            this.Controls.Add(this.picture_patient_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_login_patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_login_patient";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_button_patient_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_patient_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picture_patient_login;
        private System.Windows.Forms.TextBox text_box_email_patient;
        private System.Windows.Forms.TextBox text_box_password_patient;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox back_button_patient_login;
        private System.Windows.Forms.Label label_email_patient_login;
        private System.Windows.Forms.Label label_password_patient_login;
        private System.Windows.Forms.Label label_login_patient;
        private System.Windows.Forms.Label label_create_account;
    }
}