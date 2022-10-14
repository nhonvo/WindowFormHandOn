using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapChieuNew.Models;
using RapPhimNew.Models;

namespace RapPhimNew
{
    public partial class frmDangNhap : Form
    {
        public event DelegateDangNhap delegateDangNhap;
        RapChieuPhimContext rapChieuPhimContext;

        public frmDangNhap()
        {
            InitializeComponent();
            rapChieuPhimContext = new RapChieuPhimContext();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text; 
            string matKhau = txtMatKhau.Text;

            if (rapChieuPhimContext.TaiKhoans.Any(x=>x.TenDangNhap==tenDangNhap && x.MatKhau == matKhau))
            {
                List<int> maDanhSachQuyen = rapChieuPhimContext.TaiKhoans.Include("PhanQuyens").FirstOrDefault(x => x.TenDangNhap == tenDangNhap && x.MatKhau == matKhau).PhanQuyens.Select(x => x.MaQuyenTruyCap).ToList();

                if (maDanhSachQuyen.Contains(rapChieuPhimContext.QuyenTruyCaps.FirstOrDefault(x=>x.Ten=="admin").MaQuyen))
                {
                    delegateDangNhap("admin");
                }
                else
                {
                    delegateDangNhap("nhanvien");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("SAI TAI KHOAN");
            }
        }
    }
}
