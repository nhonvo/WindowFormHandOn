namespace lab05_bt1.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string InvoiceNo { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int No { get; set; }

        [Required]
        [StringLength(20)]
        public string ProductID { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }

        [StringLength(20)]
        public string Unit { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
