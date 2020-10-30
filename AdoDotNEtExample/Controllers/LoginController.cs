using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoDotNEtExample.Models;
using System.Web.Security;

namespace AdoDotNEtExample.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(UserModel uobj)
        {
            if (uobj.UserName == "Divya" && uobj.Password == "Divya")
            {
                FormsAuthentication.SetAuthCookie(uobj.UserName, false);
                return Redirect("~/Login/Index");
            }
            else
            {
                ViewBag.msg = "Invalid UserName or Password";
                  return View();
            }

           
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login/Login");
        }
    }
}