using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanSach.Areas.QuanTri.Controllers
{
    public class DefaultController : Controller
    {
        // GET: QuanTri/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}