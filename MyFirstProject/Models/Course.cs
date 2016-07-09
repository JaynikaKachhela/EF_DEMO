using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFirstProject.Models
{
    public class Course
    {
        [Key]
        [Required]
        public int CourseId { get; set; }
        public string Name { get; set; }
        [MaxLength(5),MinLength(1)]
        public int TotalCredits { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}