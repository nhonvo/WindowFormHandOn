using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winformtest.Model;

namespace winformtest
{
    public partial class frmReport : Form
    {
        StudentDBContext db = new StudentDBContext();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

            var obj = db.Students.ToList();
           
            List<studentReport> ll = new List<studentReport>();
            foreach (Student student in obj)
            {
                studentReport std = new studentReport()
                {
                    id = student.id,
                    name = student.name,
                    day = student.day,
                    ClassId = student.classId
                };
                ll.Add(std);
            }
            //this.reportViewer1.LocalReport.ReportPath = "./Form/reportStudent.rdlc";
            this.reportViewer1.LocalReport.ReportPath = "D:\\1. University\\Year_3\\Semeter_1A\\Window_Programing_Hand-on\\winformtest\\winformtest\\Form\\reportStudent.rdlc";
            var reportDataSource = new ReportDataSource("StudentDataset", ll);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
