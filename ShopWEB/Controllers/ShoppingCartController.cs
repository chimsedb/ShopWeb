using ShopWEB.ConectDB;
using ShopWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWEB.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult ThemGioHang(int id_pro)
        {
            int id_user = Convert.ToInt32(Session["user"]);

            if (Session["user"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                Select select = new Select();
                List<KiemTraGioHang> kiemTraGioHang = select.KiemTraSPTrongGioHang(id_user, id_pro);
                if(kiemTraGioHang.Count() >0 )
                {
                    select.UpdateSanPhamTrongGioHang(id_user, id_pro);
                }
                else
                {
                    select.ThemSanPhamVaoGioHang(id_user, id_pro);
                }
                

            }

            return RedirectToAction("Index", "Home");

        }

        public ActionResult ChiTietGioHang(int id_user)
        {
            ViewBag.id_user = id_user;
            Select select = new Select();
            List<GioHang> gioHangs = select.ChiTietGioHang(id_user);

            return View(gioHangs);

        }

        public ActionResult ThanhToanSP(int id_user)
        {
            
            Select select = new Select();
            select.ThanhToan(id_user);
            return RedirectToAction("ChiTietGioHang", "ShoppingCart",new { id_user = id_user});

        }
        [HttpPost]
        public ActionResult CapNhatSLGioHang(List<int> soluong,List<int> id)
        {

            Select select = new Select();
            for(int i = 0; i < soluong.Count(); i++)
            {
                select.UpdateSoLuongSanPhamTrongGioHang(Convert.ToInt32(Session["user"]),id[i],soluong[i]);
            }
            return RedirectToAction("ChiTietGioHang", "ShoppingCart", new { id_user = Convert.ToInt32(Session["user"]) });

        }

        public ActionResult XoaSPGioHang(int madonhang, int id_user)
        {
            Select select = new Select();
            select.XoaSPGioHang(madonhang, id_user);
            return RedirectToAction("ChiTietGioHang", "ShoppingCart", new { id_user = Convert.ToInt32(Session["user"]) });
        }
    }
}