using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC2.Models
{
    public class AdminInsertcs
    {



        [Required(ErrorMessage = "Enter the name")]
        public string name { get; set; }
       
        [Required(ErrorMessage = "Enter the address")]
        public string address { get; set; }

        [Required(ErrorMessage = "Enter the Phone")]
        public string phone { get; set; }

        [EmailAddress(ErrorMessage = "Enter the  email address")]
        public string email { get; set; }
     
        public string username { get; set; }

        public string pass { get; set; }

        [Compare("pass", ErrorMessage = "Mismatch")]
        public string cpass{ get; set; }

        public string msg { get; set; }
    }
}