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
    public partial class AcademicAdvisorDashboardForm : Template
    {
        public AcademicAdvisorDashboardForm()
        {
            InitializeComponent();
        }

        private void ViewCoursesBtn_Click(object sender, EventArgs e)
        {
            ViewCoursesForm vcf = new ViewCoursesForm();
            vcf.ShowDialog();
        }

        private void ViewStudentBtn_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vsf = new ViewStudentsForm();
            vsf.ShowDialog();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.ShowDialog();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.ShowDialog();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vsf = new ViewStudentsForm();
            vsf.ShowDialog();
        }

        private void viewProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewProgramsForm vpf = new ViewProgramsForm();
            vpf.ShowDialog();
        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCoursesForm vcf = new ViewCoursesForm();
            vcf.ShowDialog();
        }

        private void studentEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentEnrollmentForm sef = new StudentEnrollmentForm();
            sef.ShowDialog();
        }

        private void viewStudentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vsf = new ViewStudentsForm();
            vsf.ShowDialog();
        }

        private void viewProgramsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProgramsForm vpf = new ViewProgramsForm();
            vpf.ShowDialog();
        }

        private void viewCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCoursesForm vcf = new ViewCoursesForm();
            vcf.ShowDialog();
        }

        private void studentEnrollmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentEnrollmentForm sef = new StudentEnrollmentForm();
            sef.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewProgramsBtn_Click(object sender, EventArgs e)
        {
            ViewProgramsForm vpf = new ViewProgramsForm();
            vpf.ShowDialog();
        }

        private void studentEnrollBtn_Click(object sender, EventArgs e)
        {
            StudentEnrollmentForm sef = new StudentEnrollmentForm();
            sef.ShowDialog();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordForm cpf = new ChangePasswordForm();
            cpf.ShowDialog();
        }

        private void CloseDashboardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
