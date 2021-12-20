
namespace SchApp.Forms
{
    partial class ChangePasswordForm
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
            this.SavePassWrdBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.OldPassTxtBx = new System.Windows.Forms.TextBox();
            this.NewPassTxtBx = new System.Windows.Forms.TextBox();
            this.OldPassWrdLbl = new System.Windows.Forms.Label();
            this.NewPssWrdLbl = new System.Windows.Forms.Label();
            this.ConfrimPassWrdLbl = new System.Windows.Forms.Label();
            this.ConfirmPassTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SavePassWrdBtn
            // 
            this.SavePassWrdBtn.BackColor = System.Drawing.Color.White;
            this.SavePassWrdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SavePassWrdBtn.Location = new System.Drawing.Point(128, 125);
            this.SavePassWrdBtn.Name = "SavePassWrdBtn";
            this.SavePassWrdBtn.Size = new System.Drawing.Size(75, 23);
            this.SavePassWrdBtn.TabIndex = 3;
            this.SavePassWrdBtn.Text = "Save";
            this.SavePassWrdBtn.UseVisualStyleBackColor = false;
            this.SavePassWrdBtn.Click += new System.EventHandler(this.SavePassWrdBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Location = new System.Drawing.Point(250, 125);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // OldPassTxtBx
            // 
            this.OldPassTxtBx.Location = new System.Drawing.Point(128, 22);
            this.OldPassTxtBx.Name = "OldPassTxtBx";
            this.OldPassTxtBx.Size = new System.Drawing.Size(200, 20);
            this.OldPassTxtBx.TabIndex = 0;
            this.OldPassTxtBx.UseSystemPasswordChar = true;
            // 
            // NewPassTxtBx
            // 
            this.NewPassTxtBx.Location = new System.Drawing.Point(128, 54);
            this.NewPassTxtBx.Name = "NewPassTxtBx";
            this.NewPassTxtBx.Size = new System.Drawing.Size(200, 20);
            this.NewPassTxtBx.TabIndex = 1;
            this.NewPassTxtBx.UseSystemPasswordChar = true;
            // 
            // OldPassWrdLbl
            // 
            this.OldPassWrdLbl.AutoSize = true;
            this.OldPassWrdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPassWrdLbl.Location = new System.Drawing.Point(11, 25);
            this.OldPassWrdLbl.Name = "OldPassWrdLbl";
            this.OldPassWrdLbl.Size = new System.Drawing.Size(88, 13);
            this.OldPassWrdLbl.TabIndex = 8;
            this.OldPassWrdLbl.Text = "Old Password:";
            // 
            // NewPssWrdLbl
            // 
            this.NewPssWrdLbl.AutoSize = true;
            this.NewPssWrdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPssWrdLbl.Location = new System.Drawing.Point(11, 57);
            this.NewPssWrdLbl.Name = "NewPssWrdLbl";
            this.NewPssWrdLbl.Size = new System.Drawing.Size(94, 13);
            this.NewPssWrdLbl.TabIndex = 9;
            this.NewPssWrdLbl.Text = "New Password:";
            // 
            // ConfrimPassWrdLbl
            // 
            this.ConfrimPassWrdLbl.AutoSize = true;
            this.ConfrimPassWrdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfrimPassWrdLbl.Location = new System.Drawing.Point(11, 88);
            this.ConfrimPassWrdLbl.Name = "ConfrimPassWrdLbl";
            this.ConfrimPassWrdLbl.Size = new System.Drawing.Size(111, 13);
            this.ConfrimPassWrdLbl.TabIndex = 10;
            this.ConfrimPassWrdLbl.Text = "Confirm Password:";
            // 
            // ConfirmPassTxtBx
            // 
            this.ConfirmPassTxtBx.Location = new System.Drawing.Point(128, 85);
            this.ConfirmPassTxtBx.Name = "ConfirmPassTxtBx";
            this.ConfirmPassTxtBx.Size = new System.Drawing.Size(200, 20);
            this.ConfirmPassTxtBx.TabIndex = 2;
            this.ConfirmPassTxtBx.UseSystemPasswordChar = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 171);
            this.Controls.Add(this.ConfirmPassTxtBx);
            this.Controls.Add(this.ConfrimPassWrdLbl);
            this.Controls.Add(this.NewPssWrdLbl);
            this.Controls.Add(this.OldPassWrdLbl);
            this.Controls.Add(this.NewPassTxtBx);
            this.Controls.Add(this.OldPassTxtBx);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SavePassWrdBtn);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SavePassWrdBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox OldPassTxtBx;
        private System.Windows.Forms.TextBox NewPassTxtBx;
        private System.Windows.Forms.Label OldPassWrdLbl;
        private System.Windows.Forms.Label NewPssWrdLbl;
        private System.Windows.Forms.Label ConfrimPassWrdLbl;
        private System.Windows.Forms.TextBox ConfirmPassTxtBx;
    }
}