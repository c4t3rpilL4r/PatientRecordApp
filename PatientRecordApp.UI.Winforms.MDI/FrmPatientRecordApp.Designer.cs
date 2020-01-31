namespace PatientRecordApp.UI.Winforms.MDI
{
    partial class FrmPatientRecordApp
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
            this.MnsPatientRecord = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsPatientRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnsPatientRecord
            // 
            this.MnsPatientRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.MnsPatientRecord.Location = new System.Drawing.Point(0, 0);
            this.MnsPatientRecord.Name = "MnsPatientRecord";
            this.MnsPatientRecord.Size = new System.Drawing.Size(800, 24);
            this.MnsPatientRecord.TabIndex = 1;
            this.MnsPatientRecord.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.doctorToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.doctorToolStripMenuItem.Text = "Doctor";
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem1,
            this.doctorToolStripMenuItem1});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // patientToolStripMenuItem1
            // 
            this.patientToolStripMenuItem1.Name = "patientToolStripMenuItem1";
            this.patientToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.patientToolStripMenuItem1.Text = "Patient";
            // 
            // doctorToolStripMenuItem1
            // 
            this.doctorToolStripMenuItem1.Name = "doctorToolStripMenuItem1";
            this.doctorToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.doctorToolStripMenuItem1.Text = "Doctor";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // FrmPatientRecordApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.MnsPatientRecord);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MnsPatientRecord;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPatientRecordApp";
            this.Text = "Patient Record App";
            this.Load += new System.EventHandler(this.FrmPatientRecordApp_Load);
            this.MnsPatientRecord.ResumeLayout(false);
            this.MnsPatientRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnsPatientRecord;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}