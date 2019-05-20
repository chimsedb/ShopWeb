using ShopWEB.Areas.Admin.ConectDB;
using ShopWEB.ConectDB;
using ShopWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWEB.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index(int id)
        {
            Select select = new Select();
            List<Product> products = select.SelectProducts();
            return View(products);
        }

        public ActionResult Logout(int id)
        {
            Session["admin"] = null;
            return RedirectToAction("Index", "Login", new { area = "" });
        }

        
    }
}