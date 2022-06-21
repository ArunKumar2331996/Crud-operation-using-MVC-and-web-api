using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (login != null && login.UName == "aaa" && login.Password == "aaa")
            {
                return RedirectToAction("Index", "Employees", login);
            }
            else return new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
        }
    }
}