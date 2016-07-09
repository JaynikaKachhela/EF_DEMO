using MyFirstProject.Models;
using MyFirstProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstProject.Controllers
{
    public class XyzController : Controller
    {
        //private SchoolContext db = new SchoolContext();
        //public ActionResult Abc()
        //{
        //    var students = db.Students.ToList();
        //    return View(students);
            
        //}
        public ActionResult Index()
        {
            return View();
        }
    }
}