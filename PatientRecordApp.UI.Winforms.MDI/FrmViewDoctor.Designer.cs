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
            this.components = new System.ComponentModel.Container();
            this.LvDoctor = new System.Windows.Forms.ListView();
            this.ColId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDoctor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmsDoctor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmsDoctor.SuspendLayout();
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
            this.LvDoctor.ContextMenuStrip = this.CmsDoctor;
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
            // CmsDoctor
            // 
            this.CmsDoctor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CmsDoctor.Name = "CmsDoctor";
            this.CmsDoctor.Size = new System.Drawing.Size(181, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
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
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
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
            this.CmsDoctor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LvDoctor;
        private System.Windows.Forms.ColumnHeader ColId;
        private System.Windows.Forms.ColumnHeader ColDoctor;
        private System.Windows.Forms.ColumnHeader ColFirstName;
        private System.Windows.Forms.ColumnHeader ColLastName;
        private System.Windows.Forms.ColumnHeader ColDepartment;
        private System.Windows.Forms.ContextMenuStrip CmsDoctor;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}