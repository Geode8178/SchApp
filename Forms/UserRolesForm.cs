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

        private void UserRoleSaveBtn_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
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

        private void resetForm()
        {
            NewRoleTxtBox.Clear();
            RoleDescriptionTxtBox.Clear();
            NewRoleTxtBox.Focus();
        }

        private bool IsFormValid()
        {
            if(NewRoleTxtBox.Text.Trim() == string.Empty)
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

        private void UserRoleDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you certain you want to delete this user role?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

           
        }
    }
}