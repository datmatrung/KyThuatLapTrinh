using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication13.Entity;
using WebApplication13.DAL;

namespace WebApplication13.Business
{
    public class XL_SanPham
    {
        public static List<SanPham> DocDanhSach(string tuKhoa = "")
        {
            return LT_SanPham.DocDanhSach(tuKhoa);
        }

        public static void ThemSanPham(SanPham sp)
        {
            LT_SanPham.ThemSanPham(sp);
        }

        public static bool XoaSanPham(int masp)
        {
            return LT_SanPham.XoaSanPham(masp);
        }
    }
}