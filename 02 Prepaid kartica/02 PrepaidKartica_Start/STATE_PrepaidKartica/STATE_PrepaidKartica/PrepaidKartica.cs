using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PrepaidKartica
{
    partial class PrepaidKartica
    {
        public string SerijskiBroj { get; set; }
        public double Iznos { get; set; }
        public bool Uplati_Enabled { get { return TrenutnoStanje == Stanje.NemaSredstava || TrenutnoStanje == Stanje.Aktivna; } }
        public bool Isplati_Enabled { get { return TrenutnoStanje == Stanje.Aktivna; } }
        public bool Aktiviraj_Enabled { get { return TrenutnoStanje == Stanje.NijeAktivna;} }
        public PrepaidKartica(string serijskiBroj)
        {
            SerijskiBroj = serijskiBroj;
            DefinirajMatricuPrijelaza();
        }

        public void Aktiviraj()
        {
            Iznos = 100;
        }

        public void Uplati(double iznosUplate)
        {
            Iznos += iznosUplate;
        }

        internal void Isplati(double iznosIsplate)
        {
            Iznos -= iznosIsplate;
        }
    }
}
