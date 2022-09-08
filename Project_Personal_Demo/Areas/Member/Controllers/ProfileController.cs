using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Personal_Demo.Models;

namespace Project_Personal_Demo.Areas.Member.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        PersonalDbEntities db = new PersonalDbEntities();
        public ActionResult Index()
        {
            var mail = Session["MemberMail"];
            ViewBag.data1 = db.TblMember.Where(x => x.MemberMail == mail.ToString()).Select(y => y.MemberName + " " + y.MemberSurname).FirstOrDefault();
            return View();
        }

        [HttpGet]
        public ActionResult EditProfile()
        {
            var mail = Session["MemberMail"];
            var values = db.TblMember.Where(x => x.MemberMail == mail.ToString()).FirstOrDefault();
            return View(values);
        }
       
        [HttpPost]
        public ActionResult EditProfile(TblMember p)
        {
            var mail = Session["MemberMail"];
            var values = db.TblMember.Where(x => x.MemberMail == mail.ToString()).FirstOrDefault();
            values.MemberName = p.MemberName;
            values.MemberSurname = p.MemberSurname;
            values.MemberPassword = p.MemberPassword;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}  // GET: Member/Profile
/*
 Key
HttpGet
HttpPost
String Lenght
Authorize
 */

/*
 401 --> yetkisiz erişim isteği
404 --> Sayfa bulunamadı hatası
 */