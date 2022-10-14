using Finaltest.Model;
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

namespace Finaltest
{
    public partial class XNReport : Form
    {
        XetNghiemDBContext db = new XetNghiemDBContext();
        public XNReport()
        {
            InitializeComponent();
        }
        public void ReloadCBB()
        {
            var lst = db.CONGTies.ToList();

            this.cbbCompany.DataSource = lst;
            this.cbbCompany.DisplayMember = "TenCty";
            this.cbbCompany.ValueMember = "MaCty";
        }
        private void Report_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> students = db.NHANVIENs.ToList(); // lay danh sach sv
            List<Model.XNReport> studentReports = new List<Model.XNReport>(); // tao danh sach rong
            ReloadCBB();


            foreach (var item in students)
            {
                Model.XNReport rp = new Model.XNReport();
                rp.ID = item.ID;
                rp.HoTen = item.HoTen;
                rp.AmTinh = item.AmTinh;

                studentReports.Add(rp);

            }

            this.reportViewer1.LocalReport.ReportPath = "D:\\1. University\\Year_3\\Semeter_1A\\Window_Programing_Hand-on\\Finaltest\\Finaltest\\Report\\XetNghiem.rdlc";
            var reportDataSource = new ReportDataSource("XetNghiemDataset", studentReports);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //List<NHANVIEN> students = db.NHANVIENs.Where(x=>x.CONGTY.TenCty.Contains(cbbCompany.SelectedValue.ToString())).ToList(); // lay danh sach sv
            List<NHANVIEN> students = db.NHANVIENs.Where(x=>x.MaCty == cbbCompany.SelectedValue).ToList(); // lay danh sach sv
            List<Model.XNReport> studentReports = new List<Model.XNReport>(); // tao danh sach rong


            foreach (var item in students)
            {
                Model.XNReport rp = new Model.XNReport();
                rp.ID = item.ID;
                rp.HoTen = item.HoTen;
                rp.AmTinh = item.AmTinh;
                studentReports.Add(rp);
            }
            this.reportViewer1.LocalReport.ReportPath = "D:\\1. University\\Year_3\\Semeter_1A\\Window_Programing_Hand-on\\Finaltest\\Finaltest\\Report\\XetNghiem.rdlc";
            var reportDataSource = new ReportDataSource("XetNghiemDataset", studentReports);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
