using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimNew.Models
{
    internal class ChiTietHoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaChiTietHoaDon { get; set; }
        public int SoGhe { get; set; }
        public HoaDon HoaDon { get; set; }
        [ForeignKey("HoaDon")]
        public int MaHoaDon { get; set; }
        public double GiaVe { get; set; }
    }
}
