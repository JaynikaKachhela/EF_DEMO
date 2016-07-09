using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstProject.Models
{
    public class Student
    {
        [Key]
        [Required]
        public int StudentId { get; set; }
        public string LastName{ get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}