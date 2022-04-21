using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    partial class Vozilo
    {
        public enum Stanje
        {
            Raspolziv,
            UKvaru,
            Rezerviran,
            UUporabi,
            NaPregledu
        }
        public enum Dogadaj
        {
            Kvar,
            PopravljenKvar,
            KlijentZatrazioVozilo,
            KlijentStigaoPoAuto,
            KlijentVracaAuto,
            VoziloSpremnoZaUporabu
        }

        public Stanje TrenutnoStanje { get; set; }
        private Action[,] StrojStanja;

        public void ObradiDogadaj (Dogadaj dogadaj)
        {
            this.StrojStanja[(int)this.TrenutnoStanje, (int)dogadaj].Invoke();
        }

        private void DodajMatricuStanja()
        {
            TrenutnoStanje = Stanje.Raspolziv;
            this.StrojStanja = new Action[5, 6]
            {
                {Kvar,      null,           KlijentZatrazioVozilo,  null,                   null,               null },
                {null,      PopravljenKvar, null,                   null,                   null,               null },
                {null,      null,           null,                   KlijentStigaoPoAuto,    null,               null },
                {null,      null,           null,                   null,                   KlijentVracaAuto,   null },
                {null,      null,           null,                   null,                   null,               VoziloSpremnoZaUpotrebu }
            };
        }
        private void Kvar()
        {
            TrenutnoStanje = Stanje.UKvaru;
        }
        private void PopravljenKvar()
        {
            TrenutnoStanje = Stanje.Raspolziv;
        }
        private void KlijentZatrazioVozilo()
        {
            TrenutnoStanje = Stanje.Rezerviran;
        }
        private void KlijentStigaoPoAuto()
        {
            TrenutnoStanje = Stanje.UUporabi;
        }
        private void KlijentVracaAuto()
        {
            TrenutnoStanje = Stanje.NaPregledu;
        }
        private void VoziloSpremnoZaUpotrebu()
        {
            TrenutnoStanje = Stanje.Raspolziv;
        }
    }
}
