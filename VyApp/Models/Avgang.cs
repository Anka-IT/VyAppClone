using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VyApp.Models
{
    public class Avgang
    {
        public int id { get; set; }
        public string linjenavn { get; set; }
        public int ukedag { get; set; }
        public int time { get; set; }
        public int minutter { get; set; }

    }
}