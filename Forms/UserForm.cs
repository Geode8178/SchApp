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
    public partial class UserForm : Template
    {
        public object SecureData { get; private set; }

        public UserForm()
        {
            InitializeComponent();
            LoadUserRolesIntoUserRolesComboBox();
        }

        //Properties for handling the update and delete operations for users.
        public string FirstName { get; set; }
        public bool IsUpdate { get; set; }

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

                    UserRoleComboBox.DataSource = dtUserRoles;
                    UserRoleComboBox.DisplayMember = "RoleTitle";
                    UserRoleComboBox.ValueMember = "RoleID";
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (this.IsUpdate == true)
                {
                    {   //Do update Process
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_Users_UpdateUserInformation", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@OldFirstName", this.FirstName);
                                cmd.Parameters.AddWithValue("@FirstName", FirstNameTxtBx.Text.Trim());
                                cmd.Parameters.AddWithValue("@LastName", LastNameTxtBx.Text.Trim());
                                cmd.Parameters.AddWithValue("@Password", EncryptData.DataSecure(PasswordTxtBx.Text.Trim()));
                                cmd.Parameters.AddWithValue("@RoleID", UserRoleComboBox.SelectedValue);
                                cmd.Parameters.AddWithValue("@IsActive", IsActiveCheckBx.Checked);
                                cmd.Parameters.AddWithValue("@Description", DescriptionTextBx.Text.Trim());
                                cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUSerInfo.firstName + LoggedInUSerInfo.lastName);

                                if (con.State != ConnectionState.Open)
                                    con.Open();

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("User has been successfully updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                resetForm();
                                this.Close();
                            }
                        }
                    }
                }
                else 
                {   //Do Insert Process
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("usp_Users_InsertNewUSer", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@FirstName", FirstNameTxtBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@LastName", LastNameTxtBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password", EncryptData.DataSecure(PasswordTxtBx.Text.Trim()));
                            cmd.Parameters.AddWithValue("@RoleID", UserRoleComboBox.SelectedValue);
                            cmd.Parameters.AddWithValue("@IsActive", IsActiveCheckBx.Checked);
                            cmd.Parameters.AddWithValue("@Description", DescriptionTextBx.Text.Trim());
                            cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUSerInfo.firstName + LoggedInUSerInfo.lastName);

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("User has been successfully added!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            resetForm();
                        }
                    }
                }
            }
        }

        private bool IsFormValid()
        {
            if (FirstNameTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a first name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTxtBx.Focus();
                return false;
            }

             if (FirstNameTxtBx.Text.Length >= 50)
            {
                MessageBox.Show("First name length should be 50 characters or less.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FirstNameTxtBx.Focus();
                return false;
            }

             if (LastNameTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a last name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTxtBx.Focus();
                return false;
            }

             if (LastNameTxtBx.Text.Length >= 50)
            {
                MessageBox.Show("Last name length should be 50 characters or less.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastNameTxtBx.Focus();
                return false;
            }

             if (PasswordTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a user password to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTxtBx.Focus();
                return false;
            }

             if (PasswordTxtBx.Text.Length >= 50)
            {
                MessageBox.Show("Password length should be 50 characters or less.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTxtBx.Focus();
                return false;
            }

            if (UserRoleComboBox.Text.Length == -1)
            {
                MessageBox.Show("A user role must be selected to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTxtBx.Focus();
                return false;
            }

            return true;
        }

        private void resetForm()
        {
            FirstNameTxtBx.Clear();
            LastNameTxtBx.Clear();
            PasswordTxtBx.Clear();
            UserRoleComboBox.SelectedIndex = 0;
            IsActiveCheckBx.Checked = true;
            DescriptionTextBx.Clear();
            FirstNameTxtBx.Focus();

            if (this.IsUpdate)
            {
                this.IsUpdate = false;
                saveToolStripMenuItem.Text = "Save";
                deleteToolStripMenuItem.Enabled = false;
                this.FirstName = null;
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                {
                    if (result == DialogResult.Yes)
                    {
                        //Delete User
                            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                            {
                                using (SqlCommand cmd = new SqlCommand("usp_Users_DeleteUsers", con))
                                {
                                    cmd.CommandType = CommandType.StoredProcedure;

                                    cmd.Parameters.AddWithValue("@FirstName", this.FirstName);

                                    if (con.State != ConnectionState.Open)
                                        con.Open();

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("User has been successfully deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    resetForm();
                                }
                            }
                        
                    }
                    else
                    {
                        MessageBox.Show("User not deleted", "Delete Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (this.IsUpdate == true)
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Users_UserInformationReloadForUpdate", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", this.FirstName);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        DataTable dtUser = new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        dtUser.Load(sdr);

                        DataRow row = dtUser.Rows[0];

                        FirstNameTxtBx.Text = row["FirstName"].ToString();
                        LastNameTxtBx.Text = row["LastName"].ToString();
                        UserRoleComboBox.SelectedValue = row["RoleID"];
                        IsActiveCheckBx.Checked = Convert.ToBoolean(row["IsActive"]);
                        DescriptionTextBx.Text = row["Description"].ToString();

                        //Switching Save control to Update.
                        saveToolStripMenuItem.Text = "Update";
                        deleteToolStripMenuItem.Enabled = true;

                    }
                }
            }
        }
    }
}
