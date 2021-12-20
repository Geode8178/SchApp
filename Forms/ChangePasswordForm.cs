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
    public partial class ChangePasswordForm : Template
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void SavePassWrdBtn_Click(object sender, EventArgs e)
        {
            if(IsFormValid())
            {
                //Update user password.
                if(IsPasswordVerified())
                {
                    {
                        using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                        {
                            using (SqlCommand cmd = new SqlCommand("usp_Users_ChangePassword", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.Parameters.AddWithValue("@FirstName", LoggedInUSerInfo.firstName);
                                cmd.Parameters.AddWithValue("@NewPassword", EncryptData.DataSecure(NewPassTxtBx.Text.Trim()));
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
            }
           
        }

        private void resetForm()
        {
            OldPassTxtBx.Clear();
            NewPassTxtBx.Clear();
            ConfirmPassTxtBx.Clear();
            OldPassTxtBx.Focus();
        }

        private bool IsPasswordVerified()
        {
            bool IsCorrect = false;

            using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Users_PasswordVerification", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Password", EncryptData.DataSecure(OldPassTxtBx.Text.Trim()));
                    cmd.Parameters.AddWithValue("@FirstName", LoggedInUSerInfo.firstName);

                    if (con.State != ConnectionState.Open)
                        con.Open();
                    

                    SqlDataReader sdr = cmd.ExecuteReader();

                    if (sdr.HasRows)
                    {
                        IsCorrect = true;
                    }
                    else
                    {
                        MessageBox.Show("The old password you entered is not correct. Please enter correct password to continue", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            return IsCorrect;
        }

        private bool IsFormValid()
        {
            {
                if (OldPassTxtBx.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter your old password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OldPassTxtBx.Focus();
                    return false;
                }

                if (NewPassTxtBx.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter your new password..", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NewPassTxtBx.Focus();
                    return false;
                }

                if (ConfirmPassTxtBx.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please re-enter your new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConfirmPassTxtBx.Focus();
                    return false;
                }

                  if (NewPassTxtBx.Text.Trim() != ConfirmPassTxtBx.Text.Trim() )
                {
                    MessageBox.Show("The new and confirm password are not matching.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConfirmPassTxtBx.Focus();
                    return false;
                }
                return true;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
