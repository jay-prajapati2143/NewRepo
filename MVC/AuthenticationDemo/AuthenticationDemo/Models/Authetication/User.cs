﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthenticationDemo.Models.Authetication
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}