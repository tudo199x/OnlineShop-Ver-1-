using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace OnlineShop.Areas.Admin.Code
{
    [Serializable]
    public class UserSessions
    {
        public string UserName { set; get; }
    }
}