using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanSach.XuLy;
using WebBanSach.Models;
namespace WebBanSach.Areas.QuanTri.Controllers
{
    public class MenuController : Controller
    {
        // GET: QuanTri/Menu
        public ActionResult Index()
        {
            var dao = new MenuDao();
            var model = dao.LayTatCaMenu();
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Menu entity)
        {
            var dao = new MenuDao();
            dao.ThemMenu(entity);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            int MaMenu = int.Parse(id);
            var dao = new MenuDao();
            var model = dao.LayTheoMaMN(MaMenu);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Menu entity)
        {
            var dao = new MenuDao();
            dao.SuaMenu(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            int MaMenu = int.Parse(id);
            var dao = new MenuDao();
            var model = dao.LayTheoMaMN(MaMenu);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var dao = new MenuDao();
             dao.XoaMenu(id);
            return RedirectToAction("Index");
        }
    }
}