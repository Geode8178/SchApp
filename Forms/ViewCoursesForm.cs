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
    public partial class ViewCoursesForm : Template
    {
        public ViewCoursesForm()
        {
            InitializeComponent();
            LoadCoursesIntoDataGrid();
        }

        private void LoadCoursesIntoDataGrid()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Courses_LoadCourseInformationForView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable courses = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    courses.Load(sdr);

                    coursedataGridView.DataSource = courses;
                }
            }
        }

        private void courseFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesForm courses = new CoursesForm();
            courses.ShowDialog();

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCoursesIntoDataGrid();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (searchCourseTxtBox.Text != string.Empty)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_SearchByCourseNameSectionNumber", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Must pass parameters
                        cmd.Parameters.AddWithValue("@Filter", searchCourseTxtBox.Text.Trim());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable courses = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();


                        if (sdr.HasRows)
                        {
                            courses.Load(sdr);

                            coursedataGridView.DataSource = courses;

                        }
                        else
                        {
                            MessageBox.Show("The course does not exist.", "Course Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        searchCourseTxtBox.Clear();
                        searchCourseTxtBox.Focus();

                    }
                }
            }
        }

        private void coursedataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LoggedInUSerInfo.roleID == 30)
            {
                if (coursedataGridView.Rows.Count >= 0)
                {
                    string CourseName = coursedataGridView.SelectedRows[0].Cells[0].Value.ToString();

                    CoursesForm courseform = new CoursesForm();

                    courseform.CourseName = CourseName;
                    courseform.IsUpdate = true;
                    courseform.ShowDialog();
                    LoadCoursesIntoDataGrid();

                }
            }
 
                
        }

        private void ViewCoursesForm_Load(object sender, EventArgs e)
        {
            if (LoggedInUSerInfo.roleID == 25)
                courseFormToolStripMenuItem.Enabled = false;
        }
    }
}
