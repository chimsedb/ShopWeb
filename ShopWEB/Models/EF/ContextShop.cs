namespace ShopWEB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextShop : DbContext
    {
        public ContextShop()
            : base("name=ContextShop")
        {
        }

        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
