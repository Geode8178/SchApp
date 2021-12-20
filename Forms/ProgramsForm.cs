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
    public partial class ProgramsForm : Template
    {

        public ProgramsForm()
        {
            InitializeComponent();
            LoadDegreeTypeComboBox();
        }

        public string degreeType { get; set; }

        public bool IsUpdate { get; set; }

        private void LoadDegreeTypeComboBox()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Programs_LoadDegreeTypes", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable degreeTypes = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    degreeTypes.Load(sdr);

                    degreeTypeCmbBx.DataSource = degreeTypes;
                    degreeTypeCmbBx.DisplayMember = "DegreeType";
                    degreeTypeCmbBx.ValueMember = "DegreeTypeID";
                }
            }
        }

        private void viewProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProgramsForm vpf = new ViewProgramsForm();
            vpf.ShowDialog();
        }

        private void saveProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
                if (this.IsUpdate == true)
                {
                    {   //Do update Process
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_ScholasticPrograms_UpdateProgramInformation", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@DegreeType", degreeTypeCmbBx.Text.Trim());
                                cmd.Parameters.AddWithValue("@ProgramType", programTypeTxtBx.Text.Trim());
                                cmd.Parameters.AddWithValue("@ProgramName", programNameTxtBx.Text.Trim());

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Program has been successfully updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    using (SqlCommand cmd = new SqlCommand("usp_ScholasticPrograms_InsertNewPrograms", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DegreeType", degreeTypeCmbBx.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProgramType", programTypeTxtBx.Text.Trim());
                        cmd.Parameters.AddWithValue("@ProgramName", programNameTxtBx.Text.Trim());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Program has been successfully added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resetForm();
                    }
                }
            }
        }

        private bool IsFormValid()
        {
            if (degreeTypeCmbBx.Text.Length == -1)
            {
                MessageBox.Show("A user role must be selected to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                degreeTypeCmbBx.Focus();
                return false;
            }

            if (programTypeTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter the type of program to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                programTypeTxtBx.Focus();
                return false;
            }

            if (programNameTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must the program name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                programNameTxtBx.Focus();
                return false;
            }

            return true;
        }

        private void resetForm()
        {
            degreeTypeCmbBx.SelectedIndex = 0;
            programTypeTxtBx.Clear();
            programNameTxtBx.Clear();
            degreeTypeCmbBx.Focus();

            if (this.IsUpdate)
            {
                this.IsUpdate = false;
                saveProgramToolStripMenuItem.Text = "Save";
                this.degreeType = null;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
