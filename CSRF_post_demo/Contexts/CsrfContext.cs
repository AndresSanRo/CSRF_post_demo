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
        public CsrfContext() : base("name=homeConnStr") { }
        public DbSet<User> Users { get; set; }
    }
}