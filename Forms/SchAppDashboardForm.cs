using SchApp.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchApp.Forms
{
    public partial class SchAppDashboardForm : Template
    {
        public SchAppDashboardForm()
        {
            InitializeComponent();
        }

        private void AdminAccessBtn_Click(object sender, EventArgs e) //User Role Access Security allows only an IT Administrator 
        {                                                             //or Academic Advisor access to this dashboard.
            if (LoggedInUSerInfo.roleID == 12)
            {
                SchoolAdminDashboardForm sad = new SchoolAdminDashboardForm();
                sad.ShowDialog();
            }

            if (LoggedInUSerInfo.roleID == 30)
            {
                SchoolAdminDashboardForm sad = new SchoolAdminDashboardForm();
                sad.ShowDialog();
            }  
        }

        private void HRAccessBtn_Click(object sender, EventArgs e) //User Role Security allows only IT Administrators and 
        {                                                          //Human Resource personnel access to this dashboard.
            if (LoggedInUSerInfo.roleID == 12)
            {
                HRAccessDashboardForm had = new HRAccessDashboardForm();
                had.ShowDialog();
            }
            

            if (LoggedInUSerInfo.roleID == 13)
            {
                HRAccessDashboardForm had = new HRAccessDashboardForm();
                had.ShowDialog();
            }
        }

        private void TeacherAccessBtn_Click(object sender, EventArgs e) //User Role Security allows only IT Administrators 
        {                                                               //and Teachers access to this dashboard.
            if (LoggedInUSerInfo.roleID == 12)
            {
                TeacherDashboardForm tdf = new TeacherDashboardForm();
                tdf.ShowDialog();
            }

            if (LoggedInUSerInfo.roleID == 19)
            {
                TeacherDashboardForm tdf = new TeacherDashboardForm();
                tdf.ShowDialog();
            }
        }

        private void AcademicAdvAccessBtn_Click(object sender, EventArgs e) //User Role Security allows only IT Administrators, Academic Advisors
        {                                                                   //and School Administrators access to this dashboard.
            if (LoggedInUSerInfo.roleID == 12)
            {
                AcademicAdvisorDashboardForm aaf = new AcademicAdvisorDashboardForm();
                aaf.ShowDialog();
            }

            if (LoggedInUSerInfo.roleID == 25)
            {
                AcademicAdvisorDashboardForm aaf = new AcademicAdvisorDashboardForm();
                aaf.ShowDialog();
            }

            
        }

        private void ITAdminAccessBtn_Click(object sender, EventArgs e) //User Role Security allows only IT Administrators
        {                                                               //access to this dashboard.
            if (LoggedInUSerInfo.roleID == 12)
            {
                ITAdminDashboardForm ITaf = new ITAdminDashboardForm();
                ITaf.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e) //Exits the application.
        {
            Application.Exit(); 
        }

        private void SchAppDashboardForm_Load(object sender, EventArgs e) //Loads user first name, last name,
        {                                                                 //date, and time onto the main dashboard.            
            FirstNameLbl.Text = LoggedInUSerInfo.firstName;
            LastNameLbl.Text = LoggedInUSerInfo.lastName;
            TimeDateLbl.Text = DateTime.Now.ToLongDateString();
            Time2Lbl.Text = DateTime.Now.ToLongTimeString();
            UserAccessSetUp();
        }

        private void UserAccessSetUp() //Defines User Role Access.
        {
            switch(LoggedInUSerInfo.roleID)
            {
                case 12:
                    UserRoleLbl.Text = "IT Administrator";
                    ITAdminAccessBtn.Visible = true;
                    break;

                case 13:
                    UserRoleLbl.Text = "Human Resources";
                    ITAdminAccessBtn.Visible = false;
                    break;

                case 30:
                    UserRoleLbl.Text = "School Administrator";
                    ITAdminAccessBtn.Visible = false;
                    break;

                case 25:
                    UserRoleLbl.Text = "Academic Advisor";
                    ITAdminAccessBtn.Visible = false;
                    break;

                case 19:
                    UserRoleLbl.Text = "Teacher";
                    ITAdminAccessBtn.Visible = false;
                    break;
            }
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e) //Opens the change password form
        {                                                                //for the current user.
            ChangePasswordForm chPassword = new ChangePasswordForm();
            chPassword.ShowDialog();
        }
    }
}
