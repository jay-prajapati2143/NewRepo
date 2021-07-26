using Internationalizationdemo.LocalResource;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Internationalizationdemo.Models
{
    public class Person
    {
        [Display(Name = "First Name", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource),ErrorMessageResourceName = "ReqFName")]
        public string FirstName { get; set; }
        [Display(Name ="LastName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "ReqLName")]
        public string LastName { get; set; }
        [Display(Name = "Age",ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "ReqAge")]
        public int Age { get; set; }
        [Display(Name = "Email", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "ReqEmail")]
        [RegularExpression(".+@.\\..",ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "InvalidEmail")]
        public string Email { get; set; }
        
        public string Biography { get; set; }
    }
}