using RapChieuNew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimNew.Models
{
    internal class PhanQuyen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhanQuyen { get; set; }

        public TaiKhoan TaiKhoan { get; set; }
        [ForeignKey("TaiKhoan")]
        public int MaTaiKhoan { get; set; }

        public QuyenTruyCap QuyenTruyCap { get; set; }
        [ForeignKey("QuyenTruyCap")]
        public int MaQuyenTruyCap { get; set; }
    }
}
