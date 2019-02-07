using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NowaBiblioteka.Models
{
    public class Wypozyczenie
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int idWypozyczenie { get; set; }

        public string Wypozyczający_ID { get; set; }
        public string Pracownik_ID { get; set; }

        [ForeignKey("Wypozyczający_ID")]
        public virtual Uzytkownik Wypozyczający { get; set; }

        [ForeignKey("Pracownik_ID")]
        public virtual Uzytkownik Pracownik { get; set; }

        [Display(Name = "Egzemplarz wypożyczenia:")]
        public int IdEgzemplarz { get; set; }
        public virtual Egzemplarz Egzemplarz { get; set; }
    }
}