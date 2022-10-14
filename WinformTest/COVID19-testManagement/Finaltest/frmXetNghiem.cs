using Finaltest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finaltest
{
    public partial class frmXetNghiem : Form
    {
        XetNghiemDBContext db = new XetNghiemDBContext();
        public frmXetNghiem()
        {
            InitializeComponent();
            plInfor.Enabled = false;

        }
        public void BindGrid(List<NHANVIEN> lst)
        {
            dgvXetNghiem.Rows.Clear();
            foreach (var item in lst)
            {
                int index = dgvXetNghiem.Rows.Add();
                dgvXetNghiem.Rows[index].Cells[0].Value = item.ID;
                dgvXetNghiem.Rows[index].Cells[1].Value = item.HoTen;
                dgvXetNghiem.Rows[index].Cells[2].Value = item.SoLanXN;
                dgvXetNghiem.Rows[index].Cells[3].Value = item.AmTinh == true ? "Âm tính" : "+";
            }
        }
        public void ReloadCBB()
        {
            var lst = db.CONGTies.ToList();

            this.cbbCompany.DataSource = lst;
            this.cbbCompany.DisplayMember = "TenCty";
            this.cbbCompany.ValueMember = "MaCty";
        }
        private bool checkdatainput()
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập CCCD hoặc CMND !");
                return false;
            }
            else
            {
                if (Convert.ToInt32(txtId.TextLength) < 10 || Convert.ToInt32(txtId.TextLength) > 12)
                {

                    MessageBox.Show("Vui lòng nhập CCCD hoặc CMND !", "Thông Báo", MessageBoxButtons.OK);
                    return false;
                }
                foreach (char item in txtId.Text)
                {
                    if (!char.IsNumber(item))
                    {
                        MessageBox.Show("Vui lòng nhập CCCD hoặc CMND !", "Thông Báo", MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            return true;
        }
        private void frmXetNghiem_Load(object sender, EventArgs e)
        {
            var obj = db.NHANVIENs.ToList();
            BindGrid(obj);
            ReloadCBB();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkdatainput())
            {
                List<NHANVIEN> lst = db.NHANVIENs.Where(p => p.ID.Contains(txtId.Text)).ToList();
                if (lst != null)
                {
                    plInfor.Enabled = true;
                    BindGrid(lst);
                }
            }
        }
        private void dgvXetNghiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvXetNghiem.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvXetNghiem.CurrentRow.Selected = true;
                    txtId.Text = dgvXetNghiem.Rows[e.RowIndex].Cells["clId"].FormattedValue.ToString();
                    txtName.Text = dgvXetNghiem.Rows[e.RowIndex].Cells["clName"].FormattedValue.ToString();
                    txtSLXN.Text = dgvXetNghiem.Rows[e.RowIndex].Cells["clSLXN"].FormattedValue.ToString();
                    cbNegative.Checked = dgvXetNghiem.Rows[e.RowIndex].Cells["clResult"].FormattedValue.ToString() == "Âm tính" ? true : false;
                    cbPositive.Checked = dgvXetNghiem.Rows[e.RowIndex].Cells["clResult"].FormattedValue.ToString() == "Âm tính" ? false : true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkdatainput())
                {
                    List<CONGTY> lstct = new List<CONGTY>();
                    var findnv = db.NHANVIENs.FirstOrDefault(x => x.ID == txtId.Text);
                    if (findnv == null)
                    {
                        NHANVIEN nvnew = new NHANVIEN();
                        nvnew.ID = txtId.Text;
                        nvnew.HoTen = txtName.Text;
                        nvnew.SoLanXN = Convert.ToInt32(txtSLXN.Text);
                        nvnew.AmTinh = cbNegative.Checked;
                        nvnew.MaCty = cbbCompany.SelectedValue.ToString();
                        CONGTY ct = lstct.FirstOrDefault(x => x.MaCty == nvnew.MaCty);
                        db.NHANVIENs.Add(nvnew);
                        db.SaveChanges();
                        MessageBox.Show("Add data success!!", "Notification", MessageBoxButtons.OK);
                    }
                    else
                    {
                        var nv = db.NHANVIENs.FirstOrDefault(p => p.ID == txtId.Text);
                        nv.ID = txtId.Text;
                        nv.HoTen = txtName.Text;
                        nv.SoLanXN = Convert.ToInt32(txtSLXN.Text);
                        nv.AmTinh = cbNegative.Checked;
                        nv.MaCty = cbbCompany.SelectedValue.ToString();
                        CONGTY ct = lstct.FirstOrDefault(x => x.MaCty == nv.MaCty);
                        db.NHANVIENs.AddOrUpdate(nv);
                        db.SaveChanges();
                        MessageBox.Show("Modify data success!!", "Notification", MessageBoxButtons.OK);


                    }
                    var obj = db.NHANVIENs.ToList();
                    BindGrid(obj);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void danhSáchNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = db.NHANVIENs.Where(x => x.AmTinh == false).ToList();
            BindGrid(obj);
        }

        private void danhSáchCtyĐãTestTheoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Công ty đã test Y/C!!", "Notification", MessageBoxButtons.OK);
            List<CONGTY> obj = db.CONGTies.ToList();
            foreach(var item in obj)
            {
                MessageBox.Show("Tên công ty"+item.TenCty, "Notification", MessageBoxButtons.OK);
                MessageBox.Show("Số lượng nhân viên"+item.SLNV, "Notification", MessageBoxButtons.OK);
            }

        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XNReport xNReport = new XNReport();
            xNReport.Show();
        }

        
    }
}
