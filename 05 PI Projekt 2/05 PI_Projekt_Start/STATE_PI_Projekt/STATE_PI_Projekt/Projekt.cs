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
        public DateTime DatumPredajePrveFaze { get; set; }
        public DateTime DatumPredajeCijelogProjekta { get; set; }
        public int BrojBodova { get; set; }

        public bool Oznaka_Enabled { get { return TrenutacnoStanje == Stanje.TemaNijePrijavljena; } }
        public bool Opis_Enabled { get { return TrenutacnoStanje == Stanje.TemaNijePrijavljena; } }
        public bool Zabiljezi_Enabled { get { return TrenutacnoStanje == Stanje.TemaNijePrijavljena; } }
        public bool Odbij_Enabled { get { return TrenutacnoStanje == Stanje.TemaPrijavljena; } }
        public bool Prihvati_Enabled { get { return TrenutacnoStanje == Stanje.TemaPrijavljena; } }
        public bool Predaja1_Enabled { get { return TrenutacnoStanje == Stanje.TemaPrihvacena; } }
        public bool PredajaSve_Enabled { get { return TrenutacnoStanje == Stanje.PredanaPrvaFaza; } }
        public bool Ocjena_Enabled { get { return TrenutacnoStanje == Stanje.PredanProjekt; } }
        public Projekt()
        {
            DefinirajMatricuStanja();
        }
    }
}
