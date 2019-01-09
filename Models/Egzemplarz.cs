using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Egzemplarz
    {
        public Egzemplarz()
        {
            this.Egzemplarz = new HashSet<Egzemplarz>();
        }
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

        public virtual ICollection<Egzemplarz> Egzemplarz { get; set; }

    }
}