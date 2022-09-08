using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Project_Personal_Demo.Models;

namespace Project_Personal_Demo.Areas.Member.Controllers
{
    public class LoginController : Controller
    {
        // GET: Member/Login

        PersonalDbEntities db = new PersonalDbEntities();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblMember p)
        {
            var values = db.TblMember.FirstOrDefault(x => x.MemberMail == p.MemberMail && x.MemberPassword == p.MemberPassword);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.MemberMail, false);
                Session["MemberMail"] = values.MemberMail;
                return RedirectToAction("Index", "Profile");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}