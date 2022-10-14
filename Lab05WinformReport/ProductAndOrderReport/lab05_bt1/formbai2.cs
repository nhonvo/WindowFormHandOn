using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab05_bt1.models;
using Microsoft.Reporting.WinForms;

namespace lab05_bt1
{
    public partial class formbai2 : Form
    {
        dbqldonhang context = new dbqldonhang();
        public formbai2()
        {
            InitializeComponent();
        }


        private void formbai2_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            setdataformat();
            reportViewer1.Visible = false;
        }

        private void setdataformat()
        {
            dtpngay.Value = new DateTime(2019, 10, 02);
            dtpthang.Value = new DateTime(2019, 10, 02);
            dtptungay.Value = new DateTime(2019, 10, 02);
            dtpdenngay.Value = new DateTime(2019, 10, 02);
            dtpngay.Format = DateTimePickerFormat.Custom;
            dtpngay.CustomFormat = "dd/MM/yyyy";
            dtpthang.Format = DateTimePickerFormat.Custom;
            dtpthang.CustomFormat = "MM/yyyy";
            dtptungay.Format = DateTimePickerFormat.Custom;
            dtptungay.CustomFormat = "dd/MM/yyyy";
            dtpdenngay.Format = DateTimePickerFormat.Custom;
            dtpdenngay.CustomFormat = "dd/MM/yyyy";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtpngay.Enabled = true;
            dtpthang.Enabled = false;
            dtptungay.Enabled = false;
            dtpdenngay.Enabled = false;
        }

        private void rdbthang_CheckedChanged(object sender, EventArgs e)
        {
            dtpngay.Enabled = false;
            dtpthang.Enabled = true;
            dtptungay.Enabled = false;
            dtpdenngay.Enabled = false;
        }

        private void rdbtungay_CheckedChanged(object sender, EventArgs e)
        {
            dtpngay.Enabled = false;
            dtpthang.Enabled = false;
            dtptungay.Enabled = true;
            dtpdenngay.Enabled = true;
        }

        private void btnInxem_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            if (dtpngay.Checked == true)
            {
                Invoice invoice = new Invoice();
                List<Order> listOrders = context.Orders.Where(p => p.Invoice.DeliveryDate == dtpngay.Value).ToList();
                List<ProductOrder> listTKs = new List<ProductOrder>();

                var List2 = from q in listOrders
                            group q by new { q.InvoiceNo, q.Invoice.OrderDate, q.Invoice.DeliveryDate } into p
                            select new { InvoiceNo = p.Key.InvoiceNo, OrderDate = p.Key.OrderDate, p.Key.DeliveryDate, Price = p.Sum(o => o.Price * o.Quantity) };

                if (List2.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng!");
                    return;
                }
                foreach (var item in List2)
                {
                    ProductOrder ProductOrder = new ProductOrder();
                    ProductOrder.InvoiceNo = item.InvoiceNo;
                    ProductOrder.DeliveryDate = item.DeliveryDate;
                    ProductOrder.Price = (decimal)Convert.ToDouble(item.Price);
                    listTKs.Add(ProductOrder);
                }
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("ngaydathang", string.Format("Ngày " +
                invoice.OrderDate.ToString("dd/MM/yyyy")));
                param[1] = new ReportParameter("ngaygiaohang", string.Format("Ngày " +
                invoice.DeliveryDate.ToString("dd/MM/yyyy")));

                this.reportViewer1.LocalReport.ReportPath = "./report/Reportthongkehoadon.rdlc";
                this.reportViewer1.LocalReport.SetParameters(param);
                ReportDataSource reportDataSource = new ReportDataSource("DataSetthongtindonhang", listTKs);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            if (rdbthang.Checked == true)
            {
                Invoice invoice = new Invoice();
                List<Order> listOrders = context.Orders.Where(p => p.Invoice.DeliveryDate == dtpthang.Value).ToList();
                List<ProductOrder> listTKs = new List<ProductOrder>();

                var List2 = from q in listOrders
                            group q by new { q.InvoiceNo, q.Invoice.DeliveryDate } into p
                            select new { InvoiceNO = p.Key.InvoiceNo, DeliveryDate = p.Key.DeliveryDate, Price = p.Sum(o => o.Price * o.Quantity) };

                if (List2.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng!");
                    return;
                }
                foreach (var item in List2)
                {
                    ProductOrder ProductOrder = new ProductOrder();
                    ProductOrder.InvoiceNo = item.InvoiceNO;
                    ProductOrder.DeliveryDate = item.DeliveryDate;
                    ProductOrder.Price = (decimal)Convert.ToDouble(item.Price);
                    listTKs.Add(ProductOrder);
                }
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("ngaydathang", string.Format("Ngày " +
                invoice.OrderDate.ToString("dd/MM/yyyy")));
                param[1] = new ReportParameter("ngaygiaohang", string.Format("Ngày " +
                invoice.DeliveryDate.ToString("dd/MM/yyyy")));
                this.reportViewer1.LocalReport.ReportPath = "./report/Reportthongkehoadon.rdlc";
                this.reportViewer1.LocalReport.SetParameters(param);
                ReportDataSource reportDataSource = new ReportDataSource("DataSetthongtindonhang", listTKs);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            if (rdbtungay.Checked == true)
            {
                Invoice invoice = new Invoice();
                List<Order> listOrders = context.Orders.Where(p => p.Invoice.DeliveryDate >= dtptungay.Value && p.Invoice.DeliveryDate <= dtpdenngay.Value).ToList();
                List<ProductOrder> listTKReports = new List<ProductOrder>();
                var list2 = from q in listOrders
                            group q by new { q.InvoiceNo, q.Invoice.OrderDate, q.Invoice.DeliveryDate } into p
                            select new { InvoiceNo = p.Key.InvoiceNo, OrderDate = p.Key.OrderDate, p.Key.DeliveryDate, Price = p.Sum(o => o.Price * o.Quantity) };
                if (list2.Count() == 0)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng!");
                    return;
                }
                foreach (var item in list2)
                {
                    ProductOrder ProductOrder = new ProductOrder();
                    ProductOrder.InvoiceNo = item.InvoiceNo;
                    ProductOrder.DeliveryDate = item.DeliveryDate;
                    ProductOrder.Price = (decimal)Convert.ToDouble(item.Price);
                    listTKReports.Add(ProductOrder);
                }
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("ngaydathang", string.Format("Ngày " +
                invoice.OrderDate.ToString("dd/MM/yyyy")));
                param[1] = new ReportParameter("ngaygiaohang", string.Format("Ngày " +
                invoice.DeliveryDate.ToString("dd/MM/yyyy")));
                this.reportViewer1.LocalReport.ReportPath = "./report/Reportthongkehoadon.rdlc";
                this.reportViewer1.LocalReport.SetParameters(param);
                ReportDataSource reportDataSource = new ReportDataSource("DataSetthongtindonhang", listTKReports);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
