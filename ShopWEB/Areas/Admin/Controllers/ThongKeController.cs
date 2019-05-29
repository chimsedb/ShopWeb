using ShopWEB.Areas.Admin.ConectDB;
using ShopWEB.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWEB.Areas.Admin.Controllers
{
    public class ThongKeController : Controller
    {
        // GET: Admin/ThongKe
        public ActionResult TKSPXacNhan(int id)
        {
            SelectAdmin select = new SelectAdmin();

            return View(select.TKDHXacNhan(1));
        }

        public ActionResult ChiTietDonHang(int id, int madonhang)
        {
            SelectAdmin select = new SelectAdmin();
            TTNguoiNhan tTNguoiNhan = select.ThongTinKhachHang(madonhang);
            ViewBag.TTKhachHang = tTNguoiNhan;
            return View(select.ChiTietDonHang(madonhang));
        }

        public ActionResult TKSPChuaXacNhan(int id)
        {
            SelectAdmin select = new SelectAdmin();

            return View(select.TKDHXacNhan(0));
        }

        public ActionResult ChiTietDonHangChuaXN(int id, int madonhang)
        {
            SelectAdmin select = new SelectAdmin();
            TTNguoiNhan tTNguoiNhan = select.ThongTinKhachHang(madonhang);
            
            return View(select.ChiTietDonHang(madonhang));
        }

    }
}