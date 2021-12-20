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
    public partial class StudentEnrollmentForm : Template
    {
        public StudentEnrollmentForm()
        {
            InitializeComponent();
            LoadCoursesCourseComboBox1();
            LoadCoursesCourseComboBox2();
            LoadCoursesCourseComboBox3();
        }

        private void LoadCoursesCourseComboBox3()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_RegisteredStudents_LoadCoursesIntoComboBox", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable courses = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    courses.Load(sdr);

                    courseBox3.DataSource = courses;
                    courseBox3.DisplayMember = "CourseName";

                }
            }
        }

        private void LoadCoursesCourseComboBox2()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_RegisteredStudents_LoadCoursesIntoComboBox", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable courses = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    courses.Load(sdr);

                    courseBox2.DataSource = courses;
                    courseBox2.DisplayMember = "CourseName";

                }
            }
        }

        private void LoadCoursesCourseComboBox1()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_RegisteredStudents_LoadCoursesIntoComboBox", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable courses = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    courses.Load(sdr);

                    courseBox1.DataSource = courses;
                    courseBox1.DisplayMember = "CourseName";
                    
                }
            }
        }

        public string FirstName { get; set; }

        public bool IsRegistration { get; set; }

        public string CourseName { get; set; }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_RegisteredStudents_RegisterStudents", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", firstNameTxtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", lastNameTxtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@CourseNameOne", courseBox1.Text);
                        cmd.Parameters.AddWithValue("@CourseNameTwo", courseBox2.Text);
                        cmd.Parameters.AddWithValue("@CourseNameThree", courseBox3.Text);
                        cmd.Parameters.AddWithValue("@RegistrationDate", registrationDatePicker.Value.ToString());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Student has been successfully registered!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resetForm();
                        this.Close();

                    }
                }
            }
        }

        private void resetForm()
        {
            firstNameTxtBox.Clear();
            lastNameTxtBox.Clear();
            courseBox1.SelectedIndex = 0;
            courseBox2.SelectedIndex = 0;
            courseBox3.SelectedIndex = 0;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_RegisteredStudents_RegisterStudents", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", firstNameTxtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", lastNameTxtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@CourseNameOne", courseBox1.Text);
                        cmd.Parameters.AddWithValue("@CourseNameTwo", courseBox2.Text);
                        cmd.Parameters.AddWithValue("@CourseNameThree", courseBox3.Text);
                        cmd.Parameters.AddWithValue("@RegistrationDate", registrationDatePicker.Value.ToString());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Student has been successfully registered!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resetForm();
                        this.Close();

                    }
                }
            }
        }

        private bool IsFormValid()
        {
            if (firstNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a first name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTxtBox.Focus();
                return false;
            }

            if (lastNameTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a last name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTxtBox.Focus();
                return false;
            }

            if (courseBox2.Text == courseBox1.Text)
            {
                MessageBox.Show("You cannot register a student in the same course twice. Please select a new course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                courseBox2.Focus();
                return false;
            }

            if (courseBox3.Text == courseBox1.Text)
            {
                MessageBox.Show("You cannot register a student in the same course twice. Please select a new course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                courseBox3.Focus();
                return false;
            }

            if (courseBox2.Text == courseBox3.Text)
            {
                MessageBox.Show("You cannot register a student in the same course twice. Please select a new course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                courseBox2.Focus();
                return false;
            }

            if (courseBox3.Text == courseBox2.Text)
            {
                MessageBox.Show("You cannot register a student in the same course twice. Please select a new course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                courseBox3.Focus();
                return false;
            }

            return true;
        }


        private void StudentEnrollmentForm_Load(object sender, EventArgs e)
        {
            if (this.IsRegistration == true)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_RegisteredStudents_ReloadStudentInformation", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", this.FirstName);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable students = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        students.Load(sdr);

                        DataRow row = students.Rows[0];

                        firstNameTxtBox.Text = row["FirstName"].ToString();
                        lastNameTxtBox.Text = row["LastName"].ToString();


                    }
                }
            }
        }

        private void findStudent_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vsf = new ViewStudentsForm();
                vsf.ShowDialog();
        }
    }

     
    }
