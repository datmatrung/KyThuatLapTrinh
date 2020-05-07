using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication9
{
    public struct DaGiac
    {
        public Diem[] dsDiem;
    }

    public class XL_DaGiac
    {
        public static DaGiac KhoiTao(string s)
        {
            DaGiac kq;
            var M = s.Split('|');
            kq.dsDiem = new Diem[M.Length];
            for (int i = 0; i < kq.dsDiem.Length; i++)
            {
                kq.dsDiem[i] = XL_Diem.KhoiTao(M[i]);
            }
            return kq;
        }

        public static double TinhChuVi(DaGiac A)
        {
            double kq = 0;
            int N = A.dsDiem.Length;
            for (int i = 0; i < N - 1; i++)
            {
                kq += XL_Diem.TinhKhoangCach(A.dsDiem[i], A.dsDiem[i+1]);
            }
            kq += XL_Diem.TinhKhoangCach(A.dsDiem[0], A.dsDiem[N-1]);
            return kq;
        }
        
        public static string xuat(DaGiac D)
        {
            string s = string.Empty;
            for (int i = 0; i < D.dsDiem.Length; i++)
            {
                s += XL_Diem.xuat(D.dsDiem[i]) + ", ";
            }
            return s;
        }
    }
}
