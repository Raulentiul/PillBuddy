namespace MedstuffPrincipal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture_patient_form1 = new System.Windows.Forms.PictureBox();
            this.picture_doctor_form1 = new System.Windows.Forms.PictureBox();
            this.label_who = new System.Windows.Forms.Label();
            this.label_patient_who = new System.Windows.Forms.Label();
            this.label_doctor_who = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_patient_form1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_doctor_form1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_patient_form1
            // 
            this.picture_patient_form1.BackColor = System.Drawing.Color.Transparent;
            this.picture_patient_form1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_patient_form1.BackgroundImage")));
            this.picture_patient_form1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_patient_form1.Location = new System.Drawing.Point(129, 271);
            this.picture_patient_form1.Name = "picture_patient_form1";
            this.picture_patient_form1.Size = new System.Drawing.Size(337, 267);
            this.picture_patient_form1.TabIndex = 2;
            this.picture_patient_form1.TabStop = false;
            this.picture_patient_form1.Click += new System.EventHandler(this.picture_patient_form1_Click);
            // 
            // picture_doctor_form1
            // 
            this.picture_doctor_form1.BackColor = System.Drawing.Color.Transparent;
            this.picture_doctor_form1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_doctor_form1.BackgroundImage")));
            this.picture_doctor_form1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_doctor_form1.Location = new System.Drawing.Point(788, 245);
            this.picture_doctor_form1.Name = "picture_doctor_form1";
            this.picture_doctor_form1.Size = new System.Drawing.Size(369, 293);
            this.picture_doctor_form1.TabIndex = 3;
            this.picture_doctor_form1.TabStop = false;
            this.picture_doctor_form1.Click += new System.EventHandler(this.picture_doctor_form1_Click);
            // 
            // label_who
            // 
            this.label_who.AutoSize = true;
            this.label_who.BackColor = System.Drawing.Color.Transparent;
            this.label_who.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_who.ForeColor = System.Drawing.SystemColors.Window;
            this.label_who.Location = new System.Drawing.Point(371, 47);
            this.label_who.Name = "label_who";
            this.label_who.Size = new System.Drawing.Size(487, 91);
            this.label_who.TabIndex = 4;
            this.label_who.Text = "Are you a...?";
            this.label_who.Click += new System.EventHandler(this.label_who_Click);
            // 
            // label_patient_who
            // 
            this.label_patient_who.AutoSize = true;
            this.label_patient_who.BackColor = System.Drawing.Color.Transparent;
            this.label_patient_who.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_patient_who.ForeColor = System.Drawing.SystemColors.Window;
            this.label_patient_who.Location = new System.Drawing.Point(206, 564);
            this.label_patient_who.Name = "label_patient_who";
            this.label_patient_who.Size = new System.Drawing.Size(157, 51);
            this.label_patient_who.TabIndex = 5;
            this.label_patient_who.Text = "Patient";
            // 
            // label_doctor_who
            // 
            this.label_doctor_who.AutoSize = true;
            this.label_doctor_who.BackColor = System.Drawing.Color.Transparent;
            this.label_doctor_who.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_doctor_who.ForeColor = System.Drawing.SystemColors.Window;
            this.label_doctor_who.Location = new System.Drawing.Point(895, 564);
            this.label_doctor_who.Name = "label_doctor_who";
            this.label_doctor_who.Size = new System.Drawing.Size(149, 51);
            this.label_doctor_who.TabIndex = 6;
            this.label_doctor_who.Text = "Doctor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label_doctor_who);
            this.Controls.Add(this.label_patient_who);
            this.Controls.Add(this.label_who);
            this.Controls.Add(this.picture_doctor_form1);
            this.Controls.Add(this.picture_patient_form1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PillBuddy";
            ((System.ComponentModel.ISupportInitialize)(this.picture_patient_form1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_doctor_form1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_patient_form1;
        private System.Windows.Forms.PictureBox picture_doctor_form1;
        private System.Windows.Forms.Label label_who;
        private System.Windows.Forms.Label label_patient_who;
        private System.Windows.Forms.Label label_doctor_who;
    }
}

