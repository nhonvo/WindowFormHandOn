using Lab05.models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05.Forms
{
    public partial class frmReport : Form
    {
        StudentManagentDBContext db = new StudentManagentDBContext();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            List<Student> students = db.Students.ToList(); // lay danh sach sv
            List<StudentReport> studentReports = new List<StudentReport>(); // tao danh sach rong



            foreach (var item in students)
            {
                StudentReport studentReport = new StudentReport();
                studentReport.StudentID = item.StudentID;
                studentReport.Fullname = item.Fullname;
                studentReport.AverageScore = Convert.ToDouble(item.AverageScore);
                studentReport.Faculty = Convert.ToString(item.Faculty.FacultyName);

                studentReports.Add(studentReport);

            }

            this.reportViewer1.LocalReport.ReportPath = "D:\\1. University\\Year_3\\Semeter_1A\\Window_Programing_Hand-on\\Lab05_byself\\Lab05\\Lab05\\Report\\studentReport.rdlc";
            var reportDataSource = new ReportDataSource("StudentDataset", studentReports);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
