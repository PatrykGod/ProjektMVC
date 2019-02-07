using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NowaBiblioteka.Models
{
    public class Tworca
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdTworca { get; set; }

        [Required]
        [Display(Name = "Imię:")]
        [MaxLength(50, ErrorMessage = "Zbyt długa nazwa.")]
        public string Imie { get; set; }

        [Required]
        [Display(Name = "Nazwisko:")]
        [MaxLength(100, ErrorMessage = "Zbyt długa nazwa.")]
        public string Nazwisko { get; set; }

        public virtual ICollection<Ksiazka> Ksiazka { get; set; }
    }
}