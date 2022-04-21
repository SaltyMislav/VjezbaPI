using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Dishwasher
{
    partial class Perilica
    {
        public string NazivPerilice { get; set; }
        public ProgramRada Program { get; set; }
        public bool On_Enabled { get { return TrenutacnoStanje == Stanje.Ugasena || TrenutacnoStanje == Stanje.UMirovanju; } }
        public bool Program_Enabled { get { return TrenutacnoStanje == Stanje.UMirovanju; } }
        public bool Start_Enabled { get { return TrenutacnoStanje == Stanje.OdabranProgram; } }
        public bool Nastavi_Enabled { get { return TrenutacnoStanje == Stanje.PranjeUToku || TrenutacnoStanje == Stanje.Pauzirano; } }
        public bool Zavrsilo_Enabled { get { return TrenutacnoStanje == Stanje.PranjeUToku; } }


        public Perilica()
        {
            NazivPerilice = "BOSCH GDS3429";
            DefinirajMatricuStanja();
        }
    }
}
