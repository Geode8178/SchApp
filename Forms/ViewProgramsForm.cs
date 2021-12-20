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
    public partial class ViewProgramsForm : Template
    {
        public ViewProgramsForm()
        {
            InitializeComponent();
            LoadProgramsIntoGridView();
        }

        private void LoadProgramsIntoGridView() //Loads scholastic program data into the data grid viewer.
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_ScholasticPrograms_uspLoadProgramsIntoGridView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable programs = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    programs.Load(sdr);

                    programDataGrid.DataSource = programs;
                }
            }
        }

        private void addProgramFormToolStripMenuItem_Click(object sender, EventArgs e) //Opens the add/delete program form.
        {
            ProgramsForm prf = new ProgramsForm();
            prf.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadProgramsIntoGridView();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (programSearchTxtBox.Text != string.Empty)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_ScholasticPrograms_SearchParameters", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Must pass parameters
                        cmd.Parameters.AddWithValue("@Filter", programSearchTxtBox.Text.Trim());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable programs = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();


                        if (sdr.HasRows)
                        {
                            programs.Load(sdr);

                            programDataGrid.DataSource = programs;

                        }
                        else
                        {
                            MessageBox.Show("The program does not exist.", "Teacher Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        programSearchTxtBox.Clear();
                        programSearchTxtBox.Focus();

                    }
                }
            }
        }

        private void ViewProgramsForm_Load(object sender, EventArgs e)
        {
            if (LoggedInUSerInfo.roleID == 25)
                addProgramFormToolStripMenuItem.Enabled = false;
        }
    }
}
