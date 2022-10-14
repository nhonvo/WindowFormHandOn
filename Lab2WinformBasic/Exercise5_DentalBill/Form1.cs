using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void LockControl()
        {
            lblSoLuongNho.Visible = false;
            lblSoLuongTram.Visible = false;
            txtSoLuongNho.Visible = false;
            txtSoLuongTram.Visible = false;
        }
        private void cbxNho_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNho.Checked)
            {
                lblSoLuongNho.Visible = true;
                txtSoLuongNho.Visible = true;
            }
            else
            {
                lblSoLuongNho.Visible = false;
                txtSoLuongNho.Visible = false;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LockControl();
        }

        private void cbxTram_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTram.Checked)
            {
                lblSoLuongTram.Visible = true;
                txtSoLuongTram.Visible = true;
            }
            else
            {
                txtSoLuongTram.Visible = false;
                lblSoLuongTram.Visible = false;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int soTienNho = (cbxNho.Checked) ? Convert.ToInt32(txtSoLuongNho.Text) * 200 : 0;
            int soTienTram = (cbxTram.Checked) ? Convert.ToInt32(txtSoLuongTram.Text) * 100 : 0;
            int soTienNieng = (cbxNieng.Checked) ? 10000 : 0;
            int tongTien = (soTienNho + soTienTram + soTienNieng) * 1000;
            lblThanhTien.Text = Convert.ToString(tongTien);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
