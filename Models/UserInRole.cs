using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class UserInRole
    {
        public UserInRole()
        {
           this.Uzytkownik = new HashSet<Uzytkownik>();
           this.User_Role = new HashSet<User_Role>();
        }
        [Key]
        [Display(Name = "UserInRole:")]
        public int IdUIR { get; set; }

        public virtual ICollection<Uzytkownik> Uzytkownik { get; set; }
        public virtual ICollection<User_Role> User_Role { get; set; }
    }
}