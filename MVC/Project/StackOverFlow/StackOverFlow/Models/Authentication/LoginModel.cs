using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StackOverFlow.Models.Authentication
{
    public class LoginModel
    {
        [Display(Name ="UserName")]
        [Required(ErrorMessage ="UserName is Required")]
        public string UserName {get;set;}

        [Display(Name ="Password")]
        [Required(ErrorMessage ="Password is Required")]
        public string Password { get; set; }
    }
}