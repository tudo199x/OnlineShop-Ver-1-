using Microsoft.Ajax.Utilities;
using Models;
using OnlineShop.Areas.Admin.Code;
using OnlineShop.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
           // var result = new AccountModel().Login(model.UserName, model.Password);
            if (Membership.ValidateUser(model.UserName,model.Password) && ModelState.IsValid)
            {
                //SessionHelper.SetSession(new UserSessions() { UserName = model.UserName });
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                return RedirectToAction("Index", "HomeAdmin");
            }
            else
            {
                ModelState.AddModelError("", "Email hoặc mật khẩu không chính xác");
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}