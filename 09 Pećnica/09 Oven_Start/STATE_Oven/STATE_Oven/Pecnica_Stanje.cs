using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Oven
{
    partial class Pecnica
    {
        public enum Stanje
        {
            Ugasena,
            Upaljena,
            ProgramOdabran,
            PecenjeZapocelo,
            PecenjeZavrsilo,
            HladenjeGotovo
        }
        public enum Dogadaj
        {
            Upali,
            Ugasi,
            Odaberi,
            ZapocniPecenje,
            OznaciKaoZavrseno,
            OhladiPecnicu
        }

        public Stanje TrenutnoStanje { get; set; }
        public Action[,] strojStanja;

        public void ObradiDogadaj (Dogadaj dogadaj)
        {
            strojStanja[(int)TrenutnoStanje, (int)dogadaj].Invoke();
        }

        public void DefinirajMatricuStanja()
        {
            TrenutnoStanje = Stanje.Ugasena;
            strojStanja = new Action[6, 6]
            {
                //Upali Ugasi   OdaberiProgram  ZapocniPecenje  OznaciKaoZavrseno   OhladiPecnicu
                {Upali, null,   null,           null,           null,               null },//Ugasena
                {null,  Ugasi,  Odaberi,        null,           null,               null },//Upaljena
                {null,  null,   null,           ZapocniPecenje, null,               null },//ProgramOdabran
                {null,  null,   Odaberi,        null,           OznaciKaoZavrseno,  null },//PecenjeZapocelo
                {null,  null,   null,           null,           null,               OhladiPecnicu },//PecenjeZavrsilo
                {null,  Ugasi,  null,           null,           null,               null }//HladenjeGotovo
            };
        }
        public void Upali()
        {
            TrenutnoStanje = Stanje.Upaljena;
        }

        public void Ugasi()
        {
            TrenutnoStanje = Stanje.Ugasena;
        }

        public void OdaberiProgram(ProgramRada program)
        {
            Program = program;
            ObradiDogadaj(Dogadaj.Odaberi);
        }

        public void Odaberi()
        {
            TrenutnoStanje = Stanje.ProgramOdabran;
        }

        public void ZapocniPecenje()
        {
            TrenutnoStanje = Stanje.PecenjeZapocelo;
        }

        public void OznaciKaoZavrseno()
        {
            TrenutnoStanje = Stanje.PecenjeZavrsilo;
        }

        public void OhladiPecnicu()
        {
            TrenutnoStanje = Stanje.HladenjeGotovo;
        }
    }
}
