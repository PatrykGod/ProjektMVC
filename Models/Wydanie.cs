using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Wydanie
    {
        public Wydanie()
        {
            this.Egzemplarz = new HashSet<Egzemplarz>();
        }

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

        [Required]
        [Display(Name = "Zdjęcie:")]
        [MaxLength(255, ErrorMessage = "Zbyt długa nazwa.")]
        public string zdjecieNazwa { get; set; }

        public virtual ICollection<Egzemplarz> Egzemplarz { get; set; }
    }
}