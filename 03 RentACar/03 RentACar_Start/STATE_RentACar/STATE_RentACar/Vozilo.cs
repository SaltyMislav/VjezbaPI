using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATE_RentACar
{
    partial class Vozilo
    {
        public string Registracija { get; set; }
        public string Model { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public DateTime DatumPredavanja { get; set; }
        public string PregledNapravio { get; set; }

        public bool UciniRaspolozivim_Enabled { get { return TrenutnoStanje == Stanje.NaPregledu; } }
        public bool Aktiviraj_Enabled { get { return TrenutnoStanje == Stanje.UKvaru; } }
        public bool Deaktiviraj_Enabled { get { return TrenutnoStanje == Stanje.Raspolziv; } }
        public bool Rezerviraj_Enabled { get { return TrenutnoStanje == Stanje.Raspolziv; } }
        public bool Predaj_Enabled { get { return TrenutnoStanje == Stanje.Rezerviran; } }
        public bool Pregledaj_Enabled { get { return TrenutnoStanje == Stanje.UUporabi; } }

        public Vozilo(string registracija, string model)
        {
            Registracija = registracija;
            Model = model;
            DodajMatricuStanja();
        }

        public void RezervirajVozilo()
        {
            DatumRezervacije = DateTime.Now;
        }

        public void PredajVozilo()
        {
            DatumPredavanja = DateTime.Now;
        }

        public void PregledajVozilo(string pregledNapravio)
        {
            PregledNapravio = pregledNapravio;
        }

        public void AktivirajVozilo()
        {

        }

        public void DeaktivirajVozilo()
        {

        }

        public void UciniRaspolozivim()
        {

        }
    }
}
