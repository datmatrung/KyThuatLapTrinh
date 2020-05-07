using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9
{
    public struct Diem
    {
        public int X;
        public int Y;
    }

    public class XL_Diem
    {
        public static Diem KhoiTao(string s)
        {
            Diem kq;
            var M = s.Split(',');
            kq.X = int.Parse(M[0]);
            kq.Y = int.Parse(M[1]);
            return kq;
        }
        public static double TinhKhoangCach(Diem A, Diem B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        public static string xuat(Diem A)
        {
            return $"({A.X}, {A.Y})";
        }
    }
}
