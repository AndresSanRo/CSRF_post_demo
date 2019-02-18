using CSRF_post_demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CSRF_post_demo.Contexts
{
    public class CsrfContext : DbContext
    {
        //Context of the database
        public CsrfContext() : base("name=tjConnStr") { }
        //DbSet to retrieve users
        public DbSet<User> Users { get; set; }
    }
}