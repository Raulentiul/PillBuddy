namespace MedstuffPrincipal
{
    partial class form_login_doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login_doctor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_button_doctor_login = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picture_doctor_login = new System.Windows.Forms.PictureBox();
            this.text_box_code_doctor = new System.Windows.Forms.TextBox();
            this.text_box_password_doctor = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_code_doctor_login = new System.Windows.Forms.Label();
            this.label_password_doctor_login = new System.Windows.Forms.Label();
            this.label_login_doctor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_button_doctor_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_doctor_login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.back_button_doctor_login);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 144);
            this.panel1.TabIndex = 0;
            // 
            // back_button_doctor_login
            // 
            this.back_button_doctor_login.BackColor = System.Drawing.Color.Transparent;
            this.back_button_doctor_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_button_doctor_login.BackgroundImage")));
            this.back_button_doctor_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button_doctor_login.Location = new System.Drawing.Point(12, 72);
            this.back_button_doctor_login.Name = "back_button_doctor_login";
            this.back_button_doctor_login.Size = new System.Drawing.Size(100, 56);
            this.back_button_doctor_login.TabIndex = 2;
            this.back_button_doctor_login.TabStop = false;
            this.back_button_doctor_login.Click += new System.EventHandler(this.back_button_doctor_login_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(909, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 357);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 144);
            this.panel2.TabIndex = 1;
            // 
            // picture_doctor_login
            // 
            this.picture_doctor_login.BackColor = System.Drawing.Color.Transparent;
            this.picture_doctor_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_doctor_login.BackgroundImage")));
            this.picture_doctor_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_doctor_login.Location = new System.Drawing.Point(12, 191);
            this.picture_doctor_login.Name = "picture_doctor_login";
            this.picture_doctor_login.Size = new System.Drawing.Size(369, 293);
            this.picture_doctor_login.TabIndex = 2;
            this.picture_doctor_login.TabStop = false;
            // 
            // text_box_code_doctor
            // 
            this.text_box_code_doctor.Location = new System.Drawing.Point(664, 245);
            this.text_box_code_doctor.Name = "text_box_code_doctor";
            this.text_box_code_doctor.Size = new System.Drawing.Size(275, 22);
            this.text_box_code_doctor.TabIndex = 3;
            this.text_box_code_doctor.TextChanged += new System.EventHandler(this.text_box_code_doctor_TextChanged);
            // 
            // text_box_password_doctor
            // 
            this.text_box_password_doctor.Location = new System.Drawing.Point(664, 339);
            this.text_box_password_doctor.Name = "text_box_password_doctor";
            this.text_box_password_doctor.Size = new System.Drawing.Size(275, 22);
            this.text_box_password_doctor.TabIndex = 4;
            this.text_box_password_doctor.TextChanged += new System.EventHandler(this.text_box_password_doctor_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1009, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(256, 399);
            this.panel4.TabIndex = 6;
            // 
            // label_code_doctor_login
            // 
            this.label_code_doctor_login.AutoSize = true;
            this.label_code_doctor_login.BackColor = System.Drawing.Color.Transparent;
            this.label_code_doctor_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_code_doctor_login.ForeColor = System.Drawing.SystemColors.Window;
            this.label_code_doctor_login.Location = new System.Drawing.Point(416, 240);
            this.label_code_doctor_login.Name = "label_code_doctor_login";
            this.label_code_doctor_login.Size = new System.Drawing.Size(215, 29);
            this.label_code_doctor_login.TabIndex = 7;
            this.label_code_doctor_login.Text = "Enter unique code:";
            // 
            // label_password_doctor_login
            // 
            this.label_password_doctor_login.AutoSize = true;
            this.label_password_doctor_login.BackColor = System.Drawing.Color.Transparent;
            this.label_password_doctor_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password_doctor_login.ForeColor = System.Drawing.SystemColors.Window;
            this.label_password_doctor_login.Location = new System.Drawing.Point(456, 334);
            this.label_password_doctor_login.Name = "label_password_doctor_login";
            this.label_password_doctor_login.Size = new System.Drawing.Size(189, 29);
            this.label_password_doctor_login.TabIndex = 8;
            this.label_password_doctor_login.Text = "Enter Password:";
            // 
            // label_login_doctor
            // 
            this.label_login_doctor.AutoSize = true;
            this.label_login_doctor.BackColor = System.Drawing.Color.Transparent;
            this.label_login_doctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_login_doctor.ForeColor = System.Drawing.SystemColors.Window;
            this.label_login_doctor.Location = new System.Drawing.Point(765, 432);
            this.label_login_doctor.Name = "label_login_doctor";
            this.label_login_doctor.Size = new System.Drawing.Size(73, 29);
            this.label_login_doctor.TabIndex = 9;
            this.label_login_doctor.Text = "LogIn";
            this.label_login_doctor.Click += new System.EventHandler(this.label_login_doctor_Click);
            // 
            // form_login_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label_login_doctor);
            this.Controls.Add(this.label_password_doctor_login);
            this.Controls.Add(this.label_code_doctor_login);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.text_box_password_doctor);
            this.Controls.Add(this.text_box_code_doctor);
            this.Controls.Add(this.picture_doctor_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_login_doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PillBuddy";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_button_doctor_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_doctor_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picture_doctor_login;
        private System.Windows.Forms.TextBox text_box_code_doctor;
        private System.Windows.Forms.TextBox text_box_password_doctor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox back_button_doctor_login;
        private System.Windows.Forms.Label label_code_doctor_login;
        private System.Windows.Forms.Label label_password_doctor_login;
        private System.Windows.Forms.Label label_login_doctor;
    }
}