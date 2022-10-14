using RapPhimNew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapChieuNew.Models
{
    internal class TaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTaiKhoan { get; set; }
        [StringLength(100)]
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string TenHienThi { get; set; }

        public ICollection<PhanQuyen> PhanQuyens { get; set; }
    }
}
