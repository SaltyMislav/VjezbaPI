using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Reklamacija
{
    partial class Reklamacija
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public string Agent { get; private set; }

        public bool Osnovno_Enabled { get { return TrenutnoStanje == Stanje.Podnesena; } }
        public bool Obrada_Enabled { get { return TrenutnoStanje == Stanje.URazmatranju; } }
        public bool Zalba_Enabled { get { return TrenutnoStanje == Stanje.Odbijena; } }
        public Reklamacija()
        {
            DefinirajMatricuStanja();
        }

        public void DodijeliAgenta(string agent)
        {
            Agent = agent;
            ObradiDogadaj(Dogadaj.Dodijeli);
        }

        public void Prihvati()
        {
            TrenutnoStanje = Stanje.Uvazena;
            PosaljiObavijest("Vaša reklamacija je uvažena.");
        }

        private void PosaljiObavijest(string poruka)
        {
            System.Windows.Forms.MessageBox.Show(poruka);
        }

        public void Odbij()
        {
            TrenutnoStanje = Stanje.Odbijena;
            PosaljiObavijest("Vaša reklamacija je odbijena. Imate 3 dana za žalbu na tu odluku.");
        }

        public void KonačnoOdbij()
        {
            TrenutnoStanje = Stanje.KonacnoOdbijena;
            PosaljiObavijest("Vaša reklamacija je konačno odbijena. Više nemate mogućnost žalbe.");
        }

        public void VratiUPostupak()
        {
            TrenutnoStanje = Stanje.Podnesena;
        }
    }
}
