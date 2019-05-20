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
    public class AlterProductController : Controller
    {
        public ActionResult Index(int id)
        {
            Select select = new Select();
            List<Product> products = select.SelectProducts();
            return View(products);
        }

        public ActionResult Alter(int id)
        {
            ViewBag.id = id;
            Select select = new Select();
            Product product = select.SelectProduct(id);
            return View(product);
        }
        [HttpPost]
        [ActionName("Alter")]
        public ActionResult AlterPost(int id,FormCollection form)
        {
            int price = Convert.ToInt32(form["price"]);
            SelectAdmin select = new SelectAdmin();
            select.AlterProduct(id, price);
            return RedirectToAction("Index","AlterProduct",new { id = Convert.ToInt32(Session["admin"]) });
        }
    }
}