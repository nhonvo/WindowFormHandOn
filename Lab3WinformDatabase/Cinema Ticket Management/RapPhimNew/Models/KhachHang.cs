using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimNew.Models
{
    internal class KhachHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKhachHang { get; set; }
        [StringLength(100)]
        public string TenKhachHang { get; set; }
        public ICollection<HoaDon> HoaDons { get; set; }
    }
}
