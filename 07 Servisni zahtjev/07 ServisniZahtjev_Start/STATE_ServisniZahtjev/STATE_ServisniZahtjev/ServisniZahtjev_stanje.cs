using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_ServisniZahtjev
{
    partial class ServisniZahtjev
    {
        public enum Stanje
        {
            UIzradi,
            Podnesen,
            Obijen,
            Zaprimljen,
            UPostupku,
            ZahtjevZatvoren
        }
        public enum Dogadaj
        {
            PodnesiZahtjev,
            ZaprimiZahtjev,
            OdbijZahtjev,
            ZapocniServisiranje,
            ZatvoriZahtjev
        }

        public Stanje TrenutacnoStanje { get; set; }
        public Action[,] strojStanja;

        public void ObradiDogadaj (Dogadaj dogadaj)
        {
            strojStanja[(int)TrenutacnoStanje, (int)dogadaj].Invoke();
        }

        public void DefinirajMatricuStanja()
        {
            TrenutacnoStanje = Stanje.UIzradi;
            strojStanja = new Action[6, 5]
            {
                //PodnesiZahtjev    ZaprimiZahtjev  OdbijZahtjev    ZapocniServisiranje ZatvoriZahtjev
                {Podnesi,           null,           null,           null,               null },//UIzradi
                {null,              Zaprimi,        OdbijZahtjev,   null,               null },//Podnesen
                {null,              null,           null,           null,               null },//Odbijen
                {null,              null,           null,           Zapocni,            null },//Zaprimljen
                {null,              null,           null,           null,               Zatvori },//UPostupku
                {null,              null,           null,           null,               null }//ZahtjevZatvoren
            };
        }

        public void PodnesiZahtjev(string opis, DateTime datumIzrade)
        {
            Opis = opis;
            DatumIzrade = datumIzrade;
            ObradiDogadaj(Dogadaj.PodnesiZahtjev);
        }

        public void Podnesi()
        {
            TrenutacnoStanje = Stanje.Podnesen;
        }

        public void ZaprimiZahtjev(DateTime datumZaprimanja)
        {
            DatumZaprimanja = DateTime.Now;
            ObradiDogadaj(Dogadaj.ZaprimiZahtjev);
        }

        public void Zaprimi()
        {
            TrenutacnoStanje = Stanje.Zaprimljen;
        }

        public void ZapocniServisiranje(DateTime datumPocetka)
        {
            DatumPocetka = datumPocetka;
            ObradiDogadaj(Dogadaj.ZapocniServisiranje);
        }
        public void Zapocni()
        {
            TrenutacnoStanje = Stanje.UPostupku;
        }

        internal void ZatvoriZahtjev(DateTime datumDovrsetka)
        {
            DatumZatvaranja = datumDovrsetka;
            ObradiDogadaj(Dogadaj.ZatvoriZahtjev);
        }
        public void Zatvori()
        {
            TrenutacnoStanje = Stanje.ZahtjevZatvoren;
        }

        public void OdbijZahtjev()
        {
            DatumOdbijanja = DateTime.Now;
            TrenutacnoStanje = Stanje.Obijen;
        }
    }
}
