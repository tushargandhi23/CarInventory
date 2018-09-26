using CarInventory.Models;
using CarInventory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInventory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            return View();
        }

        public ActionResult Login()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            return View(model);
        }


        public ActionResult Register()
        {
            return View();
        }

    }
}