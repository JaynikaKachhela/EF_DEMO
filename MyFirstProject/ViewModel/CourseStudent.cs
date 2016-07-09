using MyFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstProject.ViewModel
{
    public class CourseStudent
    {
        public Course course { get; set; }
        public List<Student> students { get; set; }
    }
}