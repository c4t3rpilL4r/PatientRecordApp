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
            this.components = new System.ComponentModel.Container();
            this.LvPatients = new System.Windows.Forms.ListView();
            this.ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDateOfConsultation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDoctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmsPatient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsPatient.SuspendLayout();
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
            this.LvPatients.ContextMenuStrip = this.CmsPatient;
            this.LvPatients.FullRowSelect = true;
            this.LvPatients.GridLines = true;
            this.LvPatients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvPatients.HideSelection = false;
            this.LvPatients.LabelEdit = true;
            this.LvPatients.Location = new System.Drawing.Point(12, 81);
            this.LvPatients.Name = "LvPatients";
            this.LvPatients.Size = new System.Drawing.Size(854, 439);
            this.LvPatients.TabIndex = 1;
            this.LvPatients.UseCompatibleStateImageBehavior = false;
            this.LvPatients.View = System.Windows.Forms.View.Details;
            this.LvPatients.SelectedIndexChanged += new System.EventHandler(this.LvPatients_SelectedIndexChanged);
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
            // CmsPatient
            // 
            this.CmsPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CmsPatient.Name = "CmsPatient";
            this.CmsPatient.Size = new System.Drawing.Size(117, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // FrmViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 532);
            this.Controls.Add(this.LvPatients);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmViewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Patient";
            this.Activated += new System.EventHandler(this.FrmViewPatient_Activated);
            this.CmsPatient.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip CmsPatient;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}