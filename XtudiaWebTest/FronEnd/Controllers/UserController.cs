using Domain.Data;
using Domain.Instance;
using FronEnd.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ActionResult GetUser()
        {
            var singleton = Singleton.GetUser().SelectUser();
            return Json(new { data = singleton }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(UserView view)
        {

            if (view != null)
            {
                var user = toViewUser(view);
                Singleton.GetUser().InsertUser(user);
            }
            return Json(view);
        }

        private CHE_Usuario toViewUser(UserView view)
        {
            return new CHE_Usuario
            {
                Apellidos = view.Apellidos,
                Nombres = view.Nombres,
                Documento = view.Documento,
                EMail = view.EMail,
                IDUsuario = view.IDUsuario,
                Password = view.Password,
                UserName = view.UserName,
            };
        }
    }
}