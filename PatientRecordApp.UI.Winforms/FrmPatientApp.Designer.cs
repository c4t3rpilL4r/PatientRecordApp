namespace PatientRecordApp.UI.Winforms
{
    partial class FrmPatientApp
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
            this.ColSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDateOfConsultation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDiagnosis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDeletePatient = new System.Windows.Forms.Button();
            this.BtnEditPatient = new System.Windows.Forms.Button();
            this.BtnAddPatient = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbSearchFilters = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CboDiagnosis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpDateOfConsultation = new System.Windows.Forms.DateTimePicker();
            this.GbGender = new System.Windows.Forms.GroupBox();
            this.RdbFemale = new System.Windows.Forms.RadioButton();
            this.RdbMale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnResetSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GbSearchFilters.SuspendLayout();
            this.GbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // LvPatients
            // 
            this.LvPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColSurname,
            this.ColFirstName,
            this.ColGender,
            this.ColDateOfConsultation,
            this.ColDiagnosis});
            this.LvPatients.FullRowSelect = true;
            this.LvPatients.GridLines = true;
            this.LvPatients.HideSelection = false;
            this.LvPatients.Location = new System.Drawing.Point(12, 174);
            this.LvPatients.Name = "LvPatients";
            this.LvPatients.Size = new System.Drawing.Size(1004, 439);
            this.LvPatients.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LvPatients.TabIndex = 0;
            this.LvPatients.UseCompatibleStateImageBehavior = false;
            this.LvPatients.View = System.Windows.Forms.View.Details;
            this.LvPatients.SelectedIndexChanged += new System.EventHandler(this.LvPatients_SelectedIndexChanged);
            // 
            // ColSurname
            // 
            this.ColSurname.Text = "Surname";
            this.ColSurname.Width = 200;
            // 
            // ColFirstName
            // 
            this.ColFirstName.Text = "First Name";
            this.ColFirstName.Width = 200;
            // 
            // ColGender
            // 
            this.ColGender.Text = "Gender";
            this.ColGender.Width = 100;
            // 
            // ColDateOfConsultation
            // 
            this.ColDateOfConsultation.Text = "Date Of Consultation";
            this.ColDateOfConsultation.Width = 200;
            // 
            // ColDiagnosis
            // 
            this.ColDiagnosis.Text = "Diagnosis";
            this.ColDiagnosis.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDeletePatient);
            this.groupBox1.Controls.Add(this.BtnEditPatient);
            this.groupBox1.Controls.Add(this.BtnAddPatient);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // BtnDeletePatient
            // 
            this.BtnDeletePatient.Enabled = false;
            this.BtnDeletePatient.Location = new System.Drawing.Point(51, 109);
            this.BtnDeletePatient.Name = "BtnDeletePatient";
            this.BtnDeletePatient.Size = new System.Drawing.Size(155, 23);
            this.BtnDeletePatient.TabIndex = 2;
            this.BtnDeletePatient.Text = "Delete Patient";
            this.BtnDeletePatient.UseVisualStyleBackColor = true;
            this.BtnDeletePatient.Click += new System.EventHandler(this.BtnDeletePatient_Click);
            // 
            // BtnEditPatient
            // 
            this.BtnEditPatient.Enabled = false;
            this.BtnEditPatient.Location = new System.Drawing.Point(51, 71);
            this.BtnEditPatient.Name = "BtnEditPatient";
            this.BtnEditPatient.Size = new System.Drawing.Size(155, 23);
            this.BtnEditPatient.TabIndex = 1;
            this.BtnEditPatient.Text = "Edit Patient";
            this.BtnEditPatient.UseVisualStyleBackColor = true;
            this.BtnEditPatient.Click += new System.EventHandler(this.BtnEditPatient_Click);
            // 
            // BtnAddPatient
            // 
            this.BtnAddPatient.Location = new System.Drawing.Point(51, 33);
            this.BtnAddPatient.Name = "BtnAddPatient";
            this.BtnAddPatient.Size = new System.Drawing.Size(155, 23);
            this.BtnAddPatient.TabIndex = 0;
            this.BtnAddPatient.Text = "Add Patient";
            this.BtnAddPatient.UseVisualStyleBackColor = true;
            this.BtnAddPatient.Click += new System.EventHandler(this.BtnAddPatient_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSearch);
            this.groupBox2.Controls.Add(this.TxtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(393, 18);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(155, 23);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Search Name";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(108, 20);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(279, 20);
            this.TxtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Name:";
            // 
            // GbSearchFilters
            // 
            this.GbSearchFilters.Controls.Add(this.label4);
            this.GbSearchFilters.Controls.Add(this.CboDiagnosis);
            this.GbSearchFilters.Controls.Add(this.label3);
            this.GbSearchFilters.Controls.Add(this.DtpDateOfConsultation);
            this.GbSearchFilters.Controls.Add(this.GbGender);
            this.GbSearchFilters.Controls.Add(this.label2);
            this.GbSearchFilters.Location = new System.Drawing.Point(276, 74);
            this.GbSearchFilters.Name = "GbSearchFilters";
            this.GbSearchFilters.Size = new System.Drawing.Size(740, 94);
            this.GbSearchFilters.TabIndex = 3;
            this.GbSearchFilters.TabStop = false;
            this.GbSearchFilters.Text = "Search Filters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Diagnosis:";
            // 
            // CboDiagnosis
            // 
            this.CboDiagnosis.FormattingEnabled = true;
            this.CboDiagnosis.Location = new System.Drawing.Point(528, 46);
            this.CboDiagnosis.Name = "CboDiagnosis";
            this.CboDiagnosis.Size = new System.Drawing.Size(182, 21);
            this.CboDiagnosis.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Of Consultation:";
            // 
            // DtpDateOfConsultation
            // 
            this.DtpDateOfConsultation.Location = new System.Drawing.Point(243, 47);
            this.DtpDateOfConsultation.Name = "DtpDateOfConsultation";
            this.DtpDateOfConsultation.Size = new System.Drawing.Size(200, 20);
            this.DtpDateOfConsultation.TabIndex = 6;
            // 
            // GbGender
            // 
            this.GbGender.Controls.Add(this.RdbFemale);
            this.GbGender.Controls.Add(this.RdbMale);
            this.GbGender.Location = new System.Drawing.Point(23, 41);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gender:";
            // 
            // BtnResetSearch
            // 
            this.BtnResetSearch.Location = new System.Drawing.Point(851, 30);
            this.BtnResetSearch.Name = "BtnResetSearch";
            this.BtnResetSearch.Size = new System.Drawing.Size(155, 23);
            this.BtnResetSearch.TabIndex = 4;
            this.BtnResetSearch.Text = "Reset Search";
            this.BtnResetSearch.UseVisualStyleBackColor = true;
            this.BtnResetSearch.Click += new System.EventHandler(this.BtnResetSearch_Click);
            // 
            // FrmPatientApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 625);
            this.Controls.Add(this.BtnResetSearch);
            this.Controls.Add(this.GbSearchFilters);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LvPatients);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPatientApp";
            this.Text = "Patient Record";
            this.Activated += new System.EventHandler(this.FrmPatientApp_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GbSearchFilters.ResumeLayout(false);
            this.GbSearchFilters.PerformLayout();
            this.GbGender.ResumeLayout(false);
            this.GbGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvPatients;
        private System.Windows.Forms.ColumnHeader ColSurname;
        private System.Windows.Forms.ColumnHeader ColFirstName;
        private System.Windows.Forms.ColumnHeader ColGender;
        private System.Windows.Forms.ColumnHeader ColDateOfConsultation;
        private System.Windows.Forms.ColumnHeader ColDiagnosis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnDeletePatient;
        private System.Windows.Forms.Button BtnEditPatient;
        private System.Windows.Forms.Button BtnAddPatient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbSearchFilters;
        private System.Windows.Forms.GroupBox GbGender;
        private System.Windows.Forms.RadioButton RdbFemale;
        private System.Windows.Forms.RadioButton RdbMale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboDiagnosis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpDateOfConsultation;
        private System.Windows.Forms.Button BtnResetSearch;
    }
}

