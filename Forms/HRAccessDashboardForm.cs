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
    public partial class HRAccessDashboardForm : Template
    {
        public HRAccessDashboardForm()
        {
            InitializeComponent();
        }

        private void newTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm tcf = new TeacherForm();
            tcf.ShowDialog();
        }

        private void viewTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTeachersForm vtf = new ViewTeachersForm();
            vtf.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm tcf = new TeacherForm();
            tcf.ShowDialog();
        }

        private void viewTeachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewTeachersForm vtf = new ViewTeachersForm();
            vtf.ShowDialog();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e) //Closes the Human Resource dashboard.
        {
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e) //Exits the application.
        {
            Application.Exit();
        }

        private void NewTeachersBtn_Click(object sender, EventArgs e)
        {
            TeacherForm tcf = new TeacherForm();
            tcf.ShowDialog();
        }

        private void ViewTeachersBtn_Click(object sender, EventArgs e)
        {
            ViewTeachersForm vtf = new ViewTeachersForm();
            vtf.ShowDialog();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpf = new ChangePasswordForm();
            cpf.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
