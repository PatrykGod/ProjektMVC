using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class User_Role
    {
        
        [Key]
        [Display(Name = "User Rrole:")]
        public int IdUserRole { get; set; }
        [Required]
        [Display(Name = "Rola:")]
        public string Rola { get; set; }
    }
}