using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Dishwasher
{
    partial class Perilica
    {

        public enum Stanje
        {
            Ugasena,
            UMirovanju,
            OdabranProgram,
            PranjeUToku,
            Pauzirano
        }

        public enum Dogadaj
        {
            Upali,
            Odaberi,
            Zapocni,
            Pauziraj,
            Nastavi,
            Oznaci,
            Ugasi
        }

        public Stanje TrenutacnoStanje { get; set; }
        public Action[,] strojStanja;

        public void ObradiDogadaj(Dogadaj dogadaj)
        {
            strojStanja[(int)TrenutacnoStanje, (int)dogadaj].Invoke();
        }

        public void DefinirajMatricuStanja()
        {
            TrenutacnoStanje = Stanje.Ugasena;
            strojStanja = new Action[5, 7]
            {
                //Upali     Odaberi     Zapocni         Pauziraj            Nastavi         Oznaci                  Ugasi
                {Upali,     null,       null,           null,               null,           null,                   null },//Ugasena
                {null,      Odaberi,    null,           null,               null,           null,                   Ugasi },//UMirovanju
                {null,      null,       ZapocniPranje,  null,               null,           null,                   null },//OdabranProgram
                {null,      null,       null,           PauzirajPranje,     null,           OznaciPranjeZavrsilo,   null },//PranjeUToku
                {null,      null,       null,           null,               NastaviPranje,  null,                   null }//Pauziran
            };
        }

        public void Upali()
        {
            TrenutacnoStanje = Stanje.UMirovanju;
        }

        public void Ugasi()
        {
            TrenutacnoStanje = Stanje.Ugasena;
        }

        public void OdaberiProgram(ProgramRada odabraniProgram)
        {
            Program = odabraniProgram;
            ObradiDogadaj(Dogadaj.Odaberi);
        }
        public void Odaberi()
        {
            TrenutacnoStanje = Stanje.OdabranProgram;
        }

        public void ZapocniPranje()
        {
            TrenutacnoStanje = Stanje.PranjeUToku;
        }

        public void OznaciPranjeZavrsilo()
        {
            TrenutacnoStanje = Stanje.UMirovanju;
        }

        public void PauzirajPranje()
        {
            TrenutacnoStanje = Stanje.Pauzirano;
        }

        public void NastaviPranje()
        {
            TrenutacnoStanje = Stanje.PranjeUToku;
        }
    }
}
