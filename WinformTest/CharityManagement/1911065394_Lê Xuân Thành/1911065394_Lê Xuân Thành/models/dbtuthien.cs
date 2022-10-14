using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _1911065394_Lê_Xuân_Thành.models
{
    public partial class dbtuthien : DbContext
    {
        public dbtuthien()
            : base("name=dbtuthien")
        {
        }

        public virtual DbSet<GiaoDich> GiaoDiches { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.SoDuDauKy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaiKhoan>()
                .HasMany(e => e.GiaoDiches)
                .WithRequired(e => e.TaiKhoan)
                .WillCascadeOnDelete(false);
        }
    }
}
