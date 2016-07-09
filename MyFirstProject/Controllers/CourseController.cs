using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            return View(db.Courses.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Name,TotalCredits")] Course course)
        {
            if(ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }
       
    }
}