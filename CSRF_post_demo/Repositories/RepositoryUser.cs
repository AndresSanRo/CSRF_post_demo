using CSRF_post_demo.Contexts;
using CSRF_post_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSRF_post_demo.Repositories
{    
    //This class provides the functionallity for handleling users to the controllers.
    public class RepositoryUser
    {
        CsrfContext Context;
        public RepositoryUser()
        {
            Context = new CsrfContext();
        }
        /// <summary>
        /// Searchs for a user in the DDBB by the parameters given.
        /// </summary>
        /// <param name="user">string. Users´s name.</param>
        /// <param name="password">string. User´s password</param>
        /// <returns>An user object or null.</returns>
        public User ExistsUser(string user, string password )
        {
            User existingUser = (from data in Context.Users
                          where data.Name.Equals(user)
                          && data.Password.Equals(password)
                          select data).FirstOrDefault();
            return existingUser;
        }
    }
}