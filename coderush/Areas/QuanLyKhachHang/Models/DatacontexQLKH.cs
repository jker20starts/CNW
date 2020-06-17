namespace coderush.Areas.QuanLyKhachHang.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatacontexQLKH : DbContext
    {
        public DatacontexQLKH()
            : base("name=DatacontexQLKH")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Oder> Oders { get; set; }
        public virtual DbSet<OderDetail> OderDetails { get; set; }
        public virtual DbSet<OderStatu> OderStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Oder>()
                .Property(e => e.OderID)
                .IsUnicode(false);

            modelBuilder.Entity<Oder>()
                .Property(e => e.OderStatusID)
                .IsUnicode(false);

            modelBuilder.Entity<Oder>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<OderDetail>()
                .Property(e => e.OderDetailID)
                .IsUnicode(false);

            modelBuilder.Entity<OderDetail>()
                .Property(e => e.OderID)
                .IsUnicode(false);

            modelBuilder.Entity<OderDetail>()
                .Property(e => e.SizeID)
                .IsUnicode(false);

            modelBuilder.Entity<OderDetail>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<OderStatu>()
                .Property(e => e.OderStatusID)
                .IsUnicode(false);
        }
    }
}
