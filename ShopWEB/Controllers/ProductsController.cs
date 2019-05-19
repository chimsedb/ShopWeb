using ShopWEB.ConectDB;
using ShopWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWEB.Controllers
{
    public class ProductsController : Controller
    {
        // GET: DienThoai
        [HttpGet]
        public ActionResult Index(int id,string namecatalog)
        {
            ViewBag.namecatalog = namecatalog;
            Select select = new Select();
            List<Product> products =  select.SelectProducts(id);

            return View(products);
        }

    }
}