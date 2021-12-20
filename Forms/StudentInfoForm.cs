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
    public partial class StudentInfoForm : Template
    {
        public StudentInfoForm()
        {
            InitializeComponent();
            LoadMajorsCmbBox();
        }

        private void LoadMajorsCmbBox()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_DegreeType_LoadIntoComboBox", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable majors = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    majors.Load(sdr);

                    ProgramComboBox.DataSource = majors;
                    ProgramComboBox.DisplayMember = "DegreeType";
                    ProgramComboBox.ValueMember = "DegreeTypeID";
                    
                }
            }
        }

        public string FirstName { get; set; }

        public bool IsUpdate { get; set; }
        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vsf = new ViewStudentsForm();
            vsf.ShowDialog();
        }

        private void studentEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentEnrollmentForm sef = new StudentEnrollmentForm();
            sef.ShowDialog();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (this.IsUpdate == true)
                {
                    {   //Do update Process
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_Students_UpdateStudentInformation", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@OldFirstName", this.FirstName);
                                cmd.Parameters.AddWithValue("@FirstName", FirstNameTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@LastName", LastNameTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@Address", AddressTxtBx.Text.Trim());
                                cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@Email", emailTxtBx.Text.Trim());
                                cmd.Parameters.AddWithValue("EnrolledDate", enrolledDatePick.Value.ToString());
                                cmd.Parameters.AddWithValue("@BirthDate", dobDatPick.Value.ToString());
                                cmd.Parameters.AddWithValue("@Major", ProgramComboBox.Text.Trim());

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Student has been successfully updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                resetForm();
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_Students_InsertNewStudent", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@FirstName", FirstNameTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@LastName", LastNameTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Address", AddressTxtBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumberTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", emailTxtBx.Text.Trim());
                            cmd.Parameters.AddWithValue("EnrolledDate", enrolledDatePick.Value.ToString());
                            cmd.Parameters.AddWithValue("@BirthDate", dobDatPick.Value.ToString());
                            cmd.Parameters.AddWithValue("@Major", ProgramComboBox.Text.Trim());


                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Student has been successfully added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            resetForm();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void resetForm()
        {
            FirstNameTxtBox.Clear();
            LastNameTxtBox.Clear();
            AddressTxtBx.Clear();
            PhoneNumberTxtBox.Clear();
            emailTxtBx.Clear();
            
            

            if (this.IsUpdate)
            {
                this.IsUpdate = false;
                SaveBtn.Text = "Save";
                DeleteBtn.Enabled = false;
                this.FirstName = null;
            }
        }

        private bool IsFormValid()
        {
            if (FirstNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a first name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTxtBox.Focus();
                return false;
            }

            if (LastNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a last name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTxtBox.Focus();
                return false;
            }

            if (AddressTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter an address to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddressTxtBx.Focus();
                return false;
            }

            if (PhoneNumberTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a phone number to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PhoneNumberTxtBox.Focus();
                return false;
            }

            if (emailTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter an email address to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTxtBx.Focus();
                return false;
            }

            //if (DOBTxtBox.Text.Trim() == string.Empty)
            {
               // MessageBox.Show("You must enter a date of birth to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // DOBTxtBox.Focus();
                //return false;
            }

            //if (ProgramComboBox.Text.Length == -1)
            {
                //MessageBox.Show("A major must be selected to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //ProgramComboBox.Focus();
                //return false;
            }

            return true;


        }

        private void DeleteBtn_Click(object sender, EventArgs e)
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
                            using (SqlCommand cmd = new SqlCommand("usp_Students_DeleteStudentInformation", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@FirstName", this.FirstName);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Student has been successfully deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                resetForm();
                                this.Close();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Student not deleted", "Delete Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }
        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Students_ReloadStudentInformation", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", this.FirstName);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable students = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        students.Load(sdr);

                        DataRow row = students.Rows[0];

                        FirstNameTxtBox.Text = row["FirstName"].ToString();
                        LastNameTxtBox.Text = row["LastName"].ToString();
                        AddressTxtBx.Text = row["Address"].ToString();
                        PhoneNumberTxtBox.Text = row["PhoneNumber"].ToString();
                        emailTxtBx.Text = row["Email"].ToString();
                        enrolledDatePick.Value.ToString();
                        dobDatPick.Value.ToString();
                        
                        //Switching Save control to Update.
                        SaveBtn.Text = "Update";
                        DeleteBtn.Enabled = true;

                    }
                }
            }
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
