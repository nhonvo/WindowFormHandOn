using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1911065394_Lê_Xuân_Thành.models;

namespace _1911065394_Lê_Xuân_Thành
{
    public partial class Form1 : Form
    {
        dbtuthien context = new dbtuthien();
        private String stk;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<GiaoDich> giaoDiches = context.GiaoDiches.ToList();
            List<TaiKhoan> taiKhoans = context.TaiKhoans.ToList();
            dodulieudgv(giaoDiches);
            cbbstaikhoan(taiKhoans);
            cbbstk.SelectedIndex = 0;
            cbbgiaodich.SelectedIndex = 0;
        }

        private void cbbstaikhoan(List<TaiKhoan> taiKhoans)
        {
            this.cbbstk.DataSource = taiKhoans;
            this.cbbstk.DisplayMember = "STK";
            this.cbbstk.ValueMember = "TenNH";
        }


        private void dodulieudgv(List<GiaoDich> giaoDiches)
        {
            dgvthongtingiaodich.Rows.Clear();
            foreach (var item in giaoDiches)
            {
                int index = dgvthongtingiaodich.Rows.Add();
                dgvthongtingiaodich.Rows[index].Cells[0].Value = item.Id;
                dgvthongtingiaodich.Rows[index].Cells[1].Value = item.SoTien > 0 ? "Nhận tiền" : "Rút tiền";
                dgvthongtingiaodich.Rows[index].Cells[2].Value = Math.Abs(item.SoTien);
                dgvthongtingiaodich.Rows[index].Cells[3].Value = item.NoiDung;
            }
        }

        private void dgvthongtingiaodich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvthongtingiaodich.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvthongtingiaodich.CurrentRow.Selected = true;
                    cbbgiaodich.Text = dgvthongtingiaodich.Rows[e.RowIndex].Cells["dgvloaigd"].FormattedValue.ToString();
                    txtsotien.Text = dgvthongtingiaodich.Rows[e.RowIndex].Cells["dgvsotien"].FormattedValue.ToString();
                    txtnoidung.Text = dgvthongtingiaodich.Rows[e.RowIndex].Cells["dgvnoidung"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int tien = Convert.ToInt32(txtsotien.Text);
                if (tien < 1 || tien > 100000000)
                    throw new Exception("“Vui lòng nhập số tiền từ 1-100000000!");

                if (cbbgiaodich.Text == "Rút tiền" && soDuCuoiKi(stk) < int.Parse(txtsotien.Text))
                {
                    MessageBox.Show("Tài khoản không đủ số tiền để rút!");
                    return;
                }

                GiaoDich gd = new GiaoDich();
                gd.STK = cbbstk.Text;
                if (cbbgiaodich.Text == "Nhận tiền")
                {
                    gd.SoTien = Convert.ToInt32(txtsotien.Text);
                }
                else gd.SoTien = -Convert.ToInt32(txtsotien.Text);
                gd.NoiDung = txtnoidung.Text;

                context.GiaoDiches.Add(gd);
                context.SaveChanges();


                MessageBox.Show("Thêm mới giao dịch thành công!");
                List<GiaoDich> giaoDiches = context.GiaoDiches.ToList();
                dodulieudgv(giaoDiches);


            }
            catch (Exception ex)
            {
                MessageBox.Show("nhập sai rùi");
            }
        }
        private void loadform()
        {
            txtsotien.Clear();
            txtnoidung.Clear();
            txtsotien.Focus();
        }

        private void loadDGV()
        {
            List<GiaoDich> listgd = context.GiaoDiches.ToList();
            dodulieudgv(listgd);
        }
        private void cácGiaoDịchGửiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GiaoDich> giaoDiches = context.GiaoDiches.ToList();
            
            dgvthongtingiaodich.Rows.Clear();
            if (giaoDiches.Count <= 0) return;
            foreach (var gd in giaoDiches)
            {
                if (gd.SoTien <= 0) continue;
                int indexRow = dgvthongtingiaodich.Rows.Add();
                dgvthongtingiaodich.Rows[indexRow].Cells[0].Value = gd.Id;
                dgvthongtingiaodich.Rows[indexRow].Cells[1].Value = gd.SoTien > 0 ? "Nhận tiền" : "Rút tiền";
                dgvthongtingiaodich.Rows[indexRow].Cells[2].Value = Math.Abs(gd.SoTien);
                dgvthongtingiaodich.Rows[indexRow].Cells[3].Value = gd.NoiDung;
            }
            dgvthongtingiaodich.Rows[0].Selected = false;

            stk = giaoDiches[0].STK;

            cbbgiaodich.Text = dgvthongtingiaodich.Rows[0].Cells[1].FormattedValue.ToString();

            cbbstk.DataSource = giaoDiches;
            cbbstk.DisplayMember = "STK";
            cbbstk.ValueMember = "STK";

        }

        private void sốDưCuốiKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"STK: 1111111746 còn {soDuCuoiKi("1111111746")}" + Environment.NewLine + $"STK: 1111111812 còn {soDuCuoiKi("1111111812")}");
        }

        private void xuấtBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formrp formrp = new Formrp();
            formrp.Show();
        }

        private int soDuCuoiKi(string stk)
        {
            int soDuDauKi, soDuCuoiKi = 0;
            using (var dbcontext = new dbtuthien())
            {
                var tk = dbcontext.TaiKhoans.SingleOrDefault(_tk => _tk.STK == stk);
                soDuDauKi = (int)tk.SoDuDauKy;
            }
            List<GiaoDich> giaoDiches = context.GiaoDiches.ToList();
            foreach (var gd in giaoDiches)
            {
                if (gd.STK != stk) continue;
                soDuCuoiKi += gd.SoTien;
            }

            return soDuCuoiKi + soDuDauKi;
        }
        
    }
}
