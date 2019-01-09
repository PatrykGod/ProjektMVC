using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka.Models
{
    public class Wypozyczenie
    {      
        public string Wypozyczający_ID { get; set; }
        public string Pracownik_ID { get; set; }
        
        [ForeignKey("Wypozyczający_ID")]
        public virtual Uzytkownik Wypozyczający { get; set; }

        [ForeignKey("Pracownik_ID")]
        public virtual Uzytkownik Pracownik { get; set; }

    }
}