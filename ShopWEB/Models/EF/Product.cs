namespace ShopWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int ID_Product { get; set; }

        public int? ID_Catalog { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? Price { get; set; }

        public int? Discount { get; set; }

        public string Detail { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Created { get; set; }

        public int? ID_Admin { get; set; }

        public string Image { get; set; }

        public string Specification { get; set; }

        public virtual admin admin { get; set; }

        public virtual Catalog Catalog { get; set; }
    }
}
