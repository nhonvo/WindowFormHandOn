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
    public partial class FrmHoaDon : Form
    {
        RapChieuPhimContext db = new RapChieuPhimContext();
        
        public FrmHoaDon()
        {
            InitializeComponent();

            CapNhatKhachHang();

            CapNhatHoaDon();
        }
        #region methods
        private List<KhachHang> GetKhachHangs()
        {
            return db.KhachHangs.ToList();
        }
        private List<HoaDon> GetHoaDons(int maKhachHang)
        {
            return db.HoaDons.Where(x => x.MaKhachHang == maKhachHang).ToList();
        }
        private List<ChiTietHoaDon> GetChiTietHoaDons(int maHoaDon)
        {
            return db.ChiTietHoaDons.Where(x => x.MaHoaDon == maHoaDon).ToList();
        }
        private void CapNhatKhachHang()
        {
            khachHangBindingSource.DataSource = GetKhachHangs();
        }
        private void CapNhatHoaDon()
        {
            int maKhachHang = Convert.ToInt32(khachHangComboBox.SelectedValue);
            hoaDonBindingSource.DataSource = GetHoaDons(maKhachHang);
        }
        private void CapNhatChiTiet()
        {
            HoaDon currHD = hoaDonBindingSource.Current as HoaDon;
            int maHoaDon = (currHD == null) ? -1 : currHD.MaHoaDon;
            chiTietHoaDonBindingSource.DataSource = GetChiTietHoaDons(maHoaDon);
        }
        #endregion

        private void dataGridViewHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            CapNhatChiTiet();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemKhachHang frmThemKhachHang = new FrmThemKhachHang();
            frmThemKhachHang.CapNhatDanhSachKhachHang_Delegate += CapNhatKhachHang;
            frmThemKhachHang.ShowDialog();
        }

        private void btnTaiKhachHang_Click(object sender, EventArgs e)
        {
            CapNhatKhachHang();
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon cthd = chiTietHoaDonBindingSource.Current as ChiTietHoaDon;
            if (MessageBox.Show("Bạn thật sự muốn xóa chi tiết hóa đơn này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            db.ChiTietHoaDons.Remove(cthd);
            db.SaveChanges();
            CapNhatChiTiet();
        }

        private void khachHangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            CapNhatHoaDon();
            CapNhatChiTiet();
        }
    }
}
