namespace _1911065394_Lê_Xuân_Thành.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoDich")]
    public partial class GiaoDich
    {
        public int Id { get; set; }

        public int SoTien { get; set; }

        [StringLength(255)]
        public string NoiDung { get; set; }

        [Required]
        [StringLength(10)]
        public string STK { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
