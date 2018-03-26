using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanSach.Models;
namespace WebBanSach.XuLy
{
    public class NguoiDungDao
    {
        BanSachDBContext db = null;
        public NguoiDungDao()
        {
            db = new BanSachDBContext();
        }
        public int DangNhap(string taikhoan, string matkhau)
        {
            var nd = db.NguoiDungs.Count(x => x.TaiKhoan == taikhoan && x.MatKhau == matkhau);
            if (nd > 0)
                return 1;//Đăng nhập thành công
            else
                return 0;//Đăng nhập thất bại
        }
    }
}