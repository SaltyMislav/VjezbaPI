using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    partial class PrepaidKartica
    {
        public enum Stanje
        {
            NijeAktivna,
            Aktivna,
            NemaSredstava
        }
        public enum Dogadaji
        {
            ProdajaKartice,
            UplacenaSredstva,
            ImaSredstva,
            NemaSredstva
        }

        public Stanje TrenutnoStanje { get; set; }
        public Action[,] strojStanja;

        public void ObradiDogadaj(Dogadaji dogadaji)
        {
            this.strojStanja[(int)this.TrenutnoStanje, (int)dogadaji].Invoke();
        }

        private void DefinirajMatricuPrijelaza ()
        {
            TrenutnoStanje = Stanje.NijeAktivna;

            strojStanja = new Action[3, 4]
            {
                //Prodaja kartice   Uplacena sredstva   Ima sredstva     Nema sredstva
                {ProdajaKartice,    null,               null,              null},  //Nije aktivna
                {null,              UplacenaSredstva,   ImaSredstva,       NemaSredstva}, //Aktivna
                {null,              UplacenaSredstva,   null,              null} //Nema sredstva
            };
        }

        private void ProdajaKartice()
        {
            TrenutnoStanje = Stanje.Aktivna;
        }

        private void UplacenaSredstva()
        {
            TrenutnoStanje = Stanje.Aktivna;
        }
        private void ImaSredstva()
        {
            TrenutnoStanje = Stanje.Aktivna;
        }
        private void NemaSredstva()
        {
            if (Iznos < 0)
            {
                TrenutnoStanje = Stanje.NemaSredstava;
            }
            else
            {
                TrenutnoStanje = Stanje.Aktivna;
            }
        }
    }
}
