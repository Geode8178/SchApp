
namespace SchApp.Forms
{
    partial class ProgramsForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewProgramsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.degreeTypeLbl = new System.Windows.Forms.Label();
            this.programTypeTxtBx = new System.Windows.Forms.TextBox();
            this.programTypeLbl = new System.Windows.Forms.Label();
            this.programNameTxtBx = new System.Windows.Forms.TextBox();
            this.programNameLbl = new System.Windows.Forms.Label();
            this.degreeTypeCmbBx = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProgramsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.saveProgramToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewProgramsToolStripMenuItem
            // 
            this.viewProgramsToolStripMenuItem.Name = "viewProgramsToolStripMenuItem";
            this.viewProgramsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.viewProgramsToolStripMenuItem.Text = "View Programs";
            this.viewProgramsToolStripMenuItem.Click += new System.EventHandler(this.viewProgramsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // saveProgramToolStripMenuItem
            // 
            this.saveProgramToolStripMenuItem.Name = "saveProgramToolStripMenuItem";
            this.saveProgramToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.saveProgramToolStripMenuItem.Text = "Save Program";
            this.saveProgramToolStripMenuItem.Click += new System.EventHandler(this.saveProgramToolStripMenuItem_Click);
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
            // degreeTypeLbl
            // 
            this.degreeTypeLbl.AutoSize = true;
            this.degreeTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreeTypeLbl.Location = new System.Drawing.Point(13, 54);
            this.degreeTypeLbl.Name = "degreeTypeLbl";
            this.degreeTypeLbl.Size = new System.Drawing.Size(84, 13);
            this.degreeTypeLbl.TabIndex = 1;
            this.degreeTypeLbl.Text = "Degree Type:";
            // 
            // programTypeTxtBx
            // 
            this.programTypeTxtBx.Location = new System.Drawing.Point(108, 91);
            this.programTypeTxtBx.Name = "programTypeTxtBx";
            this.programTypeTxtBx.Size = new System.Drawing.Size(168, 20);
            this.programTypeTxtBx.TabIndex = 4;
            // 
            // programTypeLbl
            // 
            this.programTypeLbl.AutoSize = true;
            this.programTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programTypeLbl.Location = new System.Drawing.Point(13, 94);
            this.programTypeLbl.Name = "programTypeLbl";
            this.programTypeLbl.Size = new System.Drawing.Size(89, 13);
            this.programTypeLbl.TabIndex = 3;
            this.programTypeLbl.Text = "Program Type:";
            // 
            // programNameTxtBx
            // 
            this.programNameTxtBx.Location = new System.Drawing.Point(108, 131);
            this.programNameTxtBx.Name = "programNameTxtBx";
            this.programNameTxtBx.Size = new System.Drawing.Size(168, 20);
            this.programNameTxtBx.TabIndex = 6;
            // 
            // programNameLbl
            // 
            this.programNameLbl.AutoSize = true;
            this.programNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programNameLbl.Location = new System.Drawing.Point(13, 134);
            this.programNameLbl.Name = "programNameLbl";
            this.programNameLbl.Size = new System.Drawing.Size(93, 13);
            this.programNameLbl.TabIndex = 5;
            this.programNameLbl.Text = "Program Name:";
            // 
            // degreeTypeCmbBx
            // 
            this.degreeTypeCmbBx.FormattingEnabled = true;
            this.degreeTypeCmbBx.Location = new System.Drawing.Point(108, 51);
            this.degreeTypeCmbBx.Name = "degreeTypeCmbBx";
            this.degreeTypeCmbBx.Size = new System.Drawing.Size(168, 21);
            this.degreeTypeCmbBx.TabIndex = 7;
            // 
            // ProgramsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 196);
            this.Controls.Add(this.degreeTypeCmbBx);
            this.Controls.Add(this.programNameTxtBx);
            this.Controls.Add(this.programNameLbl);
            this.Controls.Add(this.programTypeTxtBx);
            this.Controls.Add(this.programTypeLbl);
            this.Controls.Add(this.degreeTypeLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProgramsForm";
            this.Text = "Add / Update Scholastic Programs";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewProgramsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label degreeTypeLbl;
        private System.Windows.Forms.TextBox programTypeTxtBx;
        private System.Windows.Forms.Label programTypeLbl;
        private System.Windows.Forms.TextBox programNameTxtBx;
        private System.Windows.Forms.Label programNameLbl;
        private System.Windows.Forms.ComboBox degreeTypeCmbBx;
    }
}