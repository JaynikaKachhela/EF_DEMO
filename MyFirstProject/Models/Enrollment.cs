using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyFirstProject.Models
{
    public class Enrollment
    {
        [Required]
        [Key]
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public decimal? Grade { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }
}
