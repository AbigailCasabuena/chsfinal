using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalHighSIMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            chsEntities1 db = new chsEntities1();
            List<student> list = db.students.Select(x => new student { lrn = x.lrn, fname = x.fname, mname = x.mname, lname = x.lname, status = x.status, grade_level = x.grade_level }).ToList();
            ViewBag.studentList = list;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}