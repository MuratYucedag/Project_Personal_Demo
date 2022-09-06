using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Personal_Demo.Models;

namespace Project_Personal_Demo.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        PersonalDbEntities db = new PersonalDbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult StatisticsPartial()
        {
            ViewBag.v1 = db.TblSkill.Count();
            ViewBag.v2 = db.TblImage.Where(x => x.Cateogory == "C#").Count();
            int id = db.TblExperience.Max(x => x.ExperienceID);
            ViewBag.v3 = db.TblExperience.Where(x => x.ExperienceID == id).Select(y => y.ExperienceDate).FirstOrDefault();
            ViewBag.v4 = db.TblExperience.Where(x => x.ExperinceTitle == "Eğitmen").Count();
            return PartialView();
        }
    }
}