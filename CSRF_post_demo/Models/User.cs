using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSRF_post_demo.Models
{
    //This class maps the users of the application
    [Table("CSRFUSER")]
    public class User
    {
        [Key]
        [Column("CSRF_ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Column("CSRF_USERNAME")]
        public string Name { get; set; }
        [Column("CSRF_USERPASSWORD")]
        public string Password { get; set; }
    }
}