using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    partial class Projekt
    {
        public enum Stanje
        {
            NijePrijavljenaTema,
            TemaPrijavljena,
            PredanProjekt,
            PrihvacenProjekt,
            ZakazanaObrana,
            ObranjenProjekt
        }

        public enum Dogadaj
        {
            ZabiljeziTemu,
            PredajProjekt,
            OdbijProjekt,
            PrihvatiProjekt,
            ZakaziObranu,
            OznaciKaoObranjen
        }

        public Stanje TrenutnoStanje { get; set; }
        public Action[,] strojStanja;

        public void ObradiDogadaj (Dogadaj dogadaj)
        {
            strojStanja[(int)TrenutnoStanje, (int)dogadaj].Invoke();
        }

        public void DefinirajMatricuStanja()
        {
            TrenutnoStanje = Stanje.NijePrijavljenaTema;
            strojStanja = new Action[5, 6]
            {
                { Zabiljezi, null, null, null, null, null },
                { null, Predaj, null, null, null, null },
                { null, null, OdbijProjekt, PrihvatiProjekt, null, null },
                { null, null, null, null, Zakazi, null},
                { null, null, null, null, null, OznačiKaoObranjen}
            };
        }
        public void ZabiljeziTemu(string opisTeme, string oznakaTima)
        {
            OpisTeme = opisTeme;
            OznakaTima = oznakaTima;
            ObradiDogadaj(Dogadaj.ZabiljeziTemu);
        }
        public void Zabiljezi()
        {
            TrenutnoStanje = Stanje.TemaPrijavljena;
        }

        public void PredajProjekt(DateTime datumPredaje)
        {
            DatumPredaje = datumPredaje;
            ObradiDogadaj(Dogadaj.PredajProjekt);
        }

        public void Predaj()
        {
            TrenutnoStanje = Stanje.PredanProjekt;
        }

        public void OdbijProjekt()
        {
            TrenutnoStanje = Stanje.TemaPrijavljena;
        }

        public void PrihvatiProjekt()
        {
            TrenutnoStanje = Stanje.PrihvacenProjekt;
        }

        public void ZakažiObranu(DateTime datumObrane)
        {
            DatumObrane = datumObrane;
            ObradiDogadaj(Dogadaj.ZakaziObranu);
        }

        public void Zakazi()
        {
            TrenutnoStanje = Stanje.ZakazanaObrana;
        }

        public void OznačiKaoObranjen()
        {
            TrenutnoStanje = Stanje.ObranjenProjekt;
        }
    }
}
