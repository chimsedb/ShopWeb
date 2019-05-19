using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopWEB.Models
{
    public class ProductAndCatalog
    {
        public List<Product> product { get; set; }
        public List<Catalog> catalog { get; set; }
    }
}