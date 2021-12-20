
namespace SchApp.Forms
{
    partial class ResetUserPasswordForm
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
            this.UserFirstNameLbl = new System.Windows.Forms.Label();
            this.UserFirstNameTxtBx = new System.Windows.Forms.TextBox();
            this.NewUserPasswordTextBx = new System.Windows.Forms.TextBox();
            this.NewUserPassWordLbl = new System.Windows.Forms.Label();
            this.ResetPasswordBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.UserLastNameTextBx = new System.Windows.Forms.TextBox();
            this.UserLastNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserFirstNameLbl
            // 
            this.UserFirstNameLbl.AutoSize = true;
            this.UserFirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFirstNameLbl.Location = new System.Drawing.Point(26, 49);
            this.UserFirstNameLbl.Name = "UserFirstNameLbl";
            this.UserFirstNameLbl.Size = new System.Drawing.Size(101, 13);
            this.UserFirstNameLbl.TabIndex = 0;
            this.UserFirstNameLbl.Text = "User First Name:";
            // 
            // UserFirstNameTxtBx
            // 
            this.UserFirstNameTxtBx.Location = new System.Drawing.Point(133, 46);
            this.UserFirstNameTxtBx.Name = "UserFirstNameTxtBx";
            this.UserFirstNameTxtBx.Size = new System.Drawing.Size(177, 20);
            this.UserFirstNameTxtBx.TabIndex = 0;
            // 
            // NewUserPasswordTextBx
            // 
            this.NewUserPasswordTextBx.Location = new System.Drawing.Point(133, 112);
            this.NewUserPasswordTextBx.Name = "NewUserPasswordTextBx";
            this.NewUserPasswordTextBx.Size = new System.Drawing.Size(177, 20);
            this.NewUserPasswordTextBx.TabIndex = 2;
            this.NewUserPasswordTextBx.UseSystemPasswordChar = true;
            // 
            // NewUserPassWordLbl
            // 
            this.NewUserPassWordLbl.AutoSize = true;
            this.NewUserPassWordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserPassWordLbl.Location = new System.Drawing.Point(26, 115);
            this.NewUserPassWordLbl.Name = "NewUserPassWordLbl";
            this.NewUserPassWordLbl.Size = new System.Drawing.Size(94, 13);
            this.NewUserPassWordLbl.TabIndex = 2;
            this.NewUserPassWordLbl.Text = "New Password:";
            // 
            // ResetPasswordBtn
            // 
            this.ResetPasswordBtn.BackColor = System.Drawing.Color.White;
            this.ResetPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetPasswordBtn.Location = new System.Drawing.Point(133, 168);
            this.ResetPasswordBtn.Name = "ResetPasswordBtn";
            this.ResetPasswordBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetPasswordBtn.TabIndex = 3;
            this.ResetPasswordBtn.Text = "Reset ";
            this.ResetPasswordBtn.UseVisualStyleBackColor = false;
            this.ResetPasswordBtn.Click += new System.EventHandler(this.ResetPasswordBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Location = new System.Drawing.Point(235, 168);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // UserLastNameTextBx
            // 
            this.UserLastNameTextBx.Location = new System.Drawing.Point(133, 79);
            this.UserLastNameTextBx.Name = "UserLastNameTextBx";
            this.UserLastNameTextBx.Size = new System.Drawing.Size(177, 20);
            this.UserLastNameTextBx.TabIndex = 1;
            // 
            // UserLastNameLbl
            // 
            this.UserLastNameLbl.AutoSize = true;
            this.UserLastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLastNameLbl.Location = new System.Drawing.Point(26, 82);
            this.UserLastNameLbl.Name = "UserLastNameLbl";
            this.UserLastNameLbl.Size = new System.Drawing.Size(101, 13);
            this.UserLastNameLbl.TabIndex = 6;
            this.UserLastNameLbl.Text = "User Last Name:";
            // 
            // ResetUserPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 236);
            this.Controls.Add(this.UserLastNameTextBx);
            this.Controls.Add(this.UserLastNameLbl);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ResetPasswordBtn);
            this.Controls.Add(this.NewUserPasswordTextBx);
            this.Controls.Add(this.NewUserPassWordLbl);
            this.Controls.Add(this.UserFirstNameTxtBx);
            this.Controls.Add(this.UserFirstNameLbl);
            this.Name = "ResetUserPasswordForm";
            this.Text = "Reset User Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserFirstNameLbl;
        private System.Windows.Forms.TextBox UserFirstNameTxtBx;
        private System.Windows.Forms.TextBox NewUserPasswordTextBx;
        private System.Windows.Forms.Label NewUserPassWordLbl;
        private System.Windows.Forms.Button ResetPasswordBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox UserLastNameTextBx;
        private System.Windows.Forms.Label UserLastNameLbl;
    }
}