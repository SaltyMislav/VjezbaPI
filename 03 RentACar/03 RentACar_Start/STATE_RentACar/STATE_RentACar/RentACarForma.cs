using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RentACar
{
    public partial class RentACarForma : Form
    {
        private Vozilo _vozilo;
        public RentACarForma()
        {
            InitializeComponent();
        }

        private void RentACarForma_Load(object sender, EventArgs e)
        {
            _vozilo = new Vozilo("VŽ-100-NO", "Ford focus, 1.6 tdi");

            txtRegistracija.Text = _vozilo.Registracija;
            txtOpisModela.Text = _vozilo.Model;
            Osvjezi();
        }

        private void Osvjezi()
        {
            btnUciniRaspolozivim.Enabled = _vozilo.UciniRaspolozivim_Enabled;

            btnAktivirajVozilo.Enabled = _vozilo.Aktiviraj_Enabled;

            btnDeaktivirajVozilo.Enabled = _vozilo.Deaktiviraj_Enabled;

            btnRezerviraj.Enabled = _vozilo.Rezerviraj_Enabled;

            btnPredaj.Enabled = _vozilo.Predaj_Enabled;

            btnPregledaj.Enabled = _vozilo.Pregledaj_Enabled;

            txtStatusVozila.Text = _vozilo.TrenutnoStanje.ToString();

            Application.DoEvents();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            _vozilo.RezervirajVozilo();
            txtDatumRezervacije.Text = _vozilo.DatumRezervacije.ToString();
            _vozilo.ObradiDogadaj(Vozilo.Dogadaj.KlijentZatrazioVozilo);
            Osvjezi();
        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            _vozilo.PredajVozilo();
            txtDatumPredavanja.Text = _vozilo.DatumPredavanja.ToString();
            _vozilo.ObradiDogadaj(Vozilo.Dogadaj.KlijentStigaoPoAuto);
            Osvjezi();
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            _vozilo.PregledajVozilo(txtPregledNapravio.Text);
            _vozilo.ObradiDogadaj(Vozilo.Dogadaj.KlijentVracaAuto);
            Osvjezi();
        }

        private void btnUciniRaspolozivim_Click(object sender, EventArgs e)
        {
            _vozilo.UciniRaspolozivim();
            _vozilo.ObradiDogadaj(Vozilo.Dogadaj.VoziloSpremnoZaUporabu);
            Osvjezi();
        }

        private void btnAktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.AktivirajVozilo();
            _vozilo.ObradiDogadaj(Vozilo.Dogadaj.PopravljenKvar);
            Osvjezi();
        }

        private void btnDeaktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.DeaktivirajVozilo();
            _vozilo.ObradiDogadaj(Vozilo.Dogadaj.Kvar);
            Osvjezi();
        }
    }
}
    