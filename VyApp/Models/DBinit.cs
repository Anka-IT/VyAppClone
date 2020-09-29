using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VyApp.Models
{
    public class DBinit : DropCreateDatabaseAlways<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var nySt1 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Kongsberg", Tid = 0, Distanse = 0, Spor = 1 };
            var nySt2 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Darbu", Tid = 12, Distanse = 16, Spor = 1 };
            var nySt3 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Vestfossen", Tid = 18, Distanse = 24, Spor = 1 };
            var nySt4 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Hokksund", Tid = 24, Distanse = 32, Spor = 1 };
            var nySt5 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Steinberg", Tid = 27, Distanse = 36, Spor = 1 };
            var nySt6 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Mjøndalen", Tid = 30, Distanse = 40, Spor = 1 };
            var nySt7 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Gulskogen", Tid = 37, Distanse = 49, Spor = 1 };
            var nySt8 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Drammen", Tid = 41, Distanse = 54, Spor = 1 };
            var nySt9 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Asker", Tid = 54, Distanse = 72, Spor = 1 };
            var nySt10 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Sandvika", Tid = 60, Distanse = 80, Spor = 1 };
            var nySt11 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Lysaker", Tid = 66, Distanse = 88, Spor = 1 };
            var nySt12 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Skøyen", Tid = 69, Distanse = 92, Spor = 1 };
            var nySt13 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Nationaltheatret", Tid = 73, Distanse = 97, Spor = 1 };
            var nySt14 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Oslo S", Tid = 77, Distanse = 102, Spor = 1 };
            var nySt15 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Lillestrøm", Tid = 90, Distanse = 120, Spor = 1 };
            var nySt16 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Oslo Lufthavn", Tid = 103, Distanse = 137, Spor = 1 };
            var nySt17 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Eidsvoll Verk", Tid = 110, Distanse = 146, Spor = 1 };
            var nySt18 = new Stasjoner { LinjeNavn = "L12", StasjonsNavn = "Eidsvoll", Tid = 116, Distanse = 155, Spor = 1 };
            var nySt19 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Kongsberg", Tid = 116, Distanse = 155, Spor = 1 };
            var nySt20 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Darbu", Tid = 104, Distanse = 138, Spor = 1 };
            var nySt21 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Vestfossen", Tid = 98, Distanse = 130, Spor = 1 };
            var nySt22 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Hokksund", Tid = 92, Distanse = 122, Spor = 1 };
            var nySt23 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Steinberg", Tid = 89, Distanse = 118, Spor = 1 };
            var nySt24 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Mjøndalen", Tid = 86, Distanse = 114, Spor = 1 };
            var nySt25 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Gulskogen", Tid = 79, Distanse = 105, Spor = 1 };
            var nySt26 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Drammen", Tid = 75, Distanse = 100, Spor = 1 };
            var nySt27 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Asker", Tid = 62, Distanse = 82, Spor = 1 };
            var nySt28 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Sandvika", Tid = 56, Distanse = 74, Spor = 1 };
            var nySt29 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Lysaker", Tid = 50, Distanse = 66, Spor = 1 };
            var nySt30 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Skøyen", Tid = 47, Distanse = 62, Spor = 1 };
            var nySt31 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Nationaltheatret", Tid = 43, Distanse = 57, Spor = 1 };
            var nySt32 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Oslo S", Tid = 39, Distanse = 52, Spor = 1 };
            var nySt33 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Lillestrøm", Tid = 26, Distanse = 34, Spor = 1 };
            var nySt34 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Oslo Lufthavn", Tid = 13, Distanse = 17, Spor = 1 };
            var nySt35 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Eidsvoll Verk", Tid = 6, Distanse = 8, Spor = 1 };
            var nySt36 = new Stasjoner { LinjeNavn = "L12R", StasjonsNavn = "Eidsvoll", Tid = 0, Distanse = 0, Spor = 1 };
            var stasjoner = new List<Stasjoner>();
            stasjoner.Add(nySt1);
            stasjoner.Add(nySt2);
            stasjoner.Add(nySt3);
            stasjoner.Add(nySt4);
            stasjoner.Add(nySt5);
            stasjoner.Add(nySt6);
            stasjoner.Add(nySt7);
            stasjoner.Add(nySt8);
            stasjoner.Add(nySt9);
            stasjoner.Add(nySt10);
            stasjoner.Add(nySt11);
            stasjoner.Add(nySt12);
            stasjoner.Add(nySt13);
            stasjoner.Add(nySt14);
            stasjoner.Add(nySt15);
            stasjoner.Add(nySt16);
            stasjoner.Add(nySt17);
            stasjoner.Add(nySt18);
            stasjoner.Add(nySt19);
            stasjoner.Add(nySt20);
            stasjoner.Add(nySt21);
            stasjoner.Add(nySt22);
            stasjoner.Add(nySt23);
            stasjoner.Add(nySt24);
            stasjoner.Add(nySt25);
            stasjoner.Add(nySt26);
            stasjoner.Add(nySt27);
            stasjoner.Add(nySt28);
            stasjoner.Add(nySt29);
            stasjoner.Add(nySt30);
            stasjoner.Add(nySt31);
            stasjoner.Add(nySt32);
            stasjoner.Add(nySt33);
            stasjoner.Add(nySt34);
            stasjoner.Add(nySt35);
            stasjoner.Add(nySt36);

            foreach (Stasjoner stasjonfra in stasjoner)
            {
                foreach (Stasjoner stasjontil in stasjoner)
                {
                    if (stasjonfra.StasjonsNavn != stasjontil.StasjonsNavn)
                    {
                        int prisVoksen = Math.Abs((stasjonfra.Tid - stasjontil.Tid)*2)+25;
                        int prisStudent = (int) Math.Round(prisVoksen * 0.75, 0);
                        int prisBarn = (int) Math.Round(prisVoksen *0.5, 0);
                        int prisHonnor = (int) Math.Round(prisVoksen *0.5, 0);
                        int prisUngdom = (int) Math.Round(prisVoksen *0.5, 0);
                        int prisVernepliktig = (int) Math.Round(prisVoksen *0.1,0);
                        var nyPris1 = new Priser { Voksen = prisVoksen, Barn=prisBarn , Ungdom = prisUngdom,Student=prisStudent, Honnor=prisHonnor, Verneplikt=prisVernepliktig, FraStasjon=stasjonfra,TilStasjon=stasjontil};
                        context.Priser.Add(nyPris1);
                    }
                }
            }



            var nyLinje1 = new Linjer { LinjeNavn = "L12", Avreisestasjon = nySt1, Ankomststasjon = nySt18 };
            var nyLinje2 = new Linjer { LinjeNavn = "L12R", Avreisestasjon = nySt36, Ankomststasjon = nySt19 };

            var avganger = new List<Avganger>();
            for (int i = 1; i < 8; i++)
            {
                int jstart = 4;
                if (i > 5) { jstart = 5; }

                for (int j = jstart; j < 23; j++)
                {
                    var avgang = new Avganger { LinjeNavn = nyLinje1, Ukedag = i, Time = j, Minutter = 34 };
                    var avgang2 = new Avganger { LinjeNavn = nyLinje2, Ukedag = i, Time = j + 1, Minutter = 30 };
                    avganger.Add(avgang);
                    avganger.Add(avgang2);
                }
            }
            context.Stasjoner.Add(nySt1);
            context.Stasjoner.Add(nySt2);
            context.Stasjoner.Add(nySt3);
            context.Stasjoner.Add(nySt4);
            context.Stasjoner.Add(nySt5);
            context.Stasjoner.Add(nySt6);
            context.Stasjoner.Add(nySt7);
            context.Stasjoner.Add(nySt8);
            context.Stasjoner.Add(nySt9);
            context.Stasjoner.Add(nySt10);
            context.Stasjoner.Add(nySt11);
            context.Stasjoner.Add(nySt12);
            context.Stasjoner.Add(nySt13);
            context.Stasjoner.Add(nySt14);
            context.Stasjoner.Add(nySt15);
            context.Stasjoner.Add(nySt16);
            context.Stasjoner.Add(nySt17);
            context.Stasjoner.Add(nySt18);
            context.Stasjoner.Add(nySt19);
            context.Stasjoner.Add(nySt20);
            context.Stasjoner.Add(nySt21);
            context.Stasjoner.Add(nySt22);
            context.Stasjoner.Add(nySt23);
            context.Stasjoner.Add(nySt24);
            context.Stasjoner.Add(nySt25);
            context.Stasjoner.Add(nySt26);
            context.Stasjoner.Add(nySt27);
            context.Stasjoner.Add(nySt28);
            context.Stasjoner.Add(nySt29);
            context.Stasjoner.Add(nySt30);
            context.Stasjoner.Add(nySt31);
            context.Stasjoner.Add(nySt32);
            context.Stasjoner.Add(nySt33);
            context.Stasjoner.Add(nySt34);
            context.Stasjoner.Add(nySt35);
            context.Stasjoner.Add(nySt36);

            context.Linjer.Add(nyLinje1);
            context.Linjer.Add(nyLinje2);
            foreach (Avganger avgang in avganger)
            {
                context.Avganger.Add(avgang);
            }
            base.Seed(context);
        }
    }
}