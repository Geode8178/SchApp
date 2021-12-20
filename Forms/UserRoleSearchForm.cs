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
    public partial class UserRoleSearchForm : Template
    {
        public UserRoleSearchForm()
        {
            InitializeComponent();
            LoadUserRoleDataIntoUserRoleGrid();
            LoadUserRolesIntoUserRolesComboBox();
        }

        private void LoadUserRolesIntoUserRolesComboBox()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Users_LoadUserRolesIntoUserRoleComboBox", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable dtUserRoles = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    dtUserRoles.Load(sdr);

                    UserRolesSearchComboBox.DataSource = dtUserRoles;
                    UserRolesSearchComboBox.DisplayMember = "RoleTitle";
                    UserRolesSearchComboBox.ValueMember = "RoleID";

                }
            }
        }

        private void LoadUserRoleDataIntoUserRoleGrid()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UserRoles_ShowUserRolesInUserRolesDataGrid", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable dtUserRoles = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    dtUserRoles.Load(sdr);

                    SearchRolesDataGridView.DataSource = dtUserRoles;

                    SearchRolesDataGridView.Columns[0].Visible = false; //May need to show if working on program. Add // to the beginning of the line and make it a comment to show Role IDs.


                }

            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (UserRolesSearchComboBox.Text != string.Empty)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_UserRoles_UserRolesComboBoxSearch", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Must pass parameters
                        cmd.Parameters.AddWithValue("@RoleTitle", UserRolesSearchComboBox.Text.Trim());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable dtUSerRoleComboBox = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.HasRows)
                        {
                            dtUSerRoleComboBox.Load(sdr);

                            SearchRolesDataGridView.DataSource = dtUSerRoleComboBox;
                        }
                        else
                        {
                            MessageBox.Show("The user role does not exist.", "No Role Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        UserRolesSearchComboBox.Focus();
                    }
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            
                LoadUserRoleDataIntoUserRoleGrid();
                SearchRolesDataGridView.Focus();
            
        }

        private void addUserRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRolesForm urf = new UserRolesForm();
            urf.ShowDialog();
            LoadUserRoleDataIntoUserRoleGrid();
        }

        private void SearchRolesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SearchRolesDataGridView.Rows.Count > 0)
            {
                int roleID = Convert.ToInt32(SearchRolesDataGridView.SelectedRows[0].Cells[0].Value);

                UserRolesForm userRolesForm = new UserRolesForm();
                userRolesForm.roleID = roleID;
                userRolesForm.IsUpdate = true;
                userRolesForm.ShowDialog();


                LoadUserRoleDataIntoUserRoleGrid();

            }
        }
    }
}
