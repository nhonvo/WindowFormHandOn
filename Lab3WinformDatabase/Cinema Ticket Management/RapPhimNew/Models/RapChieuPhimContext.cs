using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RapPhimNew.Models;

namespace RapChieuNew.Models
{
    internal class RapChieuPhimContext : DbContext
    {
        public RapChieuPhimContext() : base("name=RapPhimContext") {}

        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<QuyenTruyCap> QuyenTruyCaps { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
