using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Finaltest.Model
{
    public partial class XetNghiemDBContext : DbContext
    {
        public XetNghiemDBContext()
            : base("name=XetNghiemDBContext")
        {
        }

        public virtual DbSet<CONGTY> CONGTies { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONGTY>()
                .HasMany(e => e.NHANVIENs);
                /*.WithRequired(e => e.CONGTY)
                .WillCascadeOnDelete(false);*/
        }
    }
}
