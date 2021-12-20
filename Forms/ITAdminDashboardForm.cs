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
    public partial class ITAdminDashboardForm : Template
    {
        public ITAdminDashboardForm()
        {
            InitializeComponent();
        }

        private void loadUserRoleFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRolesForm urf = new UserRolesForm();
            urf.ShowDialog();

        }

        private void viewUserRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRoleSearchForm vurf = new UserRoleSearchForm();
            vurf.ShowDialog();
        }

        private void loadUserFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUsersForm vuf = new ViewUsersForm();
            vuf.ShowDialog();
        }

        private void resetUserPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetUserPasswordForm rup = new ResetUserPasswordForm();
            rup.ShowDialog();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangePasswordForm chPassword = new ChangePasswordForm();
            chPassword.ShowDialog();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadUserRoleFormBtn_Click(object sender, EventArgs e)
        {
            UserRolesForm urf = new UserRolesForm();
            urf.ShowDialog();
        }

        private void ViewUserRoleBtn_Click(object sender, EventArgs e)
        {
            UserRoleSearchForm vurf = new UserRoleSearchForm();
            vurf.ShowDialog();
        }

        private void LoadUserFormBtn_Click(object sender, EventArgs e)
        {
            UserForm uf = new UserForm();
            uf.ShowDialog();
        }

        private void ViewUserSearchBtn_Click(object sender, EventArgs e)
        {
            ViewUsersForm vuf = new ViewUsersForm();
            vuf.ShowDialog();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm chPassword = new ChangePasswordForm();
            chPassword.ShowDialog();
        }

        private void ResetUserPasswordBtn_Click(object sender, EventArgs e)
        {
            ResetUserPasswordForm rup = new ResetUserPasswordForm();
            rup.ShowDialog();
        }
    }
}
