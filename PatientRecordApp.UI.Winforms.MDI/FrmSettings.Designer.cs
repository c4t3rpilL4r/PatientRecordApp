namespace PatientRecordApp.UI.Winforms.MDI
{
    partial class FrmSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtHospitalName = new System.Windows.Forms.TextBox();
            this.TxtPatientCSVPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDoctorCSVPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPatientCSVBrowse = new System.Windows.Forms.Button();
            this.BtnDoctorCSVBrowse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Name:";
            // 
            // TxtHospitalName
            // 
            this.TxtHospitalName.Location = new System.Drawing.Point(125, 30);
            this.TxtHospitalName.Name = "TxtHospitalName";
            this.TxtHospitalName.Size = new System.Drawing.Size(229, 20);
            this.TxtHospitalName.TabIndex = 1;
            // 
            // TxtPatientCSVPath
            // 
            this.TxtPatientCSVPath.Location = new System.Drawing.Point(125, 56);
            this.TxtPatientCSVPath.Multiline = true;
            this.TxtPatientCSVPath.Name = "TxtPatientCSVPath";
            this.TxtPatientCSVPath.Size = new System.Drawing.Size(229, 46);
            this.TxtPatientCSVPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient CSV Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor CSV Path:";
            // 
            // TxtDoctorCSVPath
            // 
            this.TxtDoctorCSVPath.Location = new System.Drawing.Point(125, 108);
            this.TxtDoctorCSVPath.Multiline = true;
            this.TxtDoctorCSVPath.Name = "TxtDoctorCSVPath";
            this.TxtDoctorCSVPath.Size = new System.Drawing.Size(229, 46);
            this.TxtDoctorCSVPath.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.BtnDoctorCSVBrowse);
            this.groupBox1.Controls.Add(this.BtnPatientCSVBrowse);
            this.groupBox1.Controls.Add(this.TxtPatientCSVPath);
            this.groupBox1.Controls.Add(this.TxtDoctorCSVPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtHospitalName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 205);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // BtnPatientCSVBrowse
            // 
            this.BtnPatientCSVBrowse.Location = new System.Drawing.Point(360, 56);
            this.BtnPatientCSVBrowse.Name = "BtnPatientCSVBrowse";
            this.BtnPatientCSVBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnPatientCSVBrowse.TabIndex = 6;
            this.BtnPatientCSVBrowse.Text = "Browse";
            this.BtnPatientCSVBrowse.UseVisualStyleBackColor = true;
            // 
            // BtnDoctorCSVBrowse
            // 
            this.BtnDoctorCSVBrowse.Location = new System.Drawing.Point(360, 108);
            this.BtnDoctorCSVBrowse.Name = "BtnDoctorCSVBrowse";
            this.BtnDoctorCSVBrowse.Size = new System.Drawing.Size(75, 23);
            this.BtnDoctorCSVBrowse.TabIndex = 7;
            this.BtnDoctorCSVBrowse.Text = "Browse";
            this.BtnDoctorCSVBrowse.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(183, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 229);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettings";
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtHospitalName;
        private System.Windows.Forms.TextBox TxtPatientCSVPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDoctorCSVPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnDoctorCSVBrowse;
        private System.Windows.Forms.Button BtnPatientCSVBrowse;
    }
}