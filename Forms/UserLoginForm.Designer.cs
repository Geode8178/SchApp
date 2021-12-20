
namespace SchApp.Forms
{
    partial class UserLoginForm
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
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.UserNameTxtBx = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.PasswordTxtBx = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LastNameTxtBx = new System.Windows.Forms.TextBox();
            this.LoginLogoBx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogoBx)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.Location = new System.Drawing.Point(12, 239);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(71, 13);
            this.UserNameLbl.TabIndex = 0;
            this.UserNameLbl.Text = "First Name:";
            // 
            // UserNameTxtBx
            // 
            this.UserNameTxtBx.Location = new System.Drawing.Point(91, 236);
            this.UserNameTxtBx.Name = "UserNameTxtBx";
            this.UserNameTxtBx.Size = new System.Drawing.Size(307, 20);
            this.UserNameTxtBx.TabIndex = 0;
            this.UserNameTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBtn.Location = new System.Drawing.Point(136, 357);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(12, 319);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(65, 13);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Password:";
            // 
            // PasswordTxtBx
            // 
            this.PasswordTxtBx.Location = new System.Drawing.Point(91, 316);
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.Size = new System.Drawing.Size(307, 20);
            this.PasswordTxtBx.TabIndex = 2;
            this.PasswordTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTxtBx.UseSystemPasswordChar = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitBtn.Location = new System.Drawing.Point(270, 357);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.Location = new System.Drawing.Point(12, 280);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(71, 13);
            this.LastNameLbl.TabIndex = 5;
            this.LastNameLbl.Text = "Last Name:";
            // 
            // LastNameTxtBx
            // 
            this.LastNameTxtBx.Location = new System.Drawing.Point(91, 277);
            this.LastNameTxtBx.Name = "LastNameTxtBx";
            this.LastNameTxtBx.Size = new System.Drawing.Size(307, 20);
            this.LastNameTxtBx.TabIndex = 1;
            this.LastNameTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginLogoBx
            // 
            this.LoginLogoBx.BackColor = System.Drawing.Color.White;
            this.LoginLogoBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginLogoBx.Image = global::SchApp.Properties.Resources.ApplicationName3;
            this.LoginLogoBx.Location = new System.Drawing.Point(12, 24);
            this.LoginLogoBx.Name = "LoginLogoBx";
            this.LoginLogoBx.Size = new System.Drawing.Size(386, 193);
            this.LoginLogoBx.TabIndex = 3;
            this.LoginLogoBx.TabStop = false;
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 408);
            this.Controls.Add(this.LastNameTxtBx);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PasswordTxtBx);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LoginLogoBx);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.UserNameTxtBx);
            this.Controls.Add(this.UserNameLbl);
            this.Name = "UserLoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.LoginLogoBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.TextBox UserNameTxtBx;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.PictureBox LoginLogoBx;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox PasswordTxtBx;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox LastNameTxtBx;
    }
}