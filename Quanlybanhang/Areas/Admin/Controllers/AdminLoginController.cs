using Model.DataObject;
using Quanlybanhang.Areas.Admin.Models;
using Quanlybanhang.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quanlybanhang.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Admin/AdminLogin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user_data = new User_data();
                var result = user_data.Login(model.UserName, model.Password);
                if(result == 1)
                {
                    var user = user_data.getItem(model.UserName);
                    var session = new UserLogin();
                    session.UserName = user.UserName;
                    session.UserID = user.ID;
                    session.Email = user.Email;
                    session.FullName = user.FullName;
                    Session.Add(Func.User_session, session);
                    return RedirectToAction("Index", "AdminHome");
                }
                else if(result == 0)
                {
                    ModelState.AddModelError("","Tài khoản chưa kích hoạt!");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Sai tên đăng nhâp hoặc mật khẩu!");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Sai tên đăng nhâp hoặc mật khẩu!");
                }
            }
            return View("Index");
        }
    }
}