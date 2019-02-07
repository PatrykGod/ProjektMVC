using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NowaBiblioteka.Models
{
    public class Wydanie
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdWydanie { get; set; }

        [Required]
        [Display(Name = "ISBN:")]
        [MaxLength(20, ErrorMessage = "Zbyt długa nazwa.")]
        public string ISBN { get; set; }

        [Required]
        [Display(Name = "Rok Wydania:")]
        [MaxLength(4, ErrorMessage = "Zbyt długa nazwa.")]
        public string rokWydania { get; set; }

        [Required]
        [Display(Name = "Numer Wydania:")]
        [MaxLength(20, ErrorMessage = "Zbyt długa nazwa.")]
        public string numerWydania { get; set; }

        [Required]
        [Display(Name = "Liczba Stron:")]
        [MaxLength(20, ErrorMessage = "Zbyt długa nazwa.")]
        public string liczbaStron { get; set; }


        [Display(Name = "Zdjęcie:")]
        public string zdjecieNazwa { get; set; }

        [Display(Name = "Książka wydania:")]
        public int IdKsiazka { get; set; }
        public virtual Ksiazka Ksiazka { get; set; }

        [Display(Name = "Wydawnictwo wydania:")]
        public int IdWydawnictwo { get; set; }
        public virtual Wydawnictwo Wydawanictwo { get; set; }

        public virtual ICollection<Egzemplarz> Egzemplarz { get; set; }

    }
}