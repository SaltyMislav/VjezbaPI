using System;
using System.Windows.Forms;

namespace Bankomat
{
    partial class Bankomat
    {
        public float Iznos { get; set; }
        public float MaxIznos  { get; private set; }
        public int Pin { get; set; }
        public int IspravanPin { get; private set; }
        private int Pogreske = 0;

        public bool Kartica_Enabled { get { return TrenutnoStanje == Stanje.Mirovanje; } }
        public bool Pin_Enabled { get { return TrenutnoStanje == Stanje.ProvjeraPina; } }
        public bool Odustani_Enabled { get { return TrenutnoStanje == Stanje.ProvjeraPina || TrenutnoStanje == Stanje.OdabirIznosaZaIsplatu;  } }
        public bool Iznos_Enabled { get { return TrenutnoStanje == Stanje.OdabirIznosaZaIsplatu; } }
        public bool Isplata_Enabled { get { return TrenutnoStanje == Stanje.IsplataGotovine; } }

        public Bankomat()
        {
            //Generate test data
            Random g = new Random();
            IspravanPin = g.Next(1000, 9999);
            MaxIznos = g.Next(100, 1000);

            DefinirajMatricuPrijelazaStanja();
        }
    }
}
