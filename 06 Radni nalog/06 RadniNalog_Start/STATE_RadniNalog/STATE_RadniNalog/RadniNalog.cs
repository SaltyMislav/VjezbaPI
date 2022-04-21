using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RadniNalog
{
    partial class RadniNalog
    {
        public string Opis { get; set; }
        public DateTime DatumKreiranja { get; set; }
        public DateTime DatumPredaje { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumDovrsetka { get; set; }
        public bool Osnovni_Enabled { get { return TrenutacnoStanje == Stanje.Kreiran; } }
        public bool Otkazi_Enabled { get { return TrenutacnoStanje == Stanje.Zakljucan; } }
        public bool Predaja_Enabled { get { return TrenutacnoStanje == Stanje.Zakljucan; } }
        public bool Zapocni_Enabled { get { return TrenutacnoStanje == Stanje.PredanUProizvodnju; } }
        public bool Dovrsi_Enabled { get { return TrenutacnoStanje == Stanje.ZapocetaProizvodnja; } }
        public RadniNalog()
        {
            DefinirajMatricuStanja();
        }
    }
}
