namespace PatientRecordApp.UI.Winforms.MDI
{
    partial class FrmViewPatient
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
            this.LvPatients = new System.Windows.Forms.ListView();
            this.ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDateOfConsultation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDoctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvPatients
            // 
            this.LvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColId,
            this.ColSurname,
            this.ColFirstName,
            this.ColGender,
            this.ColDateOfConsultation,
            this.ColDoctor});
            this.LvPatients.FullRowSelect = true;
            this.LvPatients.GridLines = true;
            this.LvPatients.HideSelection = false;
            this.LvPatients.Location = new System.Drawing.Point(12, 82);
            this.LvPatients.Name = "LvPatients";
            this.LvPatients.Size = new System.Drawing.Size(854, 439);
            this.LvPatients.TabIndex = 1;
            this.LvPatients.UseCompatibleStateImageBehavior = false;
            this.LvPatients.View = System.Windows.Forms.View.Details;
            // 
            // ColId
            // 
            this.ColId.DisplayIndex = 5;
            this.ColId.Text = "";
            this.ColId.Width = 0;
            // 
            // ColSurname
            // 
            this.ColSurname.DisplayIndex = 0;
            this.ColSurname.Text = "Surname";
            this.ColSurname.Width = 150;
            // 
            // ColFirstName
            // 
            this.ColFirstName.DisplayIndex = 1;
            this.ColFirstName.Text = "First Name";
            this.ColFirstName.Width = 150;
            // 
            // ColGender
            // 
            this.ColGender.DisplayIndex = 2;
            this.ColGender.Text = "Gender";
            this.ColGender.Width = 50;
            // 
            // ColDateOfConsultation
            // 
            this.ColDateOfConsultation.DisplayIndex = 3;
            this.ColDateOfConsultation.Text = "Date Of Consultation";
            this.ColDateOfConsultation.Width = 150;
            // 
            // ColDoctor
            // 
            this.ColDoctor.DisplayIndex = 4;
            this.ColDoctor.Text = "Doctor";
            this.ColDoctor.Width = 350;
            // 
            // FrmViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 532);
            this.Controls.Add(this.LvPatients);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmViewPatient";
            this.Text = "View Patient";
            this.Load += new System.EventHandler(this.FrmViewPatient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvPatients;
        private System.Windows.Forms.ColumnHeader ColId;
        private System.Windows.Forms.ColumnHeader ColSurname;
        private System.Windows.Forms.ColumnHeader ColFirstName;
        private System.Windows.Forms.ColumnHeader ColGender;
        private System.Windows.Forms.ColumnHeader ColDateOfConsultation;
        private System.Windows.Forms.ColumnHeader ColDoctor;
    }
}