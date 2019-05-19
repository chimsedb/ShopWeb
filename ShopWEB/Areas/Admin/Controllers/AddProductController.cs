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
    public class AddProductController : Controller
    {
        public ActionResult Add(int id)
        {
            Select select = new Select();
            List<Catalog> catalogs = select.SelectCatalogs();
            return View(catalogs);
        }
        [HttpPost]
        [ActionName("Add")]
        public ActionResult AddPost(FormCollection myform)
        {

            SelectAdmin selectAdmin = new SelectAdmin();
            string name = myform["name"];
            int madanhmuc = Convert.ToInt32(myform["madanhmuc"].Substring(0,2));
            int price = Convert.ToInt32(myform["price"]);
            string chitiet = myform["chitiet"];
            string image = myform["image"];

            selectAdmin.AddProduct(Convert.ToInt32(Session["admin"]), madanhmuc, name, price, chitiet, image);

            return RedirectToAction("Index", "AdminHome", new { id = Session["admin"] });
        }
    }
}