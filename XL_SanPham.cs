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

        public static void XoaSanPham(int masp)
        {
            LT_SanPham.XoaSanPham(masp);
        }

        public static void SuaSanPham(SanPham sp)
        {
            LT_SanPham.SuaSanPham(sp);
        }

        public static SanPham DocSanPham(int masp)
        {
            SanPham kq = new SanPham();
            List<SanPham> ds = LT_SanPham.DocDanhSach();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaSP == masp)
                {
                    kq = ds[i];
                    break;
                }
            }
            return kq;
        }
    }
}