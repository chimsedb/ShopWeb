using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopWEB.Models
{
    public class GioHang
    {
        public int ID_Product { get; set; }
        public int soluong { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public int MaDonHang { get; set; }
    }
}