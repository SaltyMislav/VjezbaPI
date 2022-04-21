using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Oven
{
    partial class Pecnica
    {
        public string NazivPecnice { get; set; }
        public ProgramRada Program { get; set; }
        public bool OnOff_Enabled { get { return TrenutnoStanje == Stanje.Ugasena || TrenutnoStanje == Stanje.Upaljena || TrenutnoStanje == Stanje.HladenjeGotovo; } }
        public bool Program_enabled { get { return TrenutnoStanje == Stanje.Upaljena || TrenutnoStanje == Stanje.PecenjeZapocelo; } }
        public bool Start_Enabled { get { return TrenutnoStanje == Stanje.ProgramOdabran; } }
        public bool Isteklo_enabled { get { return TrenutnoStanje == Stanje.PecenjeZapocelo; } }
        public bool Ohladi_enabled { get { return TrenutnoStanje == Stanje.PecenjeZavrsilo; } }
        public Pecnica()
        {
            NazivPecnice = "Electrolux 14232";
            DefinirajMatricuStanja();
        }
    }
}
