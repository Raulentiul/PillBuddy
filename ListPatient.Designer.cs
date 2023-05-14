namespace MedstuffPrincipal
{
    partial class ListPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.codePacient = new System.Windows.Forms.Label();
            this.phonePacient = new System.Windows.Forms.Label();
            this.emailPacient = new System.Windows.Forms.Label();
            this.lblAfect = new System.Windows.Forms.Label();
            this.lblTrat = new System.Windows.Forms.Label();
            this.txtAfec = new System.Windows.Forms.Label();
            this.txtTrat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(4, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(515, 44);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // codePacient
            // 
            this.codePacient.AutoSize = true;
            this.codePacient.Location = new System.Drawing.Point(7, 55);
            this.codePacient.Name = "codePacient";
            this.codePacient.Size = new System.Drawing.Size(44, 16);
            this.codePacient.TabIndex = 1;
            this.codePacient.Text = "label2";
            // 
            // phonePacient
            // 
            this.phonePacient.AutoSize = true;
            this.phonePacient.Location = new System.Drawing.Point(7, 82);
            this.phonePacient.Name = "phonePacient";
            this.phonePacient.Size = new System.Drawing.Size(44, 16);
            this.phonePacient.TabIndex = 2;
            this.phonePacient.Text = "label3";
            // 
            // emailPacient
            // 
            this.emailPacient.AutoSize = true;
            this.emailPacient.Location = new System.Drawing.Point(7, 108);
            this.emailPacient.Name = "emailPacient";
            this.emailPacient.Size = new System.Drawing.Size(44, 16);
            this.emailPacient.TabIndex = 3;
            this.emailPacient.Text = "label4";
            // 
            // lblAfect
            // 
            this.lblAfect.AutoSize = true;
            this.lblAfect.Location = new System.Drawing.Point(225, 55);
            this.lblAfect.Name = "lblAfect";
            this.lblAfect.Size = new System.Drawing.Size(68, 16);
            this.lblAfect.TabIndex = 4;
            this.lblAfect.Text = "Affections:";
            // 
            // lblTrat
            // 
            this.lblTrat.AutoSize = true;
            this.lblTrat.Location = new System.Drawing.Point(475, 55);
            this.lblTrat.Name = "lblTrat";
            this.lblTrat.Size = new System.Drawing.Size(71, 16);
            this.lblTrat.TabIndex = 5;
            this.lblTrat.Text = "Treatment:";
            // 
            // txtAfec
            // 
            this.txtAfec.Location = new System.Drawing.Point(225, 82);
            this.txtAfec.Name = "txtAfec";
            this.txtAfec.Size = new System.Drawing.Size(237, 54);
            this.txtAfec.TabIndex = 6;
            this.txtAfec.Text = "Affections information";
            // 
            // txtTrat
            // 
            this.txtTrat.Location = new System.Drawing.Point(475, 82);
            this.txtTrat.Name = "txtTrat";
            this.txtTrat.Size = new System.Drawing.Size(237, 54);
            this.txtTrat.TabIndex = 7;
            this.txtTrat.Text = "Treatment information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 48);
            this.label1.TabIndex = 8;
            this.label1.Text = "Send Reminder on\r\nPhone\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ListPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrat);
            this.Controls.Add(this.txtAfec);
            this.Controls.Add(this.lblTrat);
            this.Controls.Add(this.lblAfect);
            this.Controls.Add(this.emailPacient);
            this.Controls.Add(this.phonePacient);
            this.Controls.Add(this.codePacient);
            this.Controls.Add(this.lblName);
            this.Name = "ListPatient";
            this.Size = new System.Drawing.Size(799, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label codePacient;
        private System.Windows.Forms.Label phonePacient;
        private System.Windows.Forms.Label emailPacient;
        private System.Windows.Forms.Label lblAfect;
        private System.Windows.Forms.Label lblTrat;
        private System.Windows.Forms.Label txtAfec;
        private System.Windows.Forms.Label txtTrat;
        private System.Windows.Forms.Label label1;
    }
}
