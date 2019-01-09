using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Wydawnictwo
    {
        public Wydawnictwo()
        {
           this.Wydanie = new HashSet<Wydanie>();
        }
        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdKategorii { get; set; }

        [Required]
        [Display(Name = "Nazwa wydawnictwa:")]
        [MaxLength(255, ErrorMessage = "Zbyt długa nazwa.")]
        public string NazwaWydawnictwa { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Skrót")]
        public string Skrot { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Kraj")]
        public string Kraj { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Miejscowość")]
        public string Miejscowosc { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Kod pocztowy")]
        public string kodPocztowy { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Ulica")]
        public string Ulica { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Numer Telefonu")]
        public string numerTelefonu { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "E-mail")]
        public string eMail { get; set; }

        [Required]
        [MaxLength(15, ErrorMessage = "Strona WWW")]
        public string stronaWWW { get; set; }


        public virtual ICollection<Wydanie> Wydanie { get; set; }
    }
}