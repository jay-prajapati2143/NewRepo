﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuthenticationDemo.Models.Authetication
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext() : base("name=SqlConnection")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}