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
    public partial class ResetUserPasswordForm : Template
    {
        public ResetUserPasswordForm()
        {
            InitializeComponent();
        }

        private void ResetPasswordBtn_Click(object sender, EventArgs e)
        {
            if(IsFormValid())
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Users_ResetUserPassword", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", UserFirstNameTxtBx.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", UserLastNameTextBx.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPassword", EncryptData.DataSecure(NewUserPasswordTextBx.Text.Trim()));
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUSerInfo.firstName + LoggedInUSerInfo.lastName);

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Password has been successfully updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        resetForm();

                    }
                }
            }
        }

        private void resetForm()
        {
            UserFirstNameTxtBx.Clear();
            UserLastNameTextBx.Clear();
            NewUserPasswordTextBx.Clear();
            UserFirstNameTxtBx.Focus();
        }

        private bool IsFormValid()
        {
            if (UserFirstNameTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the first name of the user you are restting the password for.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserFirstNameTxtBx.Focus();
                return false;
            }

            if (UserLastNameTextBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the first name of the user you are restting the password for.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserLastNameTextBx.Focus();
                return false;
            }

            if (NewUserPasswordTextBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the first name of the user you are restting the password for.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NewUserPasswordTextBx.Focus();
                return false;
            }

            return true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
