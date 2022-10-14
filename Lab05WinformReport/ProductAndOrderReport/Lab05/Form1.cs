using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab05.models;
using Microsoft.Reporting.WinForms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        dbcontectsinhvien context = new dbcontectsinhvien();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<Student> students = context.Students.ToList(); // lay danh sach sv
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

            this.reportViewer1.LocalReport.ReportPath = "./report/ReportSinhVien.rdlc";
            var reportDataSource = new ReportDataSource("DataSetStudent", studentReports);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
