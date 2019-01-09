using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Ksiazka
    {
        public Ksiazka()
        {
            this.Wydanie = new HashSet<Wydanie>();
            this.Autorzy = new HashSet<Autorzy>();
        }

        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdKsiazka { get; set; }

        [Required]
        [Display(Name = "Tytuł:")]
        [MaxLength(500, ErrorMessage = "Zbyt długa nazwa.")]
        public string Tytul { get; set; }

        [Required]
        [Display(Name = "UKD:")]
        [MaxLength(50, ErrorMessage = "Zbyt długa nazwa.")]
        public string UKD { get; set; }

        [Required]
        [Display(Name = "Opis:")]
        public string Opis { get; set; }


        public virtual ICollection<Wydanie> Wydanie { get; set; }
        public virtual ICollection<Autorzy> Autorzy { get; set; }
    }
}