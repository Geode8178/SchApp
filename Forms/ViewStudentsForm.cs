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
    public partial class ViewStudentsForm : Template
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
            LoadStudentsIntoDataGrid();
        }

        private void LoadStudentsIntoDataGrid()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Students_LoadStudentInfoView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable teachers = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    teachers.Load(sdr);

                    StudentGridView.DataSource = teachers;
                }
            }
        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.ShowDialog();
        }

        private void addStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (studentSearchTxtBox.Text != string.Empty)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Students_SearchByStudentFirstOrLastName", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Must pass parameters
                        cmd.Parameters.AddWithValue("@Filter", studentSearchTxtBox.Text.Trim());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable students = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();


                        if (sdr.HasRows)
                        {
                            students.Load(sdr);

                            StudentGridView.DataSource = students;

                        }
                        else
                        {
                            MessageBox.Show("The student does not exist.", "Teacher Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        studentSearchTxtBox.Clear();
                        studentSearchTxtBox.Focus();

                    }
                }
            }
        }

        private void StudentGradeReport_Click(object sender, EventArgs e)
        {
           
        }

        private void studentGradeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StudentGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             DialogResult result =  MessageBox.Show("Are you registering this student to classes?", "Registration?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (StudentGridView.Rows.Count >= 0)
                {
                    string FirstName = StudentGridView.SelectedRows[0].Cells[0].Value.ToString();

                    StudentEnrollmentForm student = new StudentEnrollmentForm();
                    student.FirstName = FirstName;
                    student.IsRegistration = true;
                    student.ShowDialog();
                    LoadStudentsIntoDataGrid();
                }
            }

            if (result == DialogResult.No)
            {
                if (StudentGridView.Rows.Count >= 0)
                {
                    string FirstName = StudentGridView.SelectedRows[0].Cells[0].Value.ToString();

                    StudentInfoForm students = new StudentInfoForm();
                    students.FirstName = FirstName;
                    students.IsUpdate = true;
                    students.ShowDialog();
                    LoadStudentsIntoDataGrid();
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadStudentsIntoDataGrid();
        }
    }
}
