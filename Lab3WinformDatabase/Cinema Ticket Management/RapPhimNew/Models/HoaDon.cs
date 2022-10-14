using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimNew.Models
{
    internal class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHoaDon { get; set; }
        public double TongTien { get; set; }
        public DateTime NgayLap { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public KhachHang KhachHang { get; set; }
        [ForeignKey("KhachHang")]
        public int MaKhachHang { get; set; }
    }
}
