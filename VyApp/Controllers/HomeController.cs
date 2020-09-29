using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using VyApp.Models;

namespace VyApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Forside()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Forside(string frastasjon, string tilstasjon, string tid, string dato)
        {
            var db = new DBvytog();
            List <Pris> pris= db.hentRute(frastasjon,tilstasjon,tid,dato);
            //List<Avgang> avganger = db.hentAvganger();
            DateTime date = DateTime.Parse(dato);
            int ukedag = (int) date.DayOfWeek;
            ViewBag.frastasjon = frastasjon;
            ViewBag.tilstasjon = tilstasjon;
            ViewBag.tid = tid;
            ViewBag.dato = dato;
            ViewBag.pris = pris;
            return View("VisRute");
        }
        // GET: Home
        public ActionResult ListLinjer()
        {
            var db = new DBvytog();
            List<Linje> alleLinjer =  db.alleLinjer();
            return View(alleLinjer);
        }

        public ActionResult NyLinje()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NyLinje(Linje innLinje)
        {

            var db = new DBvytog();
            bool OK = db.lagreLinje(innLinje);
            if (OK)
            {
                return RedirectToAction("ListLinjer");
            }
            return View();
        }

        // GET: Home
        public ActionResult Detaljer(string id)
        {
            var db = new DBvytog();
            List<Stasjon> stasjoner = db.hentLinje(id);
            return View(stasjoner);
        }

        public string hentAlleStasjoner(string sok)
        {
            var db = new DBvytog();
            List<string> stasjoner = db.hentAlleStasjoner(sok);
            string tekst = "";
            foreach (string st in stasjoner)
            {
                tekst += "<li>" + st + "</li>";
            }
            //var jsonSerializer = new JavaScriptSerializer();
            //string json = jsonSerializer.Serialize(stasjoner);
            return tekst;
        }
    }
}