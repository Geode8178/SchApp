
namespace SchApp.Forms
{
    partial class UserRoleSearchForm
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
            this.SearchByRoleLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addUserRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchRolesDataGridView = new System.Windows.Forms.DataGridView();
            this.UserRolesSearchComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchRolesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchByRoleLbl
            // 
            this.SearchByRoleLbl.AutoSize = true;
            this.SearchByRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByRoleLbl.Location = new System.Drawing.Point(10, 58);
            this.SearchByRoleLbl.Name = "SearchByRoleLbl";
            this.SearchByRoleLbl.Size = new System.Drawing.Size(171, 18);
            this.SearchByRoleLbl.TabIndex = 0;
            this.SearchByRoleLbl.Text = "Search By User Role:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserRoleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addUserRoleToolStripMenuItem
            // 
            this.addUserRoleToolStripMenuItem.Name = "addUserRoleToolStripMenuItem";
            this.addUserRoleToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.addUserRoleToolStripMenuItem.Text = "Add User Role";
            this.addUserRoleToolStripMenuItem.Click += new System.EventHandler(this.addUserRoleToolStripMenuItem_Click);
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
            // SearchRolesDataGridView
            // 
            this.SearchRolesDataGridView.AllowUserToAddRows = false;
            this.SearchRolesDataGridView.AllowUserToDeleteRows = false;
            this.SearchRolesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SearchRolesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchRolesDataGridView.Location = new System.Drawing.Point(13, 82);
            this.SearchRolesDataGridView.Name = "SearchRolesDataGridView";
            this.SearchRolesDataGridView.ReadOnly = true;
            this.SearchRolesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchRolesDataGridView.Size = new System.Drawing.Size(773, 296);
            this.SearchRolesDataGridView.TabIndex = 3;
            this.SearchRolesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchRolesDataGridView_CellContentClick);
            // 
            // UserRolesSearchComboBox
            // 
            this.UserRolesSearchComboBox.FormattingEnabled = true;
            this.UserRolesSearchComboBox.Location = new System.Drawing.Point(187, 55);
            this.UserRolesSearchComboBox.Name = "UserRolesSearchComboBox";
            this.UserRolesSearchComboBox.Size = new System.Drawing.Size(376, 21);
            this.UserRolesSearchComboBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(621, 53);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(711, 53);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // UserRoleSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.UserRolesSearchComboBox);
            this.Controls.Add(this.SearchRolesDataGridView);
            this.Controls.Add(this.SearchByRoleLbl);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserRoleSearchForm";
            this.Text = "Search User Roles";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchRolesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchByRoleLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addUserRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView SearchRolesDataGridView;
        private System.Windows.Forms.ComboBox UserRolesSearchComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RefreshButton;
    }
}