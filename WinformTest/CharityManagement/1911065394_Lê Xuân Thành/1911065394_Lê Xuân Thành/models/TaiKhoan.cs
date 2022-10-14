namespace _1911065394_Lê_Xuân_Thành.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            GiaoDiches = new HashSet<GiaoDich>();
        }

        [Key]
        [StringLength(10)]
        public string STK { get; set; }

        [Required]
        [StringLength(150)]
        public string TenNH { get; set; }

        public decimal SoDuDauKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoDich> GiaoDiches { get; set; }
    }
}
