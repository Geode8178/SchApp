
namespace SchApp.Forms
{
    partial class ITAdminDashboardForm
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
            this.ViewUserSearchBtn = new System.Windows.Forms.Button();
            this.LoadUserFormBtn = new System.Windows.Forms.Button();
            this.ViewUserRoleBtn = new System.Windows.Forms.Button();
            this.LoadUserRoleFormBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUserRoleFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadUserFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPrivelegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuStripComboBxBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.ResetUserPasswordBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewUserSearchBtn
            // 
            this.ViewUserSearchBtn.BackColor = System.Drawing.Color.White;
            this.ViewUserSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewUserSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUserSearchBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ViewUserSearchBtn.Location = new System.Drawing.Point(585, 175);
            this.ViewUserSearchBtn.Name = "ViewUserSearchBtn";
            this.ViewUserSearchBtn.Size = new System.Drawing.Size(75, 67);
            this.ViewUserSearchBtn.TabIndex = 3;
            this.ViewUserSearchBtn.Text = "Search Users";
            this.ViewUserSearchBtn.UseVisualStyleBackColor = false;
            this.ViewUserSearchBtn.Click += new System.EventHandler(this.ViewUserSearchBtn_Click);
            // 
            // LoadUserFormBtn
            // 
            this.LoadUserFormBtn.BackColor = System.Drawing.Color.White;
            this.LoadUserFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadUserFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadUserFormBtn.Location = new System.Drawing.Point(481, 175);
            this.LoadUserFormBtn.Name = "LoadUserFormBtn";
            this.LoadUserFormBtn.Size = new System.Drawing.Size(75, 67);
            this.LoadUserFormBtn.TabIndex = 2;
            this.LoadUserFormBtn.Text = "Users";
            this.LoadUserFormBtn.UseVisualStyleBackColor = false;
            this.LoadUserFormBtn.Click += new System.EventHandler(this.LoadUserFormBtn_Click);
            // 
            // ViewUserRoleBtn
            // 
            this.ViewUserRoleBtn.BackColor = System.Drawing.Color.White;
            this.ViewUserRoleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewUserRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewUserRoleBtn.Location = new System.Drawing.Point(585, 57);
            this.ViewUserRoleBtn.Name = "ViewUserRoleBtn";
            this.ViewUserRoleBtn.Size = new System.Drawing.Size(75, 67);
            this.ViewUserRoleBtn.TabIndex = 1;
            this.ViewUserRoleBtn.Text = "Search User Roles";
            this.ViewUserRoleBtn.UseVisualStyleBackColor = false;
            this.ViewUserRoleBtn.Click += new System.EventHandler(this.ViewUserRoleBtn_Click);
            // 
            // LoadUserRoleFormBtn
            // 
            this.LoadUserRoleFormBtn.BackColor = System.Drawing.Color.White;
            this.LoadUserRoleFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadUserRoleFormBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadUserRoleFormBtn.Location = new System.Drawing.Point(481, 57);
            this.LoadUserRoleFormBtn.Name = "LoadUserRoleFormBtn";
            this.LoadUserRoleFormBtn.Size = new System.Drawing.Size(75, 67);
            this.LoadUserRoleFormBtn.TabIndex = 0;
            this.LoadUserRoleFormBtn.Text = "User Roles";
            this.LoadUserRoleFormBtn.UseVisualStyleBackColor = false;
            this.LoadUserRoleFormBtn.Click += new System.EventHandler(this.LoadUserRoleFormBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.FileMenuStripComboBxBtn,
            this.changePasswordToolStripMenuItem,
            this.toolStripMenuItem2,
            this.closeWindowToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadUserRoleFormToolStripMenuItem,
            this.viewUserRolesToolStripMenuItem,
            this.loadUserFormToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.userPrivelegesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // loadUserRoleFormToolStripMenuItem
            // 
            this.loadUserRoleFormToolStripMenuItem.Name = "loadUserRoleFormToolStripMenuItem";
            this.loadUserRoleFormToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadUserRoleFormToolStripMenuItem.Text = "Load User Role Form";
            this.loadUserRoleFormToolStripMenuItem.Click += new System.EventHandler(this.loadUserRoleFormToolStripMenuItem_Click);
            // 
            // viewUserRolesToolStripMenuItem
            // 
            this.viewUserRolesToolStripMenuItem.Name = "viewUserRolesToolStripMenuItem";
            this.viewUserRolesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewUserRolesToolStripMenuItem.Text = "View User Roles";
            this.viewUserRolesToolStripMenuItem.Click += new System.EventHandler(this.viewUserRolesToolStripMenuItem_Click);
            // 
            // loadUserFormToolStripMenuItem
            // 
            this.loadUserFormToolStripMenuItem.Name = "loadUserFormToolStripMenuItem";
            this.loadUserFormToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loadUserFormToolStripMenuItem.Text = "Load User Form";
            this.loadUserFormToolStripMenuItem.Click += new System.EventHandler(this.loadUserFormToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // userPrivelegesToolStripMenuItem
            // 
            this.userPrivelegesToolStripMenuItem.Name = "userPrivelegesToolStripMenuItem";
            this.userPrivelegesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.userPrivelegesToolStripMenuItem.Text = "User Access";
            // 
            // FileMenuStripComboBxBtn
            // 
            this.FileMenuStripComboBxBtn.Name = "FileMenuStripComboBxBtn";
            this.FileMenuStripComboBxBtn.Size = new System.Drawing.Size(22, 20);
            this.FileMenuStripComboBxBtn.Text = "|";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetUserPasswordToolStripMenuItem,
            this.changePasswordToolStripMenuItem1});
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // resetUserPasswordToolStripMenuItem
            // 
            this.resetUserPasswordToolStripMenuItem.Name = "resetUserPasswordToolStripMenuItem";
            this.resetUserPasswordToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.resetUserPasswordToolStripMenuItem.Text = "Reset User Password";
            this.resetUserPasswordToolStripMenuItem.Click += new System.EventHandler(this.resetUserPasswordToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = "|";
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.closeWindowToolStripMenuItem.Text = "Close Window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem3.Text = "|";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.BackColor = System.Drawing.Color.White;
            this.ChangePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordBtn.Location = new System.Drawing.Point(585, 299);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(75, 67);
            this.ChangePasswordBtn.TabIndex = 4;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = false;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // ResetUserPasswordBtn
            // 
            this.ResetUserPasswordBtn.BackColor = System.Drawing.Color.White;
            this.ResetUserPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetUserPasswordBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetUserPasswordBtn.Location = new System.Drawing.Point(481, 299);
            this.ResetUserPasswordBtn.Name = "ResetUserPasswordBtn";
            this.ResetUserPasswordBtn.Size = new System.Drawing.Size(75, 67);
            this.ResetUserPasswordBtn.TabIndex = 5;
            this.ResetUserPasswordBtn.Text = "Reset User Password";
            this.ResetUserPasswordBtn.UseVisualStyleBackColor = false;
            this.ResetUserPasswordBtn.Click += new System.EventHandler(this.ResetUserPasswordBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = global::SchApp.Properties.Resources.IT2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 309);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ITAdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 383);
            this.Controls.Add(this.ResetUserPasswordBtn);
            this.Controls.Add(this.ChangePasswordBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewUserSearchBtn);
            this.Controls.Add(this.LoadUserFormBtn);
            this.Controls.Add(this.ViewUserRoleBtn);
            this.Controls.Add(this.LoadUserRoleFormBtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ITAdminDashboardForm";
            this.Text = "IT Administrator Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoadUserRoleFormBtn;
        private System.Windows.Forms.Button ViewUserRoleBtn;
        private System.Windows.Forms.Button LoadUserFormBtn;
        private System.Windows.Forms.Button ViewUserSearchBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadUserRoleFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUserRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadUserFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripComboBxBtn;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUserPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userPrivelegesToolStripMenuItem;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.Button ResetUserPasswordBtn;
    }
}