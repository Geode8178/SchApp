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
    public partial class ViewTeachersForm : Template
    {
        public ViewTeachersForm()
        {
            InitializeComponent();
            LoadTeachersintoDataGridView();
        }

        private void LoadTeachersintoDataGridView()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Teachers_LoadTeachersForView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable teachers = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    teachers.Load(sdr);

                    TeacherSearchGridView.DataSource = teachers;
                    
                    
                }
            }
        }

        private void TeacherSearchGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TeacherSearchGridView.Rows.Count >= 0) 
            {
                string FirstName = TeacherSearchGridView.SelectedRows[0].Cells[0].Value.ToString();
                
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.FirstName = FirstName;
                teacherForm.IsUpdate = true;
                teacherForm.ShowDialog();
                LoadTeachersintoDataGridView();

            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTeachersintoDataGridView();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (TeacherSearchTxtBox.Text != string.Empty)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Teachers_SearchByTeacherName", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Must pass parameters
                        cmd.Parameters.AddWithValue("@Filter", TeacherSearchTxtBox.Text.Trim());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable teachers = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        

                        if (sdr.HasRows)
                        {
                            teachers.Load(sdr);

                            TeacherSearchGridView.DataSource = teachers;
                            
                        }
                        else
                        {
                            MessageBox.Show("The teacher does not exist.", "Teacher Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        TeacherSearchTxtBox.Clear();
                        TeacherSearchTxtBox.Focus();
                        
                    }
                }
            }
        }

        private void teacherFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.ShowDialog();

        }
    }

}



