
namespace SchApp.Forms
{
    partial class StudentInfoForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentEnrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.BirthDateLbl = new System.Windows.Forms.Label();
            this.MajorLbl = new System.Windows.Forms.Label();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBx = new System.Windows.Forms.TextBox();
            this.PhoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.emailTxtBx = new System.Windows.Forms.TextBox();
            this.ProgramComboBox = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dobDatPick = new System.Windows.Forms.DateTimePicker();
            this.enrolledDateLbl = new System.Windows.Forms.Label();
            this.enrolledDatePick = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.Location = new System.Drawing.Point(22, 243);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(71, 13);
            this.FirstNameLbl.TabIndex = 0;
            this.FirstNameLbl.Text = "First Name:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeFormToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewStudentsToolStripMenuItem,
            this.studentEnrollmentToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // studentEnrollmentToolStripMenuItem
            // 
            this.studentEnrollmentToolStripMenuItem.Name = "studentEnrollmentToolStripMenuItem";
            this.studentEnrollmentToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.studentEnrollmentToolStripMenuItem.Text = "Student Enrollment";
            this.studentEnrollmentToolStripMenuItem.Click += new System.EventHandler(this.studentEnrollmentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = "|";
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.closeFormToolStripMenuItem.Text = "Close ";
            this.closeFormToolStripMenuItem.Click += new System.EventHandler(this.closeFormToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem4.Text = "|";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.Location = new System.Drawing.Point(286, 243);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(71, 13);
            this.LastNameLbl.TabIndex = 2;
            this.LastNameLbl.Text = "Last Name:";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.Location = new System.Drawing.Point(22, 279);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(56, 13);
            this.AddressLbl.TabIndex = 4;
            this.AddressLbl.Text = "Address:";
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.AutoSize = true;
            this.PhoneNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLbl.Location = new System.Drawing.Point(286, 280);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(94, 13);
            this.PhoneNumberLbl.TabIndex = 5;
            this.PhoneNumberLbl.Text = "Phone Number:";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(22, 316);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(41, 13);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "Email:";
            // 
            // BirthDateLbl
            // 
            this.BirthDateLbl.AutoSize = true;
            this.BirthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateLbl.Location = new System.Drawing.Point(286, 317);
            this.BirthDateLbl.Name = "BirthDateLbl";
            this.BirthDateLbl.Size = new System.Drawing.Size(83, 13);
            this.BirthDateLbl.TabIndex = 7;
            this.BirthDateLbl.Text = "Date of Birth:";
            // 
            // MajorLbl
            // 
            this.MajorLbl.AutoSize = true;
            this.MajorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorLbl.Location = new System.Drawing.Point(22, 354);
            this.MajorLbl.Name = "MajorLbl";
            this.MajorLbl.Size = new System.Drawing.Size(42, 13);
            this.MajorLbl.TabIndex = 8;
            this.MajorLbl.Text = "Major:";
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(135, 240);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(122, 20);
            this.FirstNameTxtBox.TabIndex = 0;
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(386, 240);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(122, 20);
            this.LastNameTxtBox.TabIndex = 1;
            // 
            // AddressTxtBx
            // 
            this.AddressTxtBx.Location = new System.Drawing.Point(135, 277);
            this.AddressTxtBx.Name = "AddressTxtBx";
            this.AddressTxtBx.Size = new System.Drawing.Size(122, 20);
            this.AddressTxtBx.TabIndex = 3;
            // 
            // PhoneNumberTxtBox
            // 
            this.PhoneNumberTxtBox.Location = new System.Drawing.Point(386, 277);
            this.PhoneNumberTxtBox.Name = "PhoneNumberTxtBox";
            this.PhoneNumberTxtBox.Size = new System.Drawing.Size(122, 20);
            this.PhoneNumberTxtBox.TabIndex = 4;
            // 
            // emailTxtBx
            // 
            this.emailTxtBx.Location = new System.Drawing.Point(135, 314);
            this.emailTxtBx.Name = "emailTxtBx";
            this.emailTxtBx.Size = new System.Drawing.Size(122, 20);
            this.emailTxtBx.TabIndex = 5;
            // 
            // ProgramComboBox
            // 
            this.ProgramComboBox.FormattingEnabled = true;
            this.ProgramComboBox.Location = new System.Drawing.Point(136, 351);
            this.ProgramComboBox.Name = "ProgramComboBox";
            this.ProgramComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProgramComboBox.TabIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(175, 402);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(359, 402);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 11;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(267, 402);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dobDatPick
            // 
            this.dobDatPick.Location = new System.Drawing.Point(386, 314);
            this.dobDatPick.Name = "dobDatPick";
            this.dobDatPick.Size = new System.Drawing.Size(200, 20);
            this.dobDatPick.TabIndex = 6;
            // 
            // enrolledDateLbl
            // 
            this.enrolledDateLbl.AutoSize = true;
            this.enrolledDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolledDateLbl.Location = new System.Drawing.Point(286, 354);
            this.enrolledDateLbl.Name = "enrolledDateLbl";
            this.enrolledDateLbl.Size = new System.Drawing.Size(88, 13);
            this.enrolledDateLbl.TabIndex = 12;
            this.enrolledDateLbl.Text = "Enrolled Date:";
            // 
            // enrolledDatePick
            // 
            this.enrolledDatePick.Location = new System.Drawing.Point(386, 351);
            this.enrolledDatePick.Name = "enrolledDatePick";
            this.enrolledDatePick.Size = new System.Drawing.Size(200, 20);
            this.enrolledDatePick.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::SchApp.Properties.Resources.Students2;
            this.pictureBox1.Location = new System.Drawing.Point(13, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(583, 178);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enrolledDatePick);
            this.Controls.Add(this.enrolledDateLbl);
            this.Controls.Add(this.dobDatPick);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ProgramComboBox);
            this.Controls.Add(this.emailTxtBx);
            this.Controls.Add(this.PhoneNumberTxtBox);
            this.Controls.Add(this.AddressTxtBx);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.MajorLbl);
            this.Controls.Add(this.BirthDateLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.PhoneNumberLbl);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentInfoForm";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.StudentInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label PhoneNumberLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label BirthDateLbl;
        private System.Windows.Forms.Label MajorLbl;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBx;
        private System.Windows.Forms.TextBox PhoneNumberTxtBox;
        private System.Windows.Forms.TextBox emailTxtBx;
        private System.Windows.Forms.ComboBox ProgramComboBox;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentEnrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DateTimePicker dobDatPick;
        private System.Windows.Forms.Label enrolledDateLbl;
        private System.Windows.Forms.DateTimePicker enrolledDatePick;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}