using CSRF_post_demo.Contexts;
using CSRF_post_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSRF_post_demo.Repositories
{    
    public class RepositoryUser
    {
        CsrfContext Context;
        public RepositoryUser()
        {
            Context = new CsrfContext();
        }
        public User ExistsUser(string user, string password )
        {
            var existingUser = (from data in Context.Users
                          where data.Name.Equals(user)
                          && data.Password.Equals(password)
                          select data).FirstOrDefault();
            return existingUser;
        }
    }
}