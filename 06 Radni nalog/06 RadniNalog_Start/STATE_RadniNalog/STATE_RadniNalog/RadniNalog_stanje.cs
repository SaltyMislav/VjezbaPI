using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RadniNalog
{
    partial class RadniNalog
    {
        public enum Stanje
        {
            Kreiran,
            Zakljucan,
            PredanUProizvodnju,
            ZapocetaProizvodnja,
            Otkazan,
            DovrsenaProizvodnja
        }

        public enum Dogadaj
        {
            ZakljucajNalog,
            PredajUProizvodnju,
            ZapocniProizvodnju,
            Otkazi,
            DovrsiProizvodnju
        }

        public Stanje TrenutacnoStanje { get; set; }
        public Action[,] strojStanja;

        public void ObradiDogadaj (Dogadaj dogadaj)
        {
            strojStanja[(int) TrenutacnoStanje, (int)dogadaj].Invoke();
        }

        public void DefinirajMatricuStanja()
        {
            TrenutacnoStanje = Stanje.Kreiran;
            strojStanja = new Action[6, 5]
            {
                //ZakljucajNalog    PredajUProizvodnju  ZapocniProizvodnju  Otkazi          DovrsiProizvodnju
                {Zakljucaj,         null,               null,               null,           null },//Kreiran
                {null,              Predaj,             null,               OtkaziNalog,    null },//Zakljucan
                {null,              null,               Zapocni,            null,           null },//PredanUProizvodnju
                {null,              null,               null,               null,           Dovrsi },//ZapocetaProizvodnja
                {null,              null,               null,               null,           null },//Otkazan
                {null,              null,               null,               null,           null }//DovrsenaProizvodnja
            };
        }

        public void ZakljucajNalog(string opis)
        {
            Opis = opis;
            DatumKreiranja = DateTime.Now;
            ObradiDogadaj(Dogadaj.ZakljucajNalog);
        }
        public void Zakljucaj()
        {
            TrenutacnoStanje = Stanje.Zakljucan;
        }

        public void PredajUProizvodnju(DateTime datumPredaje)
        {
            DatumPredaje = DateTime.Now;
            ObradiDogadaj(Dogadaj.PredajUProizvodnju);
        }
        public void Predaj()
        {
            TrenutacnoStanje = Stanje.PredanUProizvodnju;
        }

        public void ZapocniProizvodnju(DateTime datumPocetka)
        {
            DatumPocetka = datumPocetka;
            ObradiDogadaj(Dogadaj.ZapocniProizvodnju);
        }
        public void Zapocni()
        {
            TrenutacnoStanje = Stanje.ZapocetaProizvodnja;
        }

        public void DovrsiProizvodnju(DateTime datumDovrsetka)
        {
            DatumDovrsetka = datumDovrsetka;
            ObradiDogadaj(Dogadaj.DovrsiProizvodnju);
        }
        
        public void Dovrsi()
        {
            TrenutacnoStanje = Stanje.DovrsenaProizvodnja;
        }

        public void OtkaziNalog()
        {
            TrenutacnoStanje = Stanje.Otkazan;
        }
    }
}
