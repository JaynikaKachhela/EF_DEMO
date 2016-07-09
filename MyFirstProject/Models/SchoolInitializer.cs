using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstProject.Models
{
    public class SchoolInitializer :DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
                new Student { FirstName="Jaynika",LastName="Kachhela",EnrollmentDate=DateTime.Parse("2015-08-08")},
                new Student { FirstName="Mittal",LastName="Parmar",EnrollmentDate=DateTime.Parse("2016-01-08")},
                new Student { FirstName="Hiren",LastName="Kachhela",EnrollmentDate=DateTime.Parse("2013-03-08")}
            };
            foreach (var s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course { Name="Java",TotalCredits=5 },
                new Course { Name=".net",TotalCredits=3 }
            };
            foreach (var c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment { CourseId=2,StudentId=1,Grade=4 },
                new Enrollment { CourseId=1,StudentId=3,Grade=3 },
                new Enrollment { CourseId=1,StudentId=2,Grade=5 },
                new Enrollment { CourseId=2,StudentId=3,Grade=2 }
            };
            foreach (var e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();

        }
    }
}