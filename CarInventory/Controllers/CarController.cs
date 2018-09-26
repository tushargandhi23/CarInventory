using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInventory.Models;
using CarInventory.Repositories;

namespace CarInventory.Controllers
{
    public class CarController : Controller
    {
        private UnitOfWork uow = null;

        public CarController()
        {
            uow = new UnitOfWork();
        }

        public CarController(UnitOfWork uow_)
        {
            this.uow = uow_;
        }
        public ActionResult Index(int userId)
        {
            var userCarVM = new UserCarViewModel();
            userCarVM.Cars = uow.CarRepository.GetAll().Where(m => m.CreatedBy.Equals(userId)).ToList();
            userCarVM.User.Id = userId;
            return View(userCarVM);
        }

        public ActionResult Add()
        {
            ViewBag.Message = "Add New Car";
            return PartialView("_Add", new UserCarViewModel());
        }

        [HttpPost]
        public ActionResult Save(UserCarViewModel model)
        {

            model.Car.CreatedOn = DateTime.Now;
            model.Car.CreatedBy = model.User.Id;
            if (ModelState.IsValid)
            {
                uow.CarRepository.Add(model.Car);
                uow.SaveChanges();
                model.Car = new CarModel();
                return RedirectToAction("Index", "Car", new { @userId = model.User.Id });
            }
            else
            {
                return PartialView("_Add", new { @userId = model.Car.CreatedBy });
            }
        }
    }
}