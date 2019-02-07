using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace NowaBiblioteka.Models
{
    public class Uzytkownik : IdentityUser
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdUzytk { get; set; }

        [Display(Name = "Imię użytkownika:")]
        [MaxLength(20)]
        public string Imie { get; set; }

        [Display(Name = "Nazwisko użytkownika:")]
        [MaxLength(20)]
        public string Nazwisko { get; set; }

        [Display(Name = "Numer Legitymacji:")]
        [MaxLength(20)]
        public string nrLegitymacji { get; set; }

        [Display(Name = "Numer pracownika:")]
        [MaxLength(20)]
        public string nrPracownika { get; set; }

        [Display(Name = "Klasa:")]
        [MaxLength(20)]
        public string Klasa { get; set; }

        public virtual ICollection<Wypozyczenie> Wypozyczenie { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<Uzytkownik> manager)
        {
            // Element authenticationType musi pasować do elementu zdefiniowanego w elemencie CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Dodaj tutaj niestandardowe oświadczenia użytkownika
            return userIdentity;
        }
    }
}