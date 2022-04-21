using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_PI_Projekt
{
    partial class Projekt
    {
        public string OpisTeme { get; set; }
        public string OznakaTima { get; set; }
        public DateTime DatumPredaje { get; set; }
        public DateTime DatumObrane { get; set; }

        public bool Osnovni_Enabled { get { return TrenutnoStanje == Stanje.NijePrijavljenaTema; } }
        public bool Predaja_Enabled { get { return TrenutnoStanje == Stanje.TemaPrijavljena; } }
        public bool Provjera_Enabled { get { return TrenutnoStanje == Stanje.PredanProjekt; } }
        public bool Obrana_Enabled { get { return TrenutnoStanje == Stanje.PrihvacenProjekt; } }
        public bool Obranjen_Enabled { get { return TrenutnoStanje == Stanje.ZakazanaObrana; } }
        public Projekt()
        {
            DefinirajMatricuStanja();
        }
    }
}
