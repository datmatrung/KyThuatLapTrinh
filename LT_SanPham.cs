using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using WebApplication13.Entity;

namespace WebApplication13.DAL
{
    public class LT_SanPham
    {
        public static List<SanPham> DocDanhSach(string tuKhoa = "")
        {
            List<SanPham> ds = new List<SanPham>();
            StreamReader reader = new StreamReader("H:\\sanpham.txt");
            int N = int.Parse(reader.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string s = reader.ReadLine();
                var M = s.Split(',');
                SanPham sp = new SanPham();
                sp.MaSP = int.Parse(M[0]);
                sp.TenSP = M[1];
                sp.Gia = int.Parse(M[2]);
                if (sp.TenSP.Contains(tuKhoa))
                {
                    ds.Add(sp);
                }
            }
            reader.Close();
            return ds;
        }

        public static bool ThemSanPham(SanPham sp)
        {
            var ds = DocDanhSach();
            if (ds.Count == 0)
                sp.MaSP = 1;
            else
                sp.MaSP = ds.Max(s => s.MaSP) + 1;
            ds.Add(sp);
            LuuTruDanhSach(ds);
            return true;
        }

        public static void LuuTruDanhSach(List<SanPham> ds)
        {
            StreamWriter writer = new StreamWriter("H:\\sanpham.txt");
            writer.WriteLine(ds.Count);
            foreach (var sp in ds)
            {
                writer.WriteLine($"{sp.MaSP},{sp.TenSP},{sp.Gia}");
            }
            writer.Close();
        }

        public static bool XoaSanPham(int masp)
        {
            var ds = DocDanhSach();
            foreach (var sp in ds)
            {
                if (sp.MaSP == masp)
                {
                    ds.Remove(sp);
                    break;
                }
            }
            LuuTruDanhSach(ds);
            return true;
        }

        public static bool SuaSanPham(SanPham sp)
        {
            var ds = DocDanhSach();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].MaSP == sp.MaSP)
                {
                    ds[i] = sp;
                    break;
                }
            }
            LuuTruDanhSach(ds);
            return true;
        }
    }
}
