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
			System.Windows.Forms.ColumnHeader ColDoctor;
			this.LvPatients = new System.Windows.Forms.ListView();
			this.ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColDateOfConsultation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ColDoctorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CmsPatient = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnResetSearch = new System.Windows.Forms.Button();
			this.GbSearchFilters = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CboDoctor = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.DtpDateOfConsultation = new System.Windows.Forms.DateTimePicker();
			this.GbGender = new System.Windows.Forms.GroupBox();
			this.RdbFemale = new System.Windows.Forms.RadioButton();
			this.RdbMale = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.TxtSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TtDiagnosis = new System.Windows.Forms.ToolTip(this.components);
			ColDoctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CmsPatient.SuspendLayout();
			this.GbSearchFilters.SuspendLayout();
			this.GbGender.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ColDoctor
			// 
			ColDoctor.Text = "Doctor";
			ColDoctor.Width = 350;
			// 
			// LvPatients
			// 
			this.LvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColId,
            this.ColSurname,
            this.ColFirstName,
            this.ColGender,
            this.ColDateOfConsultation,
            this.ColDoctorId,
            ColDoctor});
			this.LvPatients.ContextMenuStrip = this.CmsPatient;
			this.LvPatients.FullRowSelect = true;
			this.LvPatients.GridLines = true;
			this.LvPatients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.LvPatients.HideSelection = false;
			this.LvPatients.Location = new System.Drawing.Point(12, 138);
			this.LvPatients.Name = "LvPatients";
			this.LvPatients.ShowItemToolTips = true;
			this.LvPatients.Size = new System.Drawing.Size(854, 382);
			this.LvPatients.TabIndex = 1;
			this.LvPatients.UseCompatibleStateImageBehavior = false;
			this.LvPatients.View = System.Windows.Forms.View.Details;
			this.LvPatients.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LvPatients_MouseDown);
			this.LvPatients.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LvPatients_MouseMove);
			// 
			// ColId
			// 
			this.ColId.Text = "";
			this.ColId.Width = 0;
			// 
			// ColSurname
			// 
			this.ColSurname.Text = "Surname";
			this.ColSurname.Width = 150;
			// 
			// ColFirstName
			// 
			this.ColFirstName.Text = "First Name";
			this.ColFirstName.Width = 150;
			// 
			// ColGender
			// 
			this.ColGender.Text = "Gender";
			this.ColGender.Width = 50;
			// 
			// ColDateOfConsultation
			// 
			this.ColDateOfConsultation.Text = "Date Of Consultation";
			this.ColDateOfConsultation.Width = 150;
			// 
			// ColDoctorId
			// 
			this.ColDoctorId.Text = "";
			this.ColDoctorId.Width = 0;
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
			this.editToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// BtnResetSearch
			// 
			this.BtnResetSearch.Location = new System.Drawing.Point(638, 24);
			this.BtnResetSearch.Name = "BtnResetSearch";
			this.BtnResetSearch.Size = new System.Drawing.Size(155, 23);
			this.BtnResetSearch.TabIndex = 7;
			this.BtnResetSearch.Text = "Reset Search";
			this.BtnResetSearch.UseVisualStyleBackColor = true;
			this.BtnResetSearch.Click += new System.EventHandler(this.BtnResetSearch_Click);
			// 
			// GbSearchFilters
			// 
			this.GbSearchFilters.Controls.Add(this.label4);
			this.GbSearchFilters.Controls.Add(this.CboDoctor);
			this.GbSearchFilters.Controls.Add(this.label3);
			this.GbSearchFilters.Controls.Add(this.DtpDateOfConsultation);
			this.GbSearchFilters.Controls.Add(this.GbGender);
			this.GbSearchFilters.Controls.Add(this.label2);
			this.GbSearchFilters.Location = new System.Drawing.Point(30, 59);
			this.GbSearchFilters.Name = "GbSearchFilters";
			this.GbSearchFilters.Size = new System.Drawing.Size(815, 75);
			this.GbSearchFilters.TabIndex = 6;
			this.GbSearchFilters.TabStop = false;
			this.GbSearchFilters.Text = "Filters";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(450, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Doctors:";
			// 
			// CboDoctor
			// 
			this.CboDoctor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CboDoctor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.CboDoctor.FormattingEnabled = true;
			this.CboDoctor.Location = new System.Drawing.Point(453, 38);
			this.CboDoctor.Name = "CboDoctor";
			this.CboDoctor.Size = new System.Drawing.Size(337, 21);
			this.CboDoctor.TabIndex = 8;
			this.CboDoctor.SelectedIndexChanged += new System.EventHandler(this.CboDoctor_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(203, 17);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Date Of Consultation:";
			// 
			// DtpDateOfConsultation
			// 
			this.DtpDateOfConsultation.Location = new System.Drawing.Point(206, 39);
			this.DtpDateOfConsultation.Name = "DtpDateOfConsultation";
			this.DtpDateOfConsultation.Size = new System.Drawing.Size(200, 20);
			this.DtpDateOfConsultation.TabIndex = 6;
			this.DtpDateOfConsultation.ValueChanged += new System.EventHandler(this.DtpDateOfConsultation_ValueChanged);
			// 
			// GbGender
			// 
			this.GbGender.Controls.Add(this.RdbFemale);
			this.GbGender.Controls.Add(this.RdbMale);
			this.GbGender.Location = new System.Drawing.Point(23, 33);
			this.GbGender.Name = "GbGender";
			this.GbGender.Size = new System.Drawing.Size(145, 29);
			this.GbGender.TabIndex = 5;
			this.GbGender.TabStop = false;
			// 
			// RdbFemale
			// 
			this.RdbFemale.AutoSize = true;
			this.RdbFemale.Location = new System.Drawing.Point(74, 9);
			this.RdbFemale.Name = "RdbFemale";
			this.RdbFemale.Size = new System.Drawing.Size(61, 17);
			this.RdbFemale.TabIndex = 7;
			this.RdbFemale.TabStop = true;
			this.RdbFemale.Text = "Female";
			this.RdbFemale.UseVisualStyleBackColor = true;
			this.RdbFemale.CheckedChanged += new System.EventHandler(this.RdbFemale_CheckedChanged);
			// 
			// RdbMale
			// 
			this.RdbMale.AutoSize = true;
			this.RdbMale.Location = new System.Drawing.Point(13, 9);
			this.RdbMale.Name = "RdbMale";
			this.RdbMale.Size = new System.Drawing.Size(49, 17);
			this.RdbMale.TabIndex = 6;
			this.RdbMale.TabStop = true;
			this.RdbMale.Text = "Male";
			this.RdbMale.UseVisualStyleBackColor = true;
			this.RdbMale.CheckedChanged += new System.EventHandler(this.RdbMale_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Gender:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BtnSearch);
			this.groupBox2.Controls.Add(this.TxtSearch);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Location = new System.Drawing.Point(72, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(555, 45);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Search";
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(393, 12);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(155, 23);
			this.BtnSearch.TabIndex = 3;
			this.BtnSearch.Text = "Search Name";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// TxtSearch
			// 
			this.TxtSearch.Location = new System.Drawing.Point(108, 14);
			this.TxtSearch.Name = "TxtSearch";
			this.TxtSearch.Size = new System.Drawing.Size(279, 20);
			this.TxtSearch.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search By Name:";
			// 
			// TtDiagnosis
			// 
			this.TtDiagnosis.AutomaticDelay = 10000;
			// 
			// FrmViewPatient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 532);
			this.Controls.Add(this.BtnResetSearch);
			this.Controls.Add(this.GbSearchFilters);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.LvPatients);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FrmViewPatient";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "View Patient";
			this.Activated += new System.EventHandler(this.FrmViewPatient_Activated);
			this.CmsPatient.ResumeLayout(false);
			this.GbSearchFilters.ResumeLayout(false);
			this.GbSearchFilters.PerformLayout();
			this.GbGender.ResumeLayout(false);
			this.GbGender.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvPatients;
        private System.Windows.Forms.ColumnHeader ColId;
        private System.Windows.Forms.ColumnHeader ColSurname;
        private System.Windows.Forms.ColumnHeader ColFirstName;
        private System.Windows.Forms.ColumnHeader ColGender;
        private System.Windows.Forms.ColumnHeader ColDateOfConsultation;
        private System.Windows.Forms.ContextMenuStrip CmsPatient;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button BtnResetSearch;
        private System.Windows.Forms.GroupBox GbSearchFilters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpDateOfConsultation;
        private System.Windows.Forms.GroupBox GbGender;
        private System.Windows.Forms.RadioButton RdbFemale;
        private System.Windows.Forms.RadioButton RdbMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader ColDoctorId;
		private System.Windows.Forms.ToolTip TtDiagnosis;
	}
}