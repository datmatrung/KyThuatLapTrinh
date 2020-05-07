using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebApplication9
{
    public struct PhanSo
    {
        public int TuSo;
        public int MauSo;
    }

    public class XL_PhanSo
    {
        public static PhanSo KhoiTao(string s)
        {
            PhanSo P;
            var M = s.Split('/');
            P.TuSo = int.Parse(M[0]);
            P.MauSo = int.Parse(M[1]);
            return P;
        }

        public static PhanSo[] KhoiTaoMang(string s)
        {
            var M = s.Split(',');
            PhanSo[] A = new PhanSo[M.Length];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = KhoiTao(M[i]);
            }
            return A;
        }

        public static PhanSo TinhTongPhanSo(PhanSo A, PhanSo B)
        {
            PhanSo P;
            P.TuSo = A.TuSo * B.MauSo + A.MauSo * B.TuSo;
            P.MauSo = A.MauSo * B.MauSo;
            return P;
        }

        public static PhanSo TinhTongMang(PhanSo[] A)
        {
            PhanSo P;
            P.TuSo = 0; P.MauSo = 1;
            for (int i = 0; i < A.Length; i++)
            {
                P = TinhTongPhanSo(P, A[i]);
            }
            return P;
        }
        
        public static string Xuat(PhanSo P)
        {
            return $"{P.TuSo}/{P.MauSo}";
        }
    }
}
