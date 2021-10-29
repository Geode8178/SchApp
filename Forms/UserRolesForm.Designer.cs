
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
            this.UserRoleSaveBtn = new System.Windows.Forms.Button();
            this.UserRoleDeleteBtn = new System.Windows.Forms.Button();
            this.UserRoleViewGrid = new System.Windows.Forms.DataGridView();
            this.RoleSearchlbl = new System.Windows.Forms.Label();
            this.UserRoleSearchBtn = new System.Windows.Forms.Button();
            this.UserRoleSearchComboBox = new System.Windows.Forms.ComboBox();
            this.UserRoleRefreshBtn = new System.Windows.Forms.Button();
            this.UserRoleAddDeletebtn = new System.Windows.Forms.Label();
            this.UserRoleSearchlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NewRoleLbl
            // 
            this.NewRoleLbl.AutoSize = true;
            this.NewRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRoleLbl.Location = new System.Drawing.Point(11, 39);
            this.NewRoleLbl.Name = "NewRoleLbl";
            this.NewRoleLbl.Size = new System.Drawing.Size(36, 15);
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
            this.RoleDescriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleDescriptionlbl.Location = new System.Drawing.Point(11, 90);
            this.RoleDescriptionlbl.Name = "RoleDescriptionlbl";
            this.RoleDescriptionlbl.Size = new System.Drawing.Size(101, 15);
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
            // UserRoleSaveBtn
            // 
            this.UserRoleSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserRoleSaveBtn.Location = new System.Drawing.Point(112, 87);
            this.UserRoleSaveBtn.Name = "UserRoleSaveBtn";
            this.UserRoleSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.UserRoleSaveBtn.TabIndex = 3;
            this.UserRoleSaveBtn.Text = "Save";
            this.UserRoleSaveBtn.UseVisualStyleBackColor = false;
            this.UserRoleSaveBtn.Click += new System.EventHandler(this.UserRoleSaveBtn_Click);
            // 
            // UserRoleDeleteBtn
            // 
            this.UserRoleDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UserRoleDeleteBtn.Enabled = false;
            this.UserRoleDeleteBtn.Location = new System.Drawing.Point(198, 87);
            this.UserRoleDeleteBtn.Name = "UserRoleDeleteBtn";
            this.UserRoleDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.UserRoleDeleteBtn.TabIndex = 4;
            this.UserRoleDeleteBtn.Text = "Delete";
            this.UserRoleDeleteBtn.UseVisualStyleBackColor = false;
            this.UserRoleDeleteBtn.Click += new System.EventHandler(this.UserRoleDeleteBtn_Click);
            // 
            // UserRoleViewGrid
            // 
            this.UserRoleViewGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserRoleViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserRoleViewGrid.Location = new System.Drawing.Point(8, 286);
            this.UserRoleViewGrid.Name = "UserRoleViewGrid";
            this.UserRoleViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserRoleViewGrid.Size = new System.Drawing.Size(435, 294);
            this.UserRoleViewGrid.TabIndex = 5;
            this.UserRoleViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserRoleViewGrid_CellContentClick);
            // 
            // RoleSearchlbl
            // 
            this.RoleSearchlbl.AutoSize = true;
            this.RoleSearchlbl.Location = new System.Drawing.Point(9, 262);
            this.RoleSearchlbl.Name = "RoleSearchlbl";
            this.RoleSearchlbl.Size = new System.Drawing.Size(84, 13);
            this.RoleSearchlbl.TabIndex = 7;
            this.RoleSearchlbl.Text = "Search By Role:";
            // 
            // UserRoleSearchBtn
            // 
            this.UserRoleSearchBtn.Location = new System.Drawing.Point(278, 230);
            this.UserRoleSearchBtn.Name = "UserRoleSearchBtn";
            this.UserRoleSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.UserRoleSearchBtn.TabIndex = 9;
            this.UserRoleSearchBtn.Text = "Search";
            this.UserRoleSearchBtn.UseVisualStyleBackColor = true;
            this.UserRoleSearchBtn.Click += new System.EventHandler(this.UserRoleSearchBtn_Click);
            // 
            // UserRoleSearchComboBox
            // 
            this.UserRoleSearchComboBox.FormattingEnabled = true;
            this.UserRoleSearchComboBox.Location = new System.Drawing.Point(99, 259);
            this.UserRoleSearchComboBox.Name = "UserRoleSearchComboBox";
            this.UserRoleSearchComboBox.Size = new System.Drawing.Size(344, 21);
            this.UserRoleSearchComboBox.TabIndex = 10;
            // 
            // UserRoleRefreshBtn
            // 
            this.UserRoleRefreshBtn.Location = new System.Drawing.Point(368, 230);
            this.UserRoleRefreshBtn.Name = "UserRoleRefreshBtn";
            this.UserRoleRefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.UserRoleRefreshBtn.TabIndex = 11;
            this.UserRoleRefreshBtn.Text = "Show All";
            this.UserRoleRefreshBtn.UseVisualStyleBackColor = true;
            this.UserRoleRefreshBtn.Click += new System.EventHandler(this.UserRoleRefreshBtn_Click);
            // 
            // UserRoleAddDeletebtn
            // 
            this.UserRoleAddDeletebtn.AutoSize = true;
            this.UserRoleAddDeletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleAddDeletebtn.Location = new System.Drawing.Point(14, 13);
            this.UserRoleAddDeletebtn.Name = "UserRoleAddDeletebtn";
            this.UserRoleAddDeletebtn.Size = new System.Drawing.Size(177, 16);
            this.UserRoleAddDeletebtn.TabIndex = 12;
            this.UserRoleAddDeletebtn.Text = "Add / Delete User Roles";
            // 
            // UserRoleSearchlbl
            // 
            this.UserRoleSearchlbl.AutoSize = true;
            this.UserRoleSearchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRoleSearchlbl.Location = new System.Drawing.Point(14, 214);
            this.UserRoleSearchlbl.Name = "UserRoleSearchlbl";
            this.UserRoleSearchlbl.Size = new System.Drawing.Size(131, 16);
            this.UserRoleSearchlbl.TabIndex = 13;
            this.UserRoleSearchlbl.Text = "User Role Search";
            // 
            // UserRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 587);
            this.Controls.Add(this.UserRoleSearchlbl);
            this.Controls.Add(this.UserRoleAddDeletebtn);
            this.Controls.Add(this.UserRoleRefreshBtn);
            this.Controls.Add(this.UserRoleSearchComboBox);
            this.Controls.Add(this.UserRoleSearchBtn);
            this.Controls.Add(this.RoleSearchlbl);
            this.Controls.Add(this.UserRoleViewGrid);
            this.Controls.Add(this.UserRoleDeleteBtn);
            this.Controls.Add(this.UserRoleSaveBtn);
            this.Controls.Add(this.RoleDescriptionTxtBox);
            this.Controls.Add(this.NewRoleTxtBox);
            this.Controls.Add(this.RoleDescriptionlbl);
            this.Controls.Add(this.NewRoleLbl);
            this.Name = "UserRolesForm";
            this.Text = "User Roles - Add - Update - Delete - Search";
            this.Load += new System.EventHandler(this.UserRolesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewRoleLbl;
        private System.Windows.Forms.TextBox NewRoleTxtBox;
        private System.Windows.Forms.Label RoleDescriptionlbl;
        private System.Windows.Forms.TextBox RoleDescriptionTxtBox;
        private System.Windows.Forms.Button UserRoleSaveBtn;
        private System.Windows.Forms.Button UserRoleDeleteBtn;
        private System.Windows.Forms.DataGridView UserRoleViewGrid;
        private System.Windows.Forms.Label RoleSearchlbl;
        private System.Windows.Forms.Button UserRoleSearchBtn;
        private System.Windows.Forms.ComboBox UserRoleSearchComboBox;
        private System.Windows.Forms.Button UserRoleRefreshBtn;
        private System.Windows.Forms.Label UserRoleAddDeletebtn;
        private System.Windows.Forms.Label UserRoleSearchlbl;
    }
}