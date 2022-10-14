using RapChieuNew.Models;
using RapPhimNew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimNew
{
    public delegate void CapNhatDanhSachKhachHang_Delegate();
    public partial class FrmThemKhachHang : Form
    {
        RapChieuPhimContext db = new RapChieuPhimContext();
        public event CapNhatDanhSachKhachHang_Delegate CapNhatDanhSachKhachHang_Delegate;
        public FrmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKhachHang = tenKhachHangTextBox.Text;
            KhachHang khachHangMoi = new KhachHang()
            {
                TenKhachHang = tenKhachHang
            };
            db.KhachHangs.Add(khachHangMoi);
            db.SaveChanges();
            CapNhatDanhSachKhachHang_Delegate();
            tenKhachHangTextBox.Clear();
            this.Close();
        }
    }
}
