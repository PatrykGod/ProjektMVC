using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NowaBiblioteka.Models
{
    public class Egzemplarz
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdEgzemplarz { get; set; }

        [Required]
        [Display(Name = "Numer Ewidencyjny:")]
        [MaxLength(50, ErrorMessage = "Zbyt długa nazwa.")]
        public string numerEwid { get; set; }

        [Required]
        [Display(Name = "Kod Kreskowy:")]
        [MaxLength(50, ErrorMessage = "Zbyt długa nazwa.")]
        public string kodKreskowy { get; set; }

        [Required]
        [Display(Name = "Uwagi:")]
        public string Uwagi { get; set; }

        [Display(Name = "Wydanie egzemplarza:")]
        public int IdWydanie { get; set; }
        public virtual Wydanie Wydanie { get; set; }

        public virtual ICollection<Wypozyczenie> Wypozyczenie { get; set; }

    }
}