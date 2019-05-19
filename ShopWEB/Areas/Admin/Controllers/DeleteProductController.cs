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
    public class DeleteProductController : Controller
    {
        public ActionResult Index(int id)
        {
            Select select = new Select();
            List<Product> products = select.SelectProducts();
            return View(products);
        }

        public ActionResult Delete(int id)
        {

            SelectAdmin select = new SelectAdmin();
            select.DeleteProduct(id);
            return RedirectToAction("Index", "DeleteProduct", new { id = Convert.ToInt32(Session["admin"]) });
        }
    }
}