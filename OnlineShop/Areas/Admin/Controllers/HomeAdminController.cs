﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        [Authorize]
        
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}