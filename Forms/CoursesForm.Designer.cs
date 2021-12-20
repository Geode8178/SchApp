
namespace SchApp.Forms
{
    partial class CoursesForm
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
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.courseNameTxtBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.courseDescriptionLbl = new System.Windows.Forms.Label();
            this.courseSectionTxtBox = new System.Windows.Forms.TextBox();
            this.courseNumberLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLbl.Location = new System.Drawing.Point(42, 48);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(86, 13);
            this.courseNameLbl.TabIndex = 0;
            this.courseNameLbl.Text = "Course Name:";
            // 
            // courseNameTxtBox
            // 
            this.courseNameTxtBox.Location = new System.Drawing.Point(143, 45);
            this.courseNameTxtBox.Name = "courseNameTxtBox";
            this.courseNameTxtBox.Size = new System.Drawing.Size(207, 20);
            this.courseNameTxtBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // courseDescriptionTxtBox
            // 
            this.courseDescriptionTxtBox.Location = new System.Drawing.Point(143, 80);
            this.courseDescriptionTxtBox.Multiline = true;
            this.courseDescriptionTxtBox.Name = "courseDescriptionTxtBox";
            this.courseDescriptionTxtBox.Size = new System.Drawing.Size(207, 84);
            this.courseDescriptionTxtBox.TabIndex = 4;
            // 
            // courseDescriptionLbl
            // 
            this.courseDescriptionLbl.AutoSize = true;
            this.courseDescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseDescriptionLbl.Location = new System.Drawing.Point(10, 83);
            this.courseDescriptionLbl.Name = "courseDescriptionLbl";
            this.courseDescriptionLbl.Size = new System.Drawing.Size(118, 13);
            this.courseDescriptionLbl.TabIndex = 3;
            this.courseDescriptionLbl.Text = "Course Description:";
            // 
            // courseSectionTxtBox
            // 
            this.courseSectionTxtBox.Location = new System.Drawing.Point(143, 179);
            this.courseSectionTxtBox.Name = "courseSectionTxtBox";
            this.courseSectionTxtBox.Size = new System.Drawing.Size(207, 20);
            this.courseSectionTxtBox.TabIndex = 6;
            // 
            // courseNumberLbl
            // 
            this.courseNumberLbl.AutoSize = true;
            this.courseNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNumberLbl.Location = new System.Drawing.Point(31, 182);
            this.courseNumberLbl.Name = "courseNumberLbl";
            this.courseNumberLbl.Size = new System.Drawing.Size(97, 13);
            this.courseNumberLbl.TabIndex = 5;
            this.courseNumberLbl.Text = "Course Number:";
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 244);
            this.Controls.Add(this.courseSectionTxtBox);
            this.Controls.Add(this.courseNumberLbl);
            this.Controls.Add(this.courseDescriptionTxtBox);
            this.Controls.Add(this.courseDescriptionLbl);
            this.Controls.Add(this.courseNameTxtBox);
            this.Controls.Add(this.courseNameLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CoursesForm";
            this.Text = "Add / Update Courses";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseNameLbl;
        private System.Windows.Forms.TextBox courseNameTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox courseDescriptionTxtBox;
        private System.Windows.Forms.Label courseDescriptionLbl;
        private System.Windows.Forms.TextBox courseSectionTxtBox;
        private System.Windows.Forms.Label courseNumberLbl;
    }
}