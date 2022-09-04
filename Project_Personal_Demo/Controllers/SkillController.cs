using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Personal_Demo.Models;

namespace Project_Personal_Demo.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill

        PersonalDbEntities personalDbEntities = new PersonalDbEntities();
        public ActionResult Index()
        {
            var values = personalDbEntities.TblSkill.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(TblSkill p)
        {
            personalDbEntities.TblSkill.Add(p);
            personalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = personalDbEntities.TblSkill.Where(x => x.SkillID == id).FirstOrDefault();
            personalDbEntities.TblSkill.Remove(value);
            personalDbEntities.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditSkill(int id)
        {
            var value = personalDbEntities.TblSkill.Where(x => x.SkillID == id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public ActionResult EditSkill()
        {
            return View();
        }
    }
}