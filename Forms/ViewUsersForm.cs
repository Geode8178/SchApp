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
    public partial class ViewUsersForm : Template
    {
        public ViewUsersForm()
        {
            InitializeComponent();
            LoadUserRoleDataIntoUserRoleGrid();
        }

        private void LoadUserRoleDataIntoUserRoleGrid()
        {
            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_UserSearchDataGridView", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    DataTable dtUserRoles = new DataTable();

                    SqlDataReader sdr = cmd.ExecuteReader();

                    dtUserRoles.Load(sdr);

                    UserSearchGridView.DataSource = dtUserRoles;

                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            LoadUserRoleDataIntoUserRoleGrid();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (UserSearchTxtBx.Text != string.Empty)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Users_SearchByRoleOrUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Must pass parameters
                        cmd.Parameters.AddWithValue("@Filter", UserSearchTxtBx.Text.Trim());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable users = new DataTable();
                        
                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.HasRows)
                        {
                            users.Load(sdr);

                            UserSearchGridView.DataSource = users;
                        }
                        else
                        {
                            MessageBox.Show("The user or role does not exist.", "No Role Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        UserSearchTxtBx.Focus();
                    }
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserRoleDataIntoUserRoleGrid();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserSearchGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                if (UserSearchGridView.Rows.Count >= 0)
                {
                string FirstName = UserSearchGridView.SelectedRows[0].Cells[0].Value.ToString();

                UserForm userForm = new UserForm();
                userForm.FirstName = FirstName;
                userForm.IsUpdate = true;
                userForm.ShowDialog();
                LoadUserRoleDataIntoUserRoleGrid();
                
                }
            }
        }
    }

