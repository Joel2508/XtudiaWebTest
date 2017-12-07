using Domain.Instance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FronEnd.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var singleton = Singleton.GetUser().SelectUser();
            return View(singleton);
        }

        public ActionResult CreateUser()
        {
            return View();
        }
    }
}