using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_Reklamacija
{
    partial class Reklamacija
    {
        public enum Stanje
        {
            Podnesena,
            URazmatranju,
            Uvazena,
            Odbijena,
            KonacnoOdbijena
        }

        public enum Dogadaj
        {
            Dodijeli,
            Uvazi,
            Odbij,
            Vrati,
            KonacnoOdbij
        }

        public Stanje TrenutnoStanje;
        public Action[,] strojStanja;

        public void ObradiDogadaj (Dogadaj dogadaj)
        {
            strojStanja[(int)TrenutnoStanje, (int)dogadaj].Invoke();
        }

        public void DefinirajMatricuStanja()
        {
            TrenutnoStanje = Stanje.Podnesena;
            strojStanja = new Action[5, 5]
            {
                //Dodijeli  Uvazi       Odbij   Vrati           KonacnoOdbij
                {Dodjeli,   null,       null,   null,           null },//Podnesena
                {null,      Prihvati,   Odbij,  null,           null },//URazmatranju
                {null,      null,       null,   null,           null },//Uvazena
                {null,      null,       null,   VratiUPostupak, KonačnoOdbij },//Odbijena
                {null,      null,       null,   null,           null }//KonacnoOdbijena
            };
        }

        public void Dodjeli()
        {
            TrenutnoStanje = Stanje.URazmatranju;
        }
    }
}
