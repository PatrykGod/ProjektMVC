using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Biblioteka.Models
{
    public class Autorzy
    {
        public string Tworca_ID { get; set; }
        public string Ksiazka_ID { get; set; }

        [ForeignKey("Tworca_ID")]
        public virtual Tworca Tworca { get; set; }

        [ForeignKey("Ksiazka_ID")]
        public virtual Ksiazka Ksiazka { get; set; }
    }
}