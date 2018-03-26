using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.XuLy;
namespace WebBanSach.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult TrangChu()
        {
            var dao = new MenuDao();
            var model = dao.LayTatCaMenu();
            return View(model);
        }
    }
}