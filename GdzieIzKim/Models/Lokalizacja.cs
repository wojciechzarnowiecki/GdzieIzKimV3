using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GdzieIzKim.Models
{
    public class Lokalizacja
    {
        [ScaffoldColumn(false)]
        public int LokalizacjaId { get; set; }
        [Display(Name = "Nazwa")]
        public string nazwa { get; set; }
        [Display(Name = "Adres")]
        public string adres { get; set; }
        [Display(Name = "Opis")]
        public string opis { get; set; }
        [Display(Name ="Z kim?")]
        public string zkim { get; set; }

        //[Display(Name = "Kategoria")]
        //public int KategoriaId { get; set; }
        //public virtual Kategoria Kategoria { get; set; }
    }
}