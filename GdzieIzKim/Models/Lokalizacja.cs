using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GdzieIzKim.Models
{
    public class Lokalizacja
    {
        public int LokalizacjaId { get; set; }
        public string nazwa { get; set; }
        public string adres { get; set; }
    }
}