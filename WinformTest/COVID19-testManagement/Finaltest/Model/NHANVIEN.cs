namespace Finaltest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [StringLength(12)]
        public string ID { get; set; }

        [Required]
        [StringLength(200)]
        public string HoTen { get; set; }

        public int SoLanXN { get; set; }

        public bool AmTinh { get; set; }

        [Required]
        [StringLength(6)]
        public string MaCty { get; set; }

        public virtual CONGTY CONGTY { get; set; }
    }
}
