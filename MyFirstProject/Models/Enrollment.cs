using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstProject.Models
{
    public class Enrollment
    {
        [Required]
        [Key]
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public decimal? Grade { get; set; }
        [ForeignKey("StudentId")]
        public Student student { get; set; }
        [ForeignKey("CourseId")]
        public Course course { get; set; }
    }
}
