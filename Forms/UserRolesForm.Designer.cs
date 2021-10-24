
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
            this.UserRoleUpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserRoleViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NewRoleLbl
            // 
            this.NewRoleLbl.AutoSize = true;
            this.NewRoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRoleLbl.Location = new System.Drawing.Point(12, 15);
            this.NewRoleLbl.Name = "NewRoleLbl";
            this.NewRoleLbl.Size = new System.Drawing.Size(36, 15);
            this.NewRoleLbl.TabIndex = 0;
            this.NewRoleLbl.Text = "Role:";
            // 
            // NewRoleTxtBox
            // 
            this.NewRoleTxtBox.Location = new System.Drawing.Point(15, 37);
            this.NewRoleTxtBox.Name = "NewRoleTxtBox";
            this.NewRoleTxtBox.Size = new System.Drawing.Size(259, 20);
            this.NewRoleTxtBox.TabIndex = 1;
            // 
            // RoleDescriptionlbl
            // 
            this.RoleDescriptionlbl.AutoSize = true;
            this.RoleDescriptionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleDescriptionlbl.Location = new System.Drawing.Point(12, 60);
            this.RoleDescriptionlbl.Name = "RoleDescriptionlbl";
            this.RoleDescriptionlbl.Size = new System.Drawing.Size(101, 15);
            this.RoleDescriptionlbl.TabIndex = 0;
            this.RoleDescriptionlbl.Text = "Role Description:";
            // 
            // RoleDescriptionTxtBox
            // 
            this.RoleDescriptionTxtBox.Location = new System.Drawing.Point(12, 78);
            this.RoleDescriptionTxtBox.Multiline = true;
            this.RoleDescriptionTxtBox.Name = "RoleDescriptionTxtBox";
            this.RoleDescriptionTxtBox.Size = new System.Drawing.Size(259, 81);
            this.RoleDescriptionTxtBox.TabIndex = 2;
            // 
            // UserRoleSaveBtn
            // 
            this.UserRoleSaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UserRoleSaveBtn.Location = new System.Drawing.Point(277, 78);
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
            this.UserRoleDeleteBtn.Location = new System.Drawing.Point(277, 136);
            this.UserRoleDeleteBtn.Name = "UserRoleDeleteBtn";
            this.UserRoleDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.UserRoleDeleteBtn.TabIndex = 4;
            this.UserRoleDeleteBtn.Text = "Delete";
            this.UserRoleDeleteBtn.UseVisualStyleBackColor = false;
            this.UserRoleDeleteBtn.Click += new System.EventHandler(this.UserRoleDeleteBtn_Click);
            // 
            // UserRoleViewGrid
            // 
            this.UserRoleViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserRoleViewGrid.Location = new System.Drawing.Point(12, 165);
            this.UserRoleViewGrid.Name = "UserRoleViewGrid";
            this.UserRoleViewGrid.Size = new System.Drawing.Size(340, 294);
            this.UserRoleViewGrid.TabIndex = 5;
            // 
            // UserRoleUpdateBtn
            // 
            this.UserRoleUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UserRoleUpdateBtn.Location = new System.Drawing.Point(277, 107);
            this.UserRoleUpdateBtn.Name = "UserRoleUpdateBtn";
            this.UserRoleUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UserRoleUpdateBtn.TabIndex = 6;
            this.UserRoleUpdateBtn.Text = "Update";
            this.UserRoleUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // UserRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 471);
            this.Controls.Add(this.UserRoleUpdateBtn);
            this.Controls.Add(this.UserRoleViewGrid);
            this.Controls.Add(this.UserRoleDeleteBtn);
            this.Controls.Add(this.UserRoleSaveBtn);
            this.Controls.Add(this.RoleDescriptionTxtBox);
            this.Controls.Add(this.NewRoleTxtBox);
            this.Controls.Add(this.RoleDescriptionlbl);
            this.Controls.Add(this.NewRoleLbl);
            this.Name = "UserRolesForm";
            this.Text = "User Roles";
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
        private System.Windows.Forms.Button UserRoleUpdateBtn;
    }
}