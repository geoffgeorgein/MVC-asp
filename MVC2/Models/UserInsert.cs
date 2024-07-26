using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC2.Models
{
    public class UserInsert


    {
        public int sId { get; set; }
        public string sName { get; set; }
        public List<CheckBoxListHelper> MyFavoriteQual { get; set; }

        public string[] selectedQual{get;set;}

        [Required(ErrorMessage = "Enter the name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter the age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Enter the address")]
        public string Address { get; set; }

        [EmailAddress(ErrorMessage = "Enter the  email address")]
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Photo { get; set; }
        public string State { get; set; }
        public string Qual{ get; set; }
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter the password")]
        public string Pwd{ get; set; }
        [Compare("Pwd", ErrorMessage = "Mismatch")]
        public string CPassword { get; set; }

        
    }

    public class stclass
    {
        public int SId { get; set; }
        public string Sname { get; set; }
        
    }

    public class CheckBoxListHelper
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public bool IsChecked { get; set; }
    }
}