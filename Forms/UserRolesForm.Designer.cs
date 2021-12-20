
namespace SchApp.Forms
{
    partial class UserRolesForm
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
            this.NewRoleLbl = new System.Windows.Forms.Label();
            this.NewRoleTxtBox = new System.Windows.Forms.TextBox();
            this.RoleDescriptionlbl = new System.Windows.Forms.Label();
            this.RoleDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.UserRoleViewGrid = new System.Windows.Forms.DataGridView();
            this.UserRoleRefreshBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleViewGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewRoleLbl
            // 
            this.NewRoleLbl.AutoSize = true;
            this.NewRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRoleLbl.Location = new System.Drawing.Point(11, 39);
            this.NewRoleLbl.Name = "NewRoleLbl";
            this.NewRoleLbl.Size = new System.Drawing.Size(41, 15);
            this.NewRoleLbl.TabIndex = 0;
            this.NewRoleLbl.Text = "Role:";
            // 
            // NewRoleTxtBox
            // 
            this.NewRoleTxtBox.Location = new System.Drawing.Point(14, 61);
            this.NewRoleTxtBox.Name = "NewRoleTxtBox";
            this.NewRoleTxtBox.Size = new System.Drawing.Size(429, 20);
            this.NewRoleTxtBox.TabIndex = 1;
            // 
            // RoleDescriptionlbl
            // 
            this.RoleDescriptionlbl.AutoSize = true;
            this.RoleDescriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleDescriptionlbl.Location = new System.Drawing.Point(11, 90);
            this.RoleDescriptionlbl.Name = "RoleDescriptionlbl";
            this.RoleDescriptionlbl.Size = new System.Drawing.Size(118, 15);
            this.RoleDescriptionlbl.TabIndex = 0;
            this.RoleDescriptionlbl.Text = "Role Description:";
            // 
            // RoleDescriptionTxtBox
            // 
            this.RoleDescriptionTxtBox.Location = new System.Drawing.Point(12, 116);
            this.RoleDescriptionTxtBox.Multiline = true;
            this.RoleDescriptionTxtBox.Name = "RoleDescriptionTxtBox";
            this.RoleDescriptionTxtBox.Size = new System.Drawing.Size(431, 81);
            this.RoleDescriptionTxtBox.TabIndex = 2;
            // 
            // UserRoleViewGrid
            // 
            this.UserRoleViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserRoleViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserRoleViewGrid.Location = new System.Drawing.Point(8, 232);
            this.UserRoleViewGrid.Name = "UserRoleViewGrid";
            this.UserRoleViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserRoleViewGrid.Size = new System.Drawing.Size(435, 294);
            this.UserRoleViewGrid.TabIndex = 6;
            // 
            // UserRoleRefreshBtn
            // 
            this.UserRoleRefreshBtn.Location = new System.Drawing.Point(368, 203);
            this.UserRoleRefreshBtn.Name = "UserRoleRefreshBtn";
            this.UserRoleRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.UserRoleRefreshBtn.TabIndex = 4;
            this.UserRoleRefreshBtn.Text = "Show All";
            this.UserRoleRefreshBtn.UseVisualStyleBackColor = true;
            this.UserRoleRefreshBtn.Click += new System.EventHandler(this.UserRoleRefreshBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.toolStripMenuItem1,
            this.DeleteButton,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(43, 20);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(52, 20);
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UserRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 539);
            this.Controls.Add(this.UserRoleRefreshBtn);
            this.Controls.Add(this.UserRoleViewGrid);
            this.Controls.Add(this.RoleDescriptionTxtBox);
            this.Controls.Add(this.NewRoleTxtBox);
            this.Controls.Add(this.RoleDescriptionlbl);
            this.Controls.Add(this.NewRoleLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserRolesForm";
            this.Text = "User Roles - Add - Update - Delete - Search";
            this.Load += new System.EventHandler(this.UserRolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleViewGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewRoleLbl;
        private System.Windows.Forms.TextBox NewRoleTxtBox;
        private System.Windows.Forms.Label RoleDescriptionlbl;
        private System.Windows.Forms.TextBox RoleDescriptionTxtBox;
        private System.Windows.Forms.DataGridView UserRoleViewGrid;
        private System.Windows.Forms.Button UserRoleRefreshBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem DeleteButton;
    }
}