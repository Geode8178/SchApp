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
                SaveButton.Text = "Save";
                DeleteButton.Enabled = false;
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

            if (RoleDescriptionTxtBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the type off access this user role has (Full/HR/Advisor/Teacher/SchoolAdministrator).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewRoleTxtBox.Focus();
                return false;
            }

            return true;
        }

     

        private void UserRolesForm_Load(object sender, EventArgs e) //Loads a new User Role form to allow updating of records.
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
                        SaveButton.Text = "Update";
                        DeleteButton.Enabled = true;
                        
                    }
                }
            }

        }

        private void UserRoleRefreshBtn_Click(object sender, EventArgs e) //Refreshes the information grid.
        {
            LoadUserRoleDataIntoUserRoleGrid();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e) //Code for close button events.
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e) //Code for save button events.
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
                                cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUSerInfo.firstName + LoggedInUSerInfo.lastName);

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
                {           //Perform INSERT procedure.
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_UserRoles_InsertRole", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@RoleTitle", NewRoleTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Description", RoleDescriptionTxtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUSerInfo.firstName + LoggedInUSerInfo.lastName);

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

        private void DeleteButton_Click(object sender, EventArgs e) //Code allowing the deletion of user roles.
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
                            using (SqlCommand cmd = new SqlCommand("usp_UserRoles_DeleteUserByRoleId", con))
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













