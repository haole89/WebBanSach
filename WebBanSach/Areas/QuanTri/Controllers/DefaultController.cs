using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanSach.Areas.QuanTri.Controllers
{
    public class DefaultController : BaseController
    {
        // GET: QuanTri/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}