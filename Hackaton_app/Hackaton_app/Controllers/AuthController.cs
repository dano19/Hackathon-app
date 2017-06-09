using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hackaton_app.Controllers
{
    public class AuthController : Controller
    {
        #region Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var result = CommonLibrary.Logic.User.Login(email, password);
            TempData["message"] = result;
            if (result.Success)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Login", "Auth");
        }
        #endregion

        #region Register
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string email, string password, string confirmPassword)
        {
            var result = CommonLibrary.Logic.User.Register(email, password, confirmPassword);
            TempData["message"] = result;
            if (result.Success)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("Register", "Auth");
        }
        #endregion

    }
}