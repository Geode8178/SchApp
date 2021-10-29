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
    public partial class UserRolesForm : Template
    {
        public UserRolesForm()
        {
            InitializeComponent();
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

                    UserRoleSearchComboBox.DataSource = dtUserRoles;
                    UserRoleSearchComboBox.DisplayMember = "RoleTitle";
                    UserRoleSearchComboBox.ValueMember = "RoleID";

                }

            }
        }

        public int roleID { get; set; } //Properties for handling update process.
        public bool IsUpdate { get; set; }

        private void LoadUserRoleDataIntoUserRoleGrid()  //This function loads data from the database into the data grid for the User Roles form.
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

                    UserRoleViewGrid.DataSource = dtUserRoles;

                    // UserRoleViewGrid.Columns[0].Visible = false; *Causes the Role ID to not be visible for final program release*


                }

            }
        }

        private void UserRoleSaveBtn_Click(object sender, EventArgs e)  //Work performed when the User Roles Form save button is clicked.
        {
            if (IsFormValid())
            {
                if (this.IsUpdate)
                {
                    //Perform UPDATE procedure.
                    {
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_UserRoles_UpdateUSerRolesByRoleID", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@RoleID", this.roleID);
                                cmd.Parameters.AddWithValue("@RoleTitle", NewRoleTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@Description", RoleDescriptionTxtBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@CreatedBy", "Admin");

                                if (con.State != ConnectionState.Open)
                                    con.Open();


                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Role has been successfully updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                resetForm();
                            }
                        }
                    }
                }
                else
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_UserRoles_InsertRole", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@RoleTitle", NewRoleTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Description", RoleDescriptionTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@CreatedBy", "Admin");

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Role has been successfully saved!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            resetForm();

                        }
                    }
                }
                }
            }
        private void resetForm() //Clear the form after adding new user role information, updating user role information, or deleting user role information.
        {
            NewRoleTxtBox.Clear();
            RoleDescriptionTxtBox.Clear();
            NewRoleTxtBox.Focus();
            

            //Check if the form is loaded for processing.
            if (this.IsUpdate)
            {
                this.roleID = 0;
                this.IsUpdate = false;
                UserRoleSaveBtn.Text = "Save";
                UserRoleDeleteBtn.Enabled = false;
            }

        }

        private bool IsFormValid() //Validation for the NewRoleTextBox
        {
            if (NewRoleTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a Role Title to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewRoleTxtBox.Focus();
                return false;
            }

            if (NewRoleTxtBox.Text.Length >= 50)
            {
                MessageBox.Show("Role Title length should be 50 characters or less.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewRoleTxtBox.Focus();
                return false;
            }

            return true;
        }

        

        private void UserRoleSearchBtn_Click(object sender, EventArgs e)
        {
            if (UserRoleSearchComboBox.Text != string.Empty)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_UserRoles_UserRolesComboBoxSearch", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Must pass parameters
                        cmd.Parameters.AddWithValue("@RoleTitle", UserRoleSearchComboBox.Text.Trim());

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable dtUSerRoleComboBox = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.HasRows)
                        {
                            dtUSerRoleComboBox.Load(sdr);

                            UserRoleViewGrid.DataSource = dtUSerRoleComboBox;
                            

                        }
                        else
                        {
                            MessageBox.Show("The user role does not exist.", "No User Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

     

        private void UserRoleViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserRoleViewGrid.Rows.Count > 0)
            {
                int roleID = Convert.ToInt32(UserRoleViewGrid.SelectedRows[0].Cells[0].Value);

                UserRolesForm userRolesForm = new UserRolesForm();
                userRolesForm.roleID = roleID;
                userRolesForm.IsUpdate = true;
                userRolesForm.ShowDialog();
                

                LoadUserRoleDataIntoUserRoleGrid();

            }
        }

        private void UserRolesForm_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_UserRoles_DataReloadForUpdate", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@RoleID", roleID);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable dtrole = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        dtrole.Load(sdr);

                        DataRow row = dtrole.Rows[0];

                        NewRoleTxtBox.Text = row["RoleTitle"].ToString();
                        RoleDescriptionTxtBox.Text = row["Description"].ToString();

                        //Switching Save control to Update.
                        UserRoleSaveBtn.Text = "Update";
                        UserRoleDeleteBtn.Enabled = true;
                        
                    }
                }
            }

        }

        private void UserRoleRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadUserRoleDataIntoUserRoleGrid();
            UserRoleSearchComboBox.Focus();
        }

        private void UserRoleDeleteBtn_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this user role?", "Delete User Role Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    //Deletes the User Role from the database.
                    {
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_UserRoles_DeleteByRoleID", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@RoleID", roleID);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Role has been successfully deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                resetForm();
                            }
                        }
                    }
                }
            }
        }
    }
}













