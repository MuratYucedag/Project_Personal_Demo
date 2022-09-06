using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Personal_Demo.Models;

namespace Project_Personal_Demo.Controllers
{
    public class DefaultController : Controller
    {
        PersonalDbEntities db = new PersonalDbEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult BannerPartial()
        {
            return PartialView();
        }

        public PartialViewResult SkillPartial()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult FeaturePartial()
        {
            return PartialView();
        }

        public PartialViewResult ImagePartial()
        {
            ViewBag.v = "C# ve .Net alanında yapmış olduğum projelere ait görsellere aşağıdan ulaşabilirsiniz, daha fazlası için iletişim kısmından bana yazabilirsiniz.";
            var values = db.TblImage.ToList();
            return PartialView(values);
        }

        public PartialViewResult ExperiencePartial()
        {
            return PartialView();
        }

        public PartialViewResult EducationPartial()
        {
            return PartialView();
        }

        public PartialViewResult TestimonialPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}