using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimNew.Models
{
    internal class QuyenTruyCap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaQuyen { get; set; }
        public string Ten { get; set; }

        public ICollection<PhanQuyen> PhanQuyens { get; set; }

    }
}
