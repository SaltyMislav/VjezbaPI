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
            TemaNijePrijavljena,
            TemaPrijavljena,
            TemaPrihvacena,
            PredanaPrvaFaza,
            PredanProjekt,
            ProjektOcijenjen
        }
        public enum Dogadaj
        {
            ZabiljeziTemu,
            TemaPrijavljena,
            PrihatiTemu,
            OdbijTemu,
            PredajPrvuFazu,
            PredajCijeliProjekt,
            OcijeniProjekt
        }

        public Stanje TrenutacnoStanje { get; set; }
        public Action[,] strojStanja;

        public void ObradiDogadaj (Dogadaj dogadaj)
        {
            strojStanja[(int)TrenutacnoStanje, (int)dogadaj].Invoke();
        }

        public void DefinirajMatricuStanja()
        {
            TrenutacnoStanje = Stanje.TemaNijePrijavljena;
            strojStanja = new Action[6, 7]
            {
                //Zabiljezi temu    TemaPrijavljena     PrihvatiTemu    OdbijTemu       PredajPrvuFazu      PredajCijeliProjekt     OcijeniProjekt
                {Zabiljezi,         null,               null,           null,           null,               null,                   null },//TemaNijePrijavljen
                {null,              null,               PrihvatiTemu,   OdbijTemu,      null,               null,                   null },//TemaPrijavljena
                {null,              null,               null,           null,           PrvaFaza,           null,                   null },//TemaPrihvacena
                {null,              null,               null,           null,           null,               CijeliProjekt,          null },//PredanaPrvaFaza
                {null,              null,               null,           null,           null,               null,                   Ocjena },//PredanProjekt
                {null,              null,               null,           null,           null,               null,                   null }//ProjektOcijenjen
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
            TrenutacnoStanje = Stanje.TemaPrijavljena;
        }

        public void PredajPrvuFazu(DateTime datumPredaje)
        {
            DatumPredajePrveFaze = datumPredaje;
            ObradiDogadaj(Dogadaj.PredajPrvuFazu);
        }

        public void PrvaFaza()
        {
            TrenutacnoStanje = Stanje.PredanaPrvaFaza;
        }

        public void OdbijTemu()
        {
            TrenutacnoStanje = Stanje.TemaNijePrijavljena;
        }

        public void PrihvatiTemu()
        {
            TrenutacnoStanje = Stanje.TemaPrihvacena;
        }

        public void PredajCijeliProjekt(DateTime datumObrane)
        {
            DatumPredajeCijelogProjekta = datumObrane;
            ObradiDogadaj(Dogadaj.PredajCijeliProjekt);
        }

        public void CijeliProjekt()
        {
            TrenutacnoStanje = Stanje.PredanProjekt;
        }

        public void OcijeniProjekt(int brojBodova)
        {
            BrojBodova = brojBodova;
            ObradiDogadaj (Dogadaj.OcijeniProjekt);
        }

        public void Ocjena()
        {
            TrenutacnoStanje = Stanje.ProjektOcijenjen;
        }
    }
}
