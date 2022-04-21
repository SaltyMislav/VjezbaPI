using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_PI_Projekt
{
    public partial class FrmProjekt : Form
    {
        private Projekt _projekt;
        public FrmProjekt()
        {
            _projekt = new Projekt();
            InitializeComponent();
            Osvjezi();
        }

        private void Osvjezi()
        {
            txtOznakaTima.Enabled = _projekt.Osnovni_Enabled;
            txtOpisProjekta.Enabled = _projekt.Osnovni_Enabled;
            btnZabiljeziTemu.Enabled = _projekt.Osnovni_Enabled;

            dtpDatumPredaje.Enabled = _projekt.Predaja_Enabled;
            btnPredajProjekt.Enabled = _projekt.Predaja_Enabled;

            btnOdbijProjekt.Enabled = _projekt.Provjera_Enabled;
            btnPrihvatiProjekt.Enabled = _projekt.Provjera_Enabled;

            dtpDatumObrane.Enabled = _projekt.Obrana_Enabled;
            btnZakaziObranu.Enabled = _projekt.Obrana_Enabled;

            btnOznaciKaoObranjen.Enabled = _projekt.Obranjen_Enabled;

            txtStatus.Text = _projekt.TrenutnoStanje.ToString();

            Application.DoEvents();
        }

        private void FrmProjekt_Load(object sender, EventArgs e)
        {
            txtStatus.Text = _projekt.TrenutnoStanje.ToString();
        }

        private void btnZabiljeziTemu_Click(object sender, EventArgs e)
        {
            _projekt.ZabiljeziTemu(txtOpisProjekta.Text, txtOznakaTima.Text);
            txtStatus.Text = _projekt.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnPredajProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PredajProjekt(dtpDatumPredaje.Value);
            txtStatus.Text = _projekt.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnOdbijProjekt_Click(object sender, EventArgs e)
        {
            _projekt.OdbijProjekt();
            txtStatus.Text = _projekt.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnPrihvatiProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PrihvatiProjekt();
            txtStatus.Text = _projekt.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnZakaziObranu_Click(object sender, EventArgs e)
        {
            _projekt.ZakažiObranu(dtpDatumObrane.Value);
            txtStatus.Text = _projekt.TrenutnoStanje.ToString();
            Osvjezi();
        }

        private void btnOznaciKaoObranjen_Click(object sender, EventArgs e)
        {
            _projekt.OznačiKaoObranjen();
            txtStatus.Text = _projekt.TrenutnoStanje.ToString();
            Osvjezi();
        }
    }
}
