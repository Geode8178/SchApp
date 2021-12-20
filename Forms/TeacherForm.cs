using SchApp.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchApp.Forms
{
    public partial class TeacherForm : Template
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        public string FirstName { get; set; }

        public bool IsUpdate { get; set; }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (this.IsUpdate == true)
                {
                    {   //Do update Process
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_Teachers_UpdateTeacherInformation", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@OldFirstName", this.FirstName);
                                cmd.Parameters.AddWithValue("@FirstName", firstNameTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@LastName", lastNameTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", emailAddressTxtBx.Text.Trim());
                                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTxtBx.Text.Trim());
                                cmd.Parameters.AddWithValue("@SubjectTaught", subjectTaughtTxtBox.Text.Trim());

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("This teacher has been successfully updated!","Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                resetForm();
                                this.Close();
                            }
                        }
                    }
                }
                else
                {   //Do Insert Process
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_Teachers_InsertNewTeacher", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@FirstName", firstNameTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@LastName", lastNameTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", emailAddressTxtBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTxtBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@SubjectTaught", subjectTaughtTxtBox.Text.Trim());

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Teacher has been successfully added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            resetForm();
                        }
                    }
                }
            }
        }

        private void resetForm()
        {
            firstNameTxtBox.Clear();
            lastNameTxtBox.Clear();
            emailAddressTxtBx.Clear();
            phoneNumberTxtBx.Clear();
            subjectTaughtTxtBox.Clear();
            firstNameTxtBox.Focus();

            if (this.IsUpdate)
            {
                this.IsUpdate = false;
                saveToolStripMenuItem.Text = "Save";
                toolStripMenuItem3.Enabled = false;
                this.FirstName = null;
            }
        }

        private bool IsFormValid()
        {
            if (firstNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the teacher's first name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTxtBox.Focus();
                return false;
            }

            if (lastNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the teacher's last name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTxtBox.Focus();
                return false;
            }

            if (emailAddressTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the teacher's email address to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailAddressTxtBx.Focus();
                return false;
            }

            if (phoneNumberTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the teacher's phone number to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phoneNumberTxtBx.Focus();
                return false;
            }

            if (subjectTaughtTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the subject being taught to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                subjectTaughtTxtBox.Focus();
                return false;
            }

            return true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                {
                    if (result == DialogResult.Yes)
                    {
                        //Delete User
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_Teachers_DeleteTeacher", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@FirstName", this.FirstName);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Teacher has been successfully deleted!", "Delete Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                resetForm();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Teacher not deleted!","Delete Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Teachers_ReloadTeacherInformationForUpdate", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", this.FirstName);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable teacher = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        teacher.Load(sdr);

                        DataRow row = teacher.Rows[0];

                        firstNameTxtBox.Text = row["FirstName"].ToString();
                        lastNameTxtBox.Text = row["LastName"].ToString();
                        emailAddressTxtBx.Text = row["Email"].ToString();
                        phoneNumberTxtBx.Text = row["PhoneNumber"].ToString();
                        subjectTaughtTxtBox.Text = row["SubjectTaught"].ToString();
                        
               
                        //Switching Save control to Update.
                        saveToolStripMenuItem.Text = "Update";
                        toolStripMenuItem3.Enabled = true;
                    }
                }
            }
        }
    }
}
