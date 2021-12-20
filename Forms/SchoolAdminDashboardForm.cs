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
    public partial class SchoolAdminDashboardForm : Template
    {
        public SchoolAdminDashboardForm()
        {
            InitializeComponent();
        }

        private void addTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherForm tch = new TeacherForm();
            tch.ShowDialog();
        }

        private void viewTeachersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewTeachersForm vtf = new ViewTeachersForm();
            vtf.ShowDialog();
        }

        private void addCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursesForm crf = new CoursesForm();
            crf.ShowDialog();
        }

        private void viewCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCoursesForm vcf = new ViewCoursesForm();
            vcf.ShowDialog();
        }

        private void addProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramsForm pgf = new ProgramsForm();
            pgf.ShowDialog();
        }

        private void viewProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramsForm pgf = new ProgramsForm();
            pgf.ShowDialog();
        }

        private void viewTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTeachersForm vtf = new ViewTeachersForm();
            vtf.ShowDialog();
        }

        private void viewCoursesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewCoursesForm vcf = new ViewCoursesForm();
            vcf.ShowDialog();
        }

        private void viewProgramsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewProgramsForm vpf = new ViewProgramsForm();
            vpf.ShowDialog();
        }

        private void closeDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddTeachersBtn_Click(object sender, EventArgs e)
        {
            TeacherForm tch = new TeacherForm();
            tch.ShowDialog();
        }

        private void ViewTeacherBtn_Click(object sender, EventArgs e)
        {
            ViewTeachersForm vtf = new ViewTeachersForm();
            vtf.ShowDialog();
        }

        private void AddCourseBtn_Click(object sender, EventArgs e)
        {
            CoursesForm crf = new CoursesForm();
            crf.ShowDialog();
        }

        private void ViewCoursesBtn_Click(object sender, EventArgs e)
        {
            ViewCoursesForm vcf = new ViewCoursesForm();
            vcf.ShowDialog();
        }

        private void AddProgramBtn_Click(object sender, EventArgs e)
        {
            ProgramsForm prf = new ProgramsForm();
            prf.ShowDialog();
        }

        private void ViewProgramsBtn_Click(object sender, EventArgs e)
        {
            ViewProgramsForm vpf = new ViewProgramsForm();
            vpf.ShowDialog();
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

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.ShowDialog();
        }

        private void ViewStudentBtn_Click(object sender, EventArgs e)
        {
            ViewStudentsForm vsf = new ViewStudentsForm();
            vsf.ShowDialog();
        }
    }
}
