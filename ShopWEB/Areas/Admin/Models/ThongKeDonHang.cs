using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopWEB.Areas.Admin.Models
{
    public class ThongKeDonHang
    {
        public int MaDonHang { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public int SoLuong { get; set; }
        public int TongTien { get; set; }

        
    }
}