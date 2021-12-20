
namespace SchApp.Forms
{
    partial class UserForm
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
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FirstNameTxtBx = new System.Windows.Forms.TextBox();
            this.LastNameTxtBx = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.UserRoleComboBox = new System.Windows.Forms.ComboBox();
            this.UserRoleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBx = new System.Windows.Forms.TextBox();
            this.IsActiveCheckBx = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordTxtBx = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.Location = new System.Drawing.Point(23, 47);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(71, 13);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "First Name:";
            // 
            // FirstNameTxtBx
            // 
            this.FirstNameTxtBx.Location = new System.Drawing.Point(102, 44);
            this.FirstNameTxtBx.Name = "FirstNameTxtBx";
            this.FirstNameTxtBx.Size = new System.Drawing.Size(175, 20);
            this.FirstNameTxtBx.TabIndex = 1;
            // 
            // LastNameTxtBx
            // 
            this.LastNameTxtBx.Location = new System.Drawing.Point(102, 81);
            this.LastNameTxtBx.Name = "LastNameTxtBx";
            this.LastNameTxtBx.Size = new System.Drawing.Size(175, 20);
            this.LastNameTxtBx.TabIndex = 2;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.Location = new System.Drawing.Point(23, 84);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(71, 13);
            this.LastNameLbl.TabIndex = 2;
            this.LastNameLbl.Text = "Last Name:";
            // 
            // UserRoleComboBox
            // 
            this.UserRoleComboBox.FormattingEnabled = true;
            this.UserRoleComboBox.Location = new System.Drawing.Point(102, 158);
            this.UserRoleComboBox.Name = "UserRoleComboBox";
            this.UserRoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserRoleComboBox.TabIndex = 4;
            // 
            // UserRoleLbl
            // 
            this.UserRoleLbl.AutoSize = true;
            this.UserRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleLbl.Location = new System.Drawing.Point(23, 161);
            this.UserRoleLbl.Name = "UserRoleLbl";
            this.UserRoleLbl.Size = new System.Drawing.Size(73, 13);
            this.UserRoleLbl.TabIndex = 5;
            this.UserRoleLbl.Text = "User Roles:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description:";
            // 
            // DescriptionTextBx
            // 
            this.DescriptionTextBx.Location = new System.Drawing.Point(102, 201);
            this.DescriptionTextBx.Multiline = true;
            this.DescriptionTextBx.Name = "DescriptionTextBx";
            this.DescriptionTextBx.Size = new System.Drawing.Size(240, 106);
            this.DescriptionTextBx.TabIndex = 6;
            // 
            // IsActiveCheckBx
            // 
            this.IsActiveCheckBx.AutoSize = true;
            this.IsActiveCheckBx.Checked = true;
            this.IsActiveCheckBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsActiveCheckBx.Location = new System.Drawing.Point(255, 162);
            this.IsActiveCheckBx.Name = "IsActiveCheckBx";
            this.IsActiveCheckBx.Size = new System.Drawing.Size(64, 17);
            this.IsActiveCheckBx.TabIndex = 5;
            this.IsActiveCheckBx.Text = "IsActive";
            this.IsActiveCheckBx.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(22, 20);
            this.deleteToolStripMenuItem.Text = "|";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(23, 120);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(65, 13);
            this.PasswordLbl.TabIndex = 10;
            this.PasswordLbl.Text = "Password:";
            // 
            // PasswordTxtBx
            // 
            this.PasswordTxtBx.Location = new System.Drawing.Point(102, 117);
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.Size = new System.Drawing.Size(175, 20);
            this.PasswordTxtBx.TabIndex = 3;
            this.PasswordTxtBx.UseSystemPasswordChar = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 322);
            this.Controls.Add(this.PasswordTxtBx);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.IsActiveCheckBx);
            this.Controls.Add(this.DescriptionTextBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserRoleLbl);
            this.Controls.Add(this.UserRoleComboBox);
            this.Controls.Add(this.LastNameTxtBx);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameTxtBx);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserForm";
            this.Text = "User Form";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox FirstNameTxtBx;
        private System.Windows.Forms.TextBox LastNameTxtBx;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.ComboBox UserRoleComboBox;
        private System.Windows.Forms.Label UserRoleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTextBx;
        private System.Windows.Forms.CheckBox IsActiveCheckBx;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTxtBx;
    }
}