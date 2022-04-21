using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_ServisniZahtjev
{
    partial class ServisniZahtjev
    {
        public string Opis { get; set; }
        public DateTime DatumIzrade { get; set; }
        public DateTime DatumZaprimanja { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZatvaranja { get; set; }
        public DateTime DatumOdbijanja { get; set; }
        public bool Osnovni_Enabled { get { return TrenutacnoStanje == Stanje.UIzradi; } }
        public bool Zaprimanje_Enabled { get { return TrenutacnoStanje == Stanje.Podnesen; } }
        public bool Pocetak_Enabled { get { return TrenutacnoStanje == Stanje.Zaprimljen; } }
        public bool Zavrsetak_Enabled { get { return TrenutacnoStanje == Stanje.UPostupku; } }

        public ServisniZahtjev()
        {
            DefinirajMatricuStanja();
        }
    }
}
