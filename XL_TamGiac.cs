using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication9
{
    public struct TamGiac
    {
        public Diem A;
        public Diem B;
        public Diem C;
    }

    public class XL_TamGiac
    {
        public static TamGiac KhoiTao(Diem A, Diem B, Diem C)
        {
            TamGiac kq;
            kq.A = A;
            kq.B = B;
            kq.C = C;
            return kq;
        }

        public static double TinhChuVi(TamGiac A)
        {
            double kq = 0;
            kq += XL_Diem.TinhKhoangCach(A.A, A.B);
            kq += XL_Diem.TinhKhoangCach(A.A, A.C);
            kq += XL_Diem.TinhKhoangCach(A.B, A.C);
            return kq;
        }
        
        public static string Xuat(TamGiac T)
        {
            return $"({T.A.X},{T.A.Y}), ({T.B.X},{T.B.Y}), ({T.C.X},{T.C.Y})";
        }
    }
}