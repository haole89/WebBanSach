using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanSach.Models;
namespace WebBanSach.XuLy
{
    public class MenuDao
    {
        BanSachDBContext db = null;
        public MenuDao()
        {
            db = new BanSachDBContext();
        }
        //Hàm trả về danh sách các menu hiện có trong CSDL
        public List<Menu> LayTatCaMenu()
        {
            return db.Menus.OrderBy(x => x.MaMenu).ToList();
        }

        public Menu LayTheoMaMN(int maMN)
        {
            return db.Menus.Find(maMN);
        }
        public void ThemMenu(Menu entity)
        {
            db.Menus.Add(entity);
            db.SaveChanges();//Lưu vào CSDL
        }

        public void SuaMenu(Menu entity)
        {
            Menu mn = db.Menus.Find(entity.MaMenu);
            mn.TenMenu = entity.TenMenu;
            mn.Link = entity.Link;
            db.SaveChanges();
        }

        public void XoaMenu(int MaMN)
        {
            Menu mn = db.Menus.Find(MaMN);
            db.Menus.Remove(mn);
            db.SaveChanges();
        }
    

    }
}