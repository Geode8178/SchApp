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
    public partial class UserLoginForm : Template
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e) //Exits the application.
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e) //Logs the user in after performing user authentication.
        {
            if (IsFormValid())
            {
                using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_Users_AuthenticationValidation", con)) 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", UserNameTxtBx.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", LastNameTxtBx.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", EncryptData.DataSecure(PasswordTxtBx.Text.Trim()));

                        if (con.State != ConnectionState.Open)
                            con.Open();
                        DataTable dtUser= new DataTable();

                        SqlDataReader sdr = cmd.ExecuteReader();

                        if (sdr.HasRows)
                        {
                            dtUser.Load(sdr);
                            DataRow userRow = dtUser.Rows[0];
                            LoggedInUSerInfo.firstName = userRow["FirstName"].ToString();
                            LoggedInUSerInfo.lastName = userRow["LastName"].ToString();
                            LoggedInUSerInfo.roleID = Convert.ToInt32(userRow["RoleID"]);

                            this.Hide();
                            SchAppDashboardForm dashboardForm = new SchAppDashboardForm();
                            dashboardForm.Show();

                        }
                        else
                        {
                            MessageBox.Show("First Name, Last Name, or Password is not correct!", "Authentication Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                    }
                }
            }
        }

        private bool IsFormValid() //Form validation.
        {
            if (UserNameTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter your first name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTxtBx.Focus();
                return false;
            }

            if (LastNameTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter your last name to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTxtBx.Focus();
                return false;
            }

            if (PasswordTxtBx.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You must enter a password to continue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTxtBx.Focus();
                return false;
            }
            return true;
        }
    }
}
