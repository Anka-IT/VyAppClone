using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VyApp.Models
{
    public class Pris
    {
        public int id { get; set; }
        public string linjeNavn { get; set; }
        public string fraStasjon { get; set; }
        public string tilStasjon { get; set; }
        public int voksen { get; set; }
        public int barn { get; set; }
        public int student { get; set; }
        public int ungdom { get; set; }
        public int honnor { get; set; }
        public int verneplikt { get; set; }

    }
}