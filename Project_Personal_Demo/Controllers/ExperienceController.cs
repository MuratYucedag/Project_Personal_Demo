using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Personal_Demo.Models;

namespace Project_Personal_Demo.Controllers
{
    public class ExperienceController : Controller
    {
        PersonalDbEntities personalDbEntities = new PersonalDbEntities();
        public ActionResult Index()
        {
            var values = personalDbEntities.TblExperience.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddExperience(TblExperience p)
        {
            personalDbEntities.TblExperience.Add(p);
            personalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteExperience(int id)
        {
            var values = personalDbEntities.TblExperience.Where(y => y.ExperienceID == id).FirstOrDefault();
            personalDbEntities.TblExperience.Remove(values);
            personalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditExperince(int id)
        {
            var values = personalDbEntities.TblExperience.Where(y => y.ExperienceID == id).FirstOrDefault();
            return View(values);
        }
    }
}