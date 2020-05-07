using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using WebApplication13.Entity;

namespace WebApplication13.DAL
{
    public class LT_User
    {
        static string filePath = "H:\\users.txt";
        public static List<User> LoadUsers()
        {
            List<User> dsUser = new List<User>();
            StreamReader reader = new StreamReader(filePath);
            int N = int.Parse(reader.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string s = reader.ReadLine();
                var M = s.Split(',');
                User user = new User();
                user.Id = int.Parse(M[0]);
                user.Username = M[1];
                user.Password = M[2];
                dsUser.Add(user);
            }
            reader.Close();
            return dsUser;
        }

        public static bool SaveUser(User user)
        {
            var dsUser = LoadUsers();
            user.Id = dsUser.Max(u => u.Id) + 1;
            dsUser.Add(user);
            SaveUsers(dsUser);
            return true;
        }

        public static void SaveUsers(List<User> dsUser)
        {
            StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine(dsUser.Count);
            foreach (var user in dsUser)
            {
                writer.WriteLine($"{user.Id},{user.Username},{user.Password}");
            }
            writer.Close();
        }

        //public static void XoaSanPham(int masp)
        //{
        //    var ds = DocDanhSach();
        //    foreach (var sp in ds)
        //    {
        //        if (sp.MaSP == masp)
        //        {
        //            ds.Remove(sp);
        //            break;
        //        }
        //    }
        //    LuuTruDanhSach(ds);
        //}

        //public static void SuaSanPham(SanPham sp)
        //{
        //    var ds = DocDanhSach();
        //    for (int i = 0; i < ds.Count; i++)
        //    {
        //        if (ds[i].MaSP == sp.MaSP)
        //        {
        //            ds[i] = sp;
        //            break;
        //        }
        //    }
        //    LuuTruDanhSach(ds);
        //}
    }
}