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
        [Required(ErrorMessage ="Proszę wprowadzić adres, lub słowo kluczowe")]
        public string adres { get; set; }
        [Display(Name = "Opis")]
        public string opis { get; set; }
        [Display(Name ="Z kim?")]
        [Required(ErrorMessage = "Koniecznie wprowadzić jedną z opcji: 1) dzieci 2) zakochani 3) studenci")]
        public string zkim { get; set; }

        //[Display(Name = "Kategoria")]
        //public int KategoriaId { get; set; }
        //public virtual Kategoria Kategoria { get; set; }
    }
}