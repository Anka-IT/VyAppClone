using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VyApp.Models
{
    public class Stasjon
    {
        public int id { get; set; }
        public string linjeNavn { get; set; }
        public string stasjonsNavn { get; set; }
        public int distanse { get; set; }
        public int tid { get; set; }
        public int spor { get; set; }
    }
}