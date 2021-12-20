
namespace SchApp.Forms
{
    partial class StudentEnrollmentForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.courseOneLbl = new System.Windows.Forms.Label();
            this.courseTwoLbl = new System.Windows.Forms.Label();
            this.courseThreeLbl = new System.Windows.Forms.Label();
            this.registerDateLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.registrationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.closeBtn = new System.Windows.Forms.Button();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.findStudent = new System.Windows.Forms.Button();
            this.courseBox1 = new System.Windows.Forms.ComboBox();
            this.courseBox2 = new System.Windows.Forms.ComboBox();
            this.courseBox3 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.saveToolStripMenuItem.Text = "Register";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(12, 125);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(71, 13);
            this.firstNameLbl.TabIndex = 1;
            this.firstNameLbl.Text = "First Name:";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(12, 155);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(71, 13);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Last Name:";
            // 
            // courseOneLbl
            // 
            this.courseOneLbl.AutoSize = true;
            this.courseOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseOneLbl.Location = new System.Drawing.Point(12, 185);
            this.courseOneLbl.Name = "courseOneLbl";
            this.courseOneLbl.Size = new System.Drawing.Size(86, 13);
            this.courseOneLbl.TabIndex = 3;
            this.courseOneLbl.Text = "Course Name:";
            // 
            // courseTwoLbl
            // 
            this.courseTwoLbl.AutoSize = true;
            this.courseTwoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseTwoLbl.Location = new System.Drawing.Point(12, 215);
            this.courseTwoLbl.Name = "courseTwoLbl";
            this.courseTwoLbl.Size = new System.Drawing.Size(86, 13);
            this.courseTwoLbl.TabIndex = 4;
            this.courseTwoLbl.Text = "Course Name:";
            // 
            // courseThreeLbl
            // 
            this.courseThreeLbl.AutoSize = true;
            this.courseThreeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseThreeLbl.Location = new System.Drawing.Point(12, 245);
            this.courseThreeLbl.Name = "courseThreeLbl";
            this.courseThreeLbl.Size = new System.Drawing.Size(86, 13);
            this.courseThreeLbl.TabIndex = 5;
            this.courseThreeLbl.Text = "Course Name:";
            // 
            // registerDateLbl
            // 
            this.registerDateLbl.AutoSize = true;
            this.registerDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerDateLbl.Location = new System.Drawing.Point(12, 275);
            this.registerDateLbl.Name = "registerDateLbl";
            this.registerDateLbl.Size = new System.Drawing.Size(110, 13);
            this.registerDateLbl.TabIndex = 6;
            this.registerDateLbl.Text = "Registration Date:";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.White;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.Location = new System.Drawing.Point(76, 324);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // registrationDatePicker
            // 
            this.registrationDatePicker.Location = new System.Drawing.Point(131, 269);
            this.registrationDatePicker.Name = "registrationDatePicker";
            this.registrationDatePicker.Size = new System.Drawing.Size(200, 20);
            this.registrationDatePicker.TabIndex = 4;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.White;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(192, 323);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(131, 152);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.ReadOnly = true;
            this.lastNameTxtBox.Size = new System.Drawing.Size(146, 20);
            this.lastNameTxtBox.TabIndex = 9;
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(131, 122);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.ReadOnly = true;
            this.firstNameTxtBox.Size = new System.Drawing.Size(146, 20);
            this.firstNameTxtBox.TabIndex = 8;
            // 
            // findStudent
            // 
            this.findStudent.BackColor = System.Drawing.Color.White;
            this.findStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findStudent.Location = new System.Drawing.Point(12, 42);
            this.findStudent.Name = "findStudent";
            this.findStudent.Size = new System.Drawing.Size(87, 65);
            this.findStudent.TabIndex = 0;
            this.findStudent.Text = "Load Student Information";
            this.findStudent.UseVisualStyleBackColor = false;
            this.findStudent.Click += new System.EventHandler(this.findStudent_Click);
            // 
            // courseBox1
            // 
            this.courseBox1.FormattingEnabled = true;
            this.courseBox1.Location = new System.Drawing.Point(131, 182);
            this.courseBox1.Name = "courseBox1";
            this.courseBox1.Size = new System.Drawing.Size(146, 21);
            this.courseBox1.TabIndex = 10;
            // 
            // courseBox2
            // 
            this.courseBox2.FormattingEnabled = true;
            this.courseBox2.Location = new System.Drawing.Point(131, 212);
            this.courseBox2.Name = "courseBox2";
            this.courseBox2.Size = new System.Drawing.Size(146, 21);
            this.courseBox2.TabIndex = 11;
            // 
            // courseBox3
            // 
            this.courseBox3.FormattingEnabled = true;
            this.courseBox3.Location = new System.Drawing.Point(131, 242);
            this.courseBox3.Name = "courseBox3";
            this.courseBox3.Size = new System.Drawing.Size(146, 21);
            this.courseBox3.TabIndex = 12;
            // 
            // StudentEnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 381);
            this.Controls.Add(this.courseBox3);
            this.Controls.Add(this.courseBox2);
            this.Controls.Add(this.courseBox1);
            this.Controls.Add(this.findStudent);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.registrationDatePicker);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.registerDateLbl);
            this.Controls.Add(this.courseThreeLbl);
            this.Controls.Add(this.courseTwoLbl);
            this.Controls.Add(this.courseOneLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentEnrollmentForm";
            this.Text = "Student Enrollment";
            this.Load += new System.EventHandler(this.StudentEnrollmentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label courseOneLbl;
        private System.Windows.Forms.Label courseTwoLbl;
        private System.Windows.Forms.Label courseThreeLbl;
        private System.Windows.Forms.Label registerDateLbl;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.DateTimePicker registrationDatePicker;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Button findStudent;
        private System.Windows.Forms.ComboBox courseBox1;
        private System.Windows.Forms.ComboBox courseBox2;
        private System.Windows.Forms.ComboBox courseBox3;
    }
}