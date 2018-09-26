using CarInventory.Models;
using CarInventory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInventory.Controllers
{
    public class UserController : Controller
    {
        private UnitOfWork uow = null;

        public UserController()
        {
            uow = new UnitOfWork();
        }

        public UserController(UnitOfWork uow_)
        {
            this.uow = uow_;
        }

        public ActionResult Index()
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
            try
            {
                if (ModelState.IsValid)
                {
                    var users = uow.UserRepository.GetAll().ToList().
                                Where(m => m.UserName.Equals(model.UserName)
                                && m.Password.Equals(model.Password));

                    if (users.Count() == 1)
                    {
                        return RedirectToAction("Index", "Car", new { @userId = users.FirstOrDefault().Id });
                    }
                }
                return View(model);
            }
            catch (Exception ex)
            {
                Logger.Error("User/Login", ex);
                return View(model);
            }
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View(new UserModel());
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var users = uow.UserRepository.GetAll().ToList().
                                Where(m => m.UserName.Equals(model.UserName)
                                && m.Password.Equals(model.Password));

                    if (users.Count() == 0)
                    {
                        model.CreatedOn = DateTime.Now;
                        uow.UserRepository.Add(model);
                        uow.SaveChanges();
                        var newUser = uow.UserRepository.GetAll().ToList().
                              Where(m => m.UserName.Equals(model.UserName)
                              && m.Password.Equals(model.Password)).FirstOrDefault();
                        return RedirectToAction("Index", "Car", new { @userId = newUser.Id });
                    }
                    else
                    {
                        return View(model);
                    }
                }
                return View(model);
            }
            catch (Exception ex)
            {

                Logger.Error("User/Create", ex);
                return View(model);
            }
        }

    }
}
