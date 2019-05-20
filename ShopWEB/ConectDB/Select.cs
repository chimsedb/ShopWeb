using ShopWEB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ShopWEB.ConectDB
{
    public class Select
    {
        ContextShop context ;

        public Select()
        {
            context = new ContextShop();
        }

        public List<Product> SelectProducts()
        {
            return context.Products.SqlQuery(@"select * from Product").ToList();
        }

        public List<Catalog> SelectCatalogs()
        {
            return context.Catalogs.SqlQuery(@"select * from Catalog ").ToList();
        }

        public List<Product> SelectProducts(int ID_Catalog)
        {
            return context.Products.SqlQuery(@"select * from Product where ID_Catalog = " + ID_Catalog ).ToList();
        }

        public List<Product> SelectTop4Products(int ID_Catalog)
        {
            return context.Products.SqlQuery(@"select top 4 * from Product where ID_Catalog = " + ID_Catalog).ToList();
        }

        public Product SelectProduct(int ID_Product)
        {
            return context.Products.SqlQuery(@"select * from Product where ID_Product = " + ID_Product).Single();
        }

        public List<KhachHang> SelectAllUser()
        {
            return context.KhachHangs.SqlQuery(@"select * from KhachHang").ToList();
        }

        public List<admin> SelectAllAdmin()
        {
            return context.admins.SqlQuery(@"select * from admin").ToList();
        }

        public void DangKyTK(string name,string email,string pass,string address,int phone)
        {
            var Name = new SqlParameter("@name", name);
            var Email = new SqlParameter("@email", email);
            var Pass = new SqlParameter("@pass", pass);
            var Address = new SqlParameter("@address", address);
            var Phone = new SqlParameter("@phone", phone);

            context.Database.ExecuteSqlCommand(@"DANGKY @name,@email,@pass,@address,@phone", Name, Email, Pass, Address, Phone);
            context.SaveChanges();
        }

        public void UpdateSanPhamTrongGioHang(int ID_User,int ID_Pro)
        {
            var iduser = new SqlParameter("@id_user", ID_User);
            var idpro = new SqlParameter("@id_pro", ID_Pro);

            context.Database.ExecuteSqlCommand(@"UpdateSanPhamTrongGioHang @id_user,@id_pro", iduser, idpro);   
            context.SaveChanges();
        }

        public void UpdateSoLuongSanPhamTrongGioHang(int ID_User, int ID_Pro,int Soluong)
        {
            var iduser = new SqlParameter("@id_user", ID_User);
            var idpro = new SqlParameter("@id_pro", ID_Pro);
            var soluong = new SqlParameter("@soluong", Soluong);

            context.Database.ExecuteSqlCommand(@"UpdateSoLuongSanPhamTrongGioHang @id_user,@id_pro,@soluong", iduser, idpro, soluong);
            context.SaveChanges();
        }

        public void ThemSanPhamVaoGioHang(int ID_User, int ID_Pro)
        {
            var iduser = new SqlParameter("@id_user", ID_User);
            var idpro = new SqlParameter("@id_pro", ID_Pro);

            context.Database.ExecuteSqlCommand(@"ThemSanPhamVaoGioHang @id_user,@id_pro", iduser, idpro);
            context.SaveChanges();
        }

        public List<KiemTraGioHang> KiemTraSPTrongGioHang(int ID_User, int ID_Pro)
        {
            var iduser = new SqlParameter("@id_user", ID_User);
            var idpro = new SqlParameter("@id_pro", ID_Pro);

            return context.Database.SqlQuery<KiemTraGioHang>(@"KiemTraSPTrongGioHang @id_user,@id_pro", iduser, idpro).ToList<KiemTraGioHang>();
        }

        public List<GioHang> ChiTietGioHang(int ID_User)
        {
            var iduser = new SqlParameter("@ID_user", ID_User);
            
            return context.Database.SqlQuery<GioHang>(@"HienThiGioHang @ID_user", iduser).ToList<GioHang>();
           
        }

        public void XoaSPGioHang(int ID_User,int Madonhang)
        {
            var iduser = new SqlParameter("@id_user", ID_User);
            var madonhang = new SqlParameter("@madonhang", Madonhang);

            context.Database.ExecuteSqlCommand(@"XOASPGIOHANG @ID_user,@madonhang", iduser, madonhang);
            context.SaveChanges();
        }


        public void ThanhToan(int ID_User)
        {
            var iduser = new SqlParameter("@id_user", ID_User);

            context.Database.ExecuteSqlCommand(@"ThanhToan @ID_user", iduser);
            context.SaveChanges();
        }


    }
}