using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopWEB.Areas.Admin.Models
{
    public class ChiTietDonHang
    {
        public int ID_Product { get; set; }
        public int soluong { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
    }
}