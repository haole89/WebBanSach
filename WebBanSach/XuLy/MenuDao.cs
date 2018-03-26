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
    }
}