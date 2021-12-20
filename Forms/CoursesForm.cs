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
    public partial class CoursesForm : Template
    {
        public CoursesForm()
        {
            InitializeComponent();
        }

        public string CourseName { get; set; }

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
                            using (SqlCommand cmd = new SqlCommand("usp_Courses_UpdateCourseInformation", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@OldCourseName", this.CourseName);
                                cmd.Parameters.AddWithValue("@CourseName", courseNameTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@CourseDescription", courseDescriptionTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@CourseSection", courseSectionTxtBox.Text.Trim());

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("This course has been successfully updated!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        using (SqlCommand cmd = new SqlCommand("usp_Courses_InsertNewCourses", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@CourseName", courseNameTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@CourseDescription", courseDescriptionTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@CourseSection", courseSectionTxtBox.Text.Trim());


                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Course has been successfully saved!", "Course Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            resetForm();
                            this.Close();
                        }
                    }
                }
            }
        }

        private bool IsFormValid()
        {
            if (courseNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the course name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                courseNameTxtBox.Focus();
                return false;
            }

            if (courseDescriptionTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the course description to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                courseDescriptionTxtBox.Focus();
                return false;
            }
            if (courseSectionTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the course number to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                courseSectionTxtBox.Focus();
                return false;
            }

            return true;
        }

        private void resetForm()
        {
            courseNameTxtBox.Clear();
            courseDescriptionTxtBox.Clear();
            courseSectionTxtBox.Clear();

            if (IsUpdate)
            {
                if (this.IsUpdate)
                {
                    this.IsUpdate = false;
                    saveToolStripMenuItem.Text = "Save";
                    deleteToolStripMenuItem.Enabled = false;
                    this.CourseName = null;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Courses_ReloadCourseInformationForUpdate", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CourseName", this.CourseName);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable teacher = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        teacher.Load(sdr);

                        DataRow row = teacher.Rows[0];

                        courseNameTxtBox.Text = row["CourseName"].ToString();
                        courseDescriptionTxtBox.Text = row["CourseDescription"].ToString();
                        courseSectionTxtBox.Text = row["CourseSection"].ToString();
                        
                        //Switching Save control to Update.
                        saveToolStripMenuItem.Text = "Update";
                        deleteToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete this course?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                {
                    if (result == DialogResult.Yes)
                    {
                        //Delete User
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_Courses_DeleteCourse", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@CourseName", this.CourseName);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Course has been successfully deleted!", "Delete Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                resetForm();
                                this.Close();
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Course not deleted!", "Delete Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
        }
    }
}
