using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage ="StudentName is Required")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        
        [Required(ErrorMessage ="Age is required")]
        public int Age { get; set; }

        
        public Standard standard { get; set; }
        
    }
}