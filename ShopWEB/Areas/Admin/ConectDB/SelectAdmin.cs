using ShopWEB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShopWEB.Areas.Admin.ConectDB
{
    public class SelectAdmin
    {
        ContextShop context;
        public SelectAdmin()
        {
            context = new ContextShop();
        }

        public void AddProduct(int id_admin,int id_catalog,string name,int price,string detail,string image)
        {
            var Id_admin = new SqlParameter("@id_admin", id_admin);
            var Id_catalog = new SqlParameter("@id_catalog", id_catalog);
            var Name = new SqlParameter("@Name", name);
            var Price = new SqlParameter("@price", price);
            var Detail = new SqlParameter("@detail", detail);
            var Image = new SqlParameter("@image", image);

            context.Database.ExecuteSqlCommand(@"THEMSP @id_admin,@id_catalog,@Name,@price,@detail,@image",
                Id_admin, Id_catalog, Name, Price, Detail, Image);
            context.SaveChanges();
        }

        public void DeleteProduct(int id_pro)
        {
            var Id_pro = new SqlParameter("@id_pro", id_pro);
            
            context.Database.ExecuteSqlCommand(@"XOASP @id_pro",Id_pro);
            context.SaveChanges();
        }

        public void AlterProduct(int id_pro,int price)
        {
            var Id_pro = new SqlParameter("@id_pro", id_pro);
            var Price = new SqlParameter("@price", price);

            context.Database.ExecuteSqlCommand(@"SUASP @id_pro,@price", Id_pro, Price);
            context.SaveChanges();
        }
    }
}