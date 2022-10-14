using lab05_bt1.models;
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

namespace lab05_bt1
{
    public partial class formbai1 : Form
    {
        dbqldonhang context = new dbqldonhang();
        public formbai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Order> orders = context.Orders.ToList();
            this.reportViewer1.RefreshReport();
            reportViewer1.Visible = false;
            RDBbaogiasanpham.Checked = true;
            RDBphieugiaohang.Checked = false;
            cbbmahoadon.Enabled = false;
        }


        private void btnxuat_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            
            if(RDBbaogiasanpham.Checked == true)
            {
                List<Product> products = context.Products.ToList();
                this.reportViewer1.LocalReport.ReportPath = "./report/Reportbangbaogia.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource("DataSetbangbaogia", products);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            else //if (RDBphieugiaohang.Checked == true)
            {
                Invoice invoiceID = context.Invoices.FirstOrDefault(p => p.InvoiceNo == cbbmahoadon.Text);
                List<Order> listorders = context.Orders.Where(p => p.InvoiceNo == cbbmahoadon.Text).ToList();

                if (invoiceID == null || listorders.Count() == 0)
                {
                    MessageBox.Show("khong tim thay don hang nao");
                    return;
                }
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("ngaygiaohang", string.Format("Ngày " +
                invoiceID.DeliveryDate.ToString("dd/MM/yyyy")));

                param[1] = new ReportParameter("sohoadon", invoiceID.InvoiceNo);

                this.reportViewer1.LocalReport.ReportPath = "./report/Reportphieugiaohang.rdlc";
                this.reportViewer1.LocalReport.SetParameters(param);
                ReportDataSource reportDataSource = new ReportDataSource("DataSetphieugiaohang", listorders);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //this.reportViewer1.LocalReport.DisplayName = "Phieu giao hàng"; 
            }
            this.reportViewer1.RefreshReport();

        }

        private void RDBphieugiaohang_CheckedChanged(object sender, EventArgs e)
        {
            if(RDBphieugiaohang.Checked == true)
            {
                cbbmahoadon.Enabled = true;
            }
            else
            {
                cbbmahoadon.Enabled = false;
            }
        }

        private void cbbmahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
