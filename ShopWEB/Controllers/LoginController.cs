using ShopWEB.ConectDB;
using ShopWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWEB.Views.Login
{
    public class LoginController : Controller
    {
        // GET: Login

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult DangNhap(string email, string password)
        {
            
            Select select = new Select();
            List<admin> admins = select.SelectAllAdmin();
            foreach (admin admin in admins)
            {
                if (email == admin.UserName && password == admin.Password)
                {
                    Session["admin"] = admin.ID_Admin.ToString();
                    return RedirectToAction("Index", "Admin/AdminHome", new { id = Convert.ToInt32(Session["admin"]) });
                }

            }

            List<KhachHang> khachHangs = select.SelectAllUser();
            foreach (KhachHang khachHang in khachHangs)
            {
                if (email == khachHang.Email && password == khachHang.Password)
                {
                    Session["user"] = khachHang.ID_User.ToString(); 
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }

            }

            return RedirectToAction("Index", "Login");
        }

        public ActionResult DangXuat()
        {
            Session["user"] = null;

            return RedirectToAction("Index", "Home");
        }
    }
}