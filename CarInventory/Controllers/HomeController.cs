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
        private UnitOfWork uow = null;

        public HomeController()
        {
            uow = new UnitOfWork();
        }

        public HomeController(UnitOfWork uow_)
        {
            this.uow = uow_;
        }

        public ActionResult Index()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult Index(UserModel model)
        {
            model.UserName = "ts";
            model.Password = "test123";
            model.CreatedOn = DateTime.Now;
            uow.UserRepository.Add(model);
            uow.SaveChanges();
            return View();
        }

        public ActionResult Login()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public ActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("", "EmailId or Password Incorrect.");

            }
            return View(model);
        }


        public ActionResult Register()
        {
            return View();
        }

    }
}