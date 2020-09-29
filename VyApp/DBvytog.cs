using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VyApp.Models;

namespace VyApp
{
    //Her er funksjonene som kjører mot databasen og henter ut informasjon
    public class DBvytog
    {
        //Henter ut liste med alle toglinjer
        public List<Linje> alleLinjer()
        {
            using (var db = new DatabaseContext())
            {
                List<Linje> alleLinjer = db.Linjer.Select(l => new Linje
                {
                    linjeNavn = l.LinjeNavn,
                    tid = l.Ankomststasjon.Tid,
                    lengde = l.Ankomststasjon.Distanse,
                    avreisestasjon = l.Avreisestasjon.StasjonsNavn,
                    ankomststasjon = l.Ankomststasjon.StasjonsNavn
                }).ToList();

            return alleLinjer;
            }
        }

        //Lagrer ny toglinje
        public bool lagreLinje(Linje innLinje)
        {
            using (var db = new DatabaseContext())
            {
                try
                {
                    var nyLinjeRad = new Linjer();
                    nyLinjeRad.LinjeNavn = innLinje.linjeNavn;

                    //Sjekker om avreisestasjonen eksisterer allerede
                    var sjekkStasjon = db.Stasjoner.FirstOrDefault(s => ((s.StasjonsNavn == innLinje.avreisestasjon) && (s.LinjeNavn == innLinje.linjeNavn)));
                    if (sjekkStasjon == null)
                    {
                        var stasjonsRad = new Stasjoner();
                        stasjonsRad.StasjonsNavn = innLinje.avreisestasjon;
                        stasjonsRad.Tid = 0;
                        stasjonsRad.Distanse = 0;
                        stasjonsRad.LinjeNavn = innLinje.linjeNavn;
                        nyLinjeRad.Avreisestasjon = stasjonsRad;
                    }
                    else
                    {
                        nyLinjeRad.Avreisestasjon = sjekkStasjon;
                    }

                    //Sjekker om ankomststasjonen (endestasjonen) eksisteter allerede
                    var sjekkStasjon2 = db.Stasjoner.FirstOrDefault(s => ((s.StasjonsNavn == innLinje.ankomststasjon) && (s.LinjeNavn == innLinje.linjeNavn)));
                    if (sjekkStasjon2 == null)
                    {
                        var stasjonsRad = new Stasjoner();
                        stasjonsRad.StasjonsNavn = innLinje.ankomststasjon;
                        stasjonsRad.Tid = innLinje.tid;
                        stasjonsRad.Distanse = innLinje.lengde;
                        stasjonsRad.LinjeNavn = innLinje.linjeNavn;
                        nyLinjeRad.Ankomststasjon = stasjonsRad;
                    }
                    else
                    {
                        nyLinjeRad.Ankomststasjon = sjekkStasjon2;
                    }

                    db.Linjer.Add(nyLinjeRad);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception feil)
                {
                    return false;
                }
            }
        }

        //Henter ut liste med alle stasjoner på en toglinje
        public List<Stasjon> hentLinje(string linjenavn)
        {
            using (var db = new DatabaseContext())
            {
                    List<Stasjon> stasjoner= db.Stasjoner.Where(s => s.LinjeNavn == linjenavn).Select(s => new Stasjon
                    {
                        id = s.Id,
                        linjeNavn = s.LinjeNavn,
                        stasjonsNavn = s.StasjonsNavn,
                        distanse= s.Distanse,
                        tid= s.Tid,
                        spor = s.Spor
                    }).OrderBy(s=>s.tid).ToList();
                    return stasjoner;
            }
        }
        //Henter ut liste med stasjoner for ajax-kallet på forsiden.  
        public List<string> hentAlleStasjoner(string sok)
        {
            using (var db = new DatabaseContext())
            {
                List <string> stasjoner = db.Stasjoner.Where(s => s.StasjonsNavn.ToLower().Contains(sok.ToLower())).Select(s => s.StasjonsNavn).Distinct().ToList();
                return stasjoner;
            }
        }
        //Henter ut liste med avganger for valgt strektning
        public List <Pris> hentRute(string fra, string til,string tid, string dato)
        {
            using (var db = new DatabaseContext())
            {
                List <int> frastasjoner= db.Stasjoner.Where(s => s.StasjonsNavn== fra).Select(s => s.Id).ToList();
                List <int> tilstasjoner= db.Stasjoner.Where(s => s.StasjonsNavn== til).Select(s => s.Id).ToList();
                DateTime date= DateTime.Parse(dato);
                

                List <Pris> pris = db.Priser.Where(s => (frastasjoner.Contains(s.FraStasjon.Id))&&(tilstasjoner.Contains(s.TilStasjon.Id))&&(s.FraStasjon.Tid<s.TilStasjon.Tid) && (s.FraStasjon.LinjeNavn == s.TilStasjon.LinjeNavn)).Select(p => new Pris
                {
                    id=p.Id,
                    linjeNavn=p.FraStasjon.LinjeNavn,
                    fraStasjon=p.FraStasjon.StasjonsNavn,
                    tilStasjon=p.TilStasjon.StasjonsNavn,
                    voksen=p.Voksen,
                    barn=p.Barn,
                    student=p.Student,
                    ungdom=p.Ungdom,
                    honnor=p.Honnor,
                    verneplikt=p.Verneplikt
                }).ToList();
                return pris;
            }
        }


    }
}