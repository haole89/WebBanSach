using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.XuLy;
using WebBanSach.Models;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace WebBanSach.Areas.QuanTri.Controllers
{
    public class LoginController : Controller
    {
        // GET: QuanTri/Login      
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(NguoiDung entity)
        {
            var dao = new NguoiDungDao();
            string hassPass = MD5Hash(entity.MatKhau);
            var model = dao.DangNhap(entity.TaiKhoan, hassPass);
            if (model == 1)
            {
                //Biến session là biến quản lý phiên làm việc của mỗi cá nhân
                Session["USER_NAME"] = entity.TaiKhoan;
                return RedirectToAction("Index", "Default");
            }
            else
            {
                ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");
                
            }
            return View();

        }
        public string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}