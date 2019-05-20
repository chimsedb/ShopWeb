using ShopWEB.ConectDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopWEB.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Register")]
        public ActionResult RegisterPost(FormCollection form)
        {
            string name = form["ten"];
            string email = form["email"];
            string pass = form["mk"];
            string address = form["diachi"];
            int phone = Convert.ToInt32(form["sdt"]);

            Select select = new Select();
            select.DangKyTK(name, email, pass, address, phone);

            return RedirectToAction("Index","Login");
        }
    }

    
}