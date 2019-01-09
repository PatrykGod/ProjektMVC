using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Tworca
    {
        public Tworca()
        {
            this.Autorzy = new HashSet<Autorzy>();
        }
        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdAutorzy { get; set; }

        [Required]
        [Display(Name = "Imię:")]
        [MaxLength(50, ErrorMessage = "Zbyt długa nazwa.")]
        public string Imie { get; set; }

        [Required]
        [Display(Name = "Nazwisko:")]
        [MaxLength(100, ErrorMessage = "Zbyt długa nazwa.")]
        public string Nazwisko { get; set; }

        public virtual ICollection<Autorzy> Autorzy { get; set; }
    }
}