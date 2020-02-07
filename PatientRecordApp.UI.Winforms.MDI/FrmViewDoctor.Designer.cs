namespace PatientRecordApp.UI.Winforms.MDI
{
    partial class FrmViewDoctor
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
            this.LvDoctor = new System.Windows.Forms.ListView();
            this.ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDoctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvDoctor
            // 
            this.LvDoctor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColId,
            this.ColDoctor,
            this.ColFirstName,
            this.ColLastName,
            this.ColDepartment});
            this.LvDoctor.FullRowSelect = true;
            this.LvDoctor.GridLines = true;
            this.LvDoctor.HideSelection = false;
            this.LvDoctor.LabelEdit = true;
            this.LvDoctor.Location = new System.Drawing.Point(12, 137);
            this.LvDoctor.Name = "LvDoctor";
            this.LvDoctor.Size = new System.Drawing.Size(655, 377);
            this.LvDoctor.TabIndex = 0;
            this.LvDoctor.UseCompatibleStateImageBehavior = false;
            this.LvDoctor.View = System.Windows.Forms.View.Details;
            // 
            // ColId
            // 
            this.ColId.Text = "";
            this.ColId.Width = 0;
            // 
            // ColDoctor
            // 
            this.ColDoctor.Text = "Dr.";
            this.ColDoctor.Width = 50;
            // 
            // ColFirstName
            // 
            this.ColFirstName.Text = "First Name";
            this.ColFirstName.Width = 150;
            // 
            // ColLastName
            // 
            this.ColLastName.Text = "Last Name";
            this.ColLastName.Width = 150;
            // 
            // ColDepartment
            // 
            this.ColDepartment.Text = "Department";
            this.ColDepartment.Width = 300;
            // 
            // FrmViewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 526);
            this.Controls.Add(this.LvDoctor);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmViewDoctor";
            this.Text = "View Doctor";
            this.Activated += new System.EventHandler(this.FrmViewDoctor_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvDoctor;
        private System.Windows.Forms.ColumnHeader ColId;
        private System.Windows.Forms.ColumnHeader ColDoctor;
        private System.Windows.Forms.ColumnHeader ColFirstName;
        private System.Windows.Forms.ColumnHeader ColLastName;
        private System.Windows.Forms.ColumnHeader ColDepartment;
    }
}