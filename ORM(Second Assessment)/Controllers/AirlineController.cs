using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ORM_Second_Assessment_.Models;

namespace ORM_Second_Assessment_.Controllers
{
    public class AirlineController : Controller
    {
        private readonly AirlineORMCRUDOperationsContext orm = null;

        public AirlineController(AirlineORMCRUDOperationsContext orm2)
        {
            orm = orm2;
        }
        [HttpGet]
        public IActionResult AddAirline()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAirline(Airline airline)
        {
            try
            {
                orm.Airline.Add(airline);
                orm.SaveChanges();
                ViewBag.hint = "Success";
                ViewBag.message = airline.Name + " is Saved Successfully";
            }

            catch (Exception)
            {
                ViewBag.hint = "Failed";
                ViewBag.message = airline.Name + " is not Saved Error!!!!";
                return View();

            }
            return RedirectToAction("ListAirlinedata");
        }
        public IActionResult ListAirlinedata()
        {
            return View(orm.Airline.ToList());
        }
        public IActionResult DeleteAirlinedata(int id)
        {
            
            orm.Airline.Remove(orm.Airline.Find(id));
            orm.SaveChanges();
            return RedirectToAction("ListAirlinedata");
        }
        [HttpGet]
        public IActionResult EditAirlineData(int id)
        {
            var EditAirline = orm.Airline.Find(id);
            return View(EditAirline);
        }
        [HttpPost]
        public IActionResult EditAirlineData(Airline airline)
        {
            orm.Airline.Update(airline);
            orm.SaveChanges();
            return RedirectToAction("ListAirlinedata");
        }
        [HttpGet]
        public IActionResult ViewAirline(int id)
        {
            var view = orm.Airline.Find(id);
            return View(view);
        }
    }
}