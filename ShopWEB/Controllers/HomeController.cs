
using ShopWEB.ConectDB;
using ShopWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Select select = new Select();

            ProductAndCatalog productAndCatalog = new ProductAndCatalog();
            List<Product> dienthoai = select.SelectTop4Products(1);
            List<Product> tablet = select.SelectTop4Products(2);
            List<Product> laptop = select.SelectTop4Products(3);
            List<Product> phukien = select.SelectTop4Products(4);
            List<Product> dongho = select.SelectTop4Products(5);
            List<Product> products = new List<Product>();
            products.AddRange(dienthoai);
            products.AddRange(tablet);
            products.AddRange(laptop);
            products.AddRange(phukien);
            products.AddRange(dongho);

            productAndCatalog.catalog = select.SelectCatalogs();
            productAndCatalog.product = products;


            //productAndCatalog.catalog = select.SelectCatalogs();
            //productAndCatalog.product = select.SelectProducts();

            ViewBag.user = Session["user"];

            return View(productAndCatalog);
        }

        

        public ActionResult DetailProduct(int id)
        {
            Select select = new Select();
            Product product = select.SelectProduct(id);
            return View(product);
        }
    }
}