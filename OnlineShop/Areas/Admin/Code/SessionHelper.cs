using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSessions session )
        {
            HttpContext.Current.Session["LoginSession"] = session;
        }
        public static UserSessions GetSessions()
        {
            var session = HttpContext.Current.Session["LoginSession"];
            if (session == null)
                return null;
            else
            {
                return session as UserSessions;
            }
        }
    }
}