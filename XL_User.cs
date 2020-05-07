using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication13.Entity;
using WebApplication13.DAL;

namespace WebApplication13.Business
{
    public class XL_User
    {
        public static bool AddUser(User user)
        {
            if (user.Password.Length < 8)
            {
                return false;
            }
            return LT_User.SaveUser(user);
        }

        public static bool dangNhap(User u)
        {
            List<User> ds = LT_User.LoadUsers();
            bool kq = false;
            foreach (var s in ds)
            {
                if ((s.Password == u.Password) && (s.Username == u.Username))
                {
                    kq = true;
                    break;
                }
            }
            return kq;
        }
    }
}