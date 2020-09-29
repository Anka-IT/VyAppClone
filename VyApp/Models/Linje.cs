using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VyApp.Models
{
    public class Linje
    {
        [Display(Name="Linje")]
        public string linjeNavn { get; set; }
        [Display(Name = "Avreise fra")]
        public string avreisestasjon { get; set; }
        [Display(Name = "Ankomst til")]
        public string ankomststasjon { get; set; }
        [Display(Name = "Reise tid (min)")]
        public int tid { get; set; }
        [Display(Name = "Reise lengde (km)")]
        public int lengde { get; set; }
    }
}