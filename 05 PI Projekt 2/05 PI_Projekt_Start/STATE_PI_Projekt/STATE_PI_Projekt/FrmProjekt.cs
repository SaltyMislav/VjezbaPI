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
            txtOznakaTima.Enabled = _projekt.Oznaka_Enabled;
            txtOpisTeme.Enabled = _projekt.Opis_Enabled;

            btnZabiljeziTemu.Enabled = _projekt.Zabiljezi_Enabled;

            btnOdbijTemu.Enabled = _projekt.Odbij_Enabled;
            btnPrihvatiTemu.Enabled = _projekt.Prihvati_Enabled;

            btnPredajPrvuFazu.Enabled = _projekt.Predaja1_Enabled;
            dtpDatumPrveFaze.Enabled = _projekt.Predaja1_Enabled;

            btnPredajCijeliProjekt.Enabled = _projekt.PredajaSve_Enabled;
            dtpDatumPredajeCijelogProjekta.Enabled = _projekt.PredajaSve_Enabled;

            txtBrojBodova.Enabled = _projekt.Ocjena_Enabled;
            btnOcijeniProjekt.Enabled = _projekt.Ocjena_Enabled;

            txtStatus.Text = _projekt.TrenutacnoStanje.ToString();

            Application.DoEvents();
        }

        private void FrmProjekt_Load(object sender, EventArgs e)
        {

        }

        private void btnZabiljeziTemu_Click(object sender, EventArgs e)
        {
            _projekt.ZabiljeziTemu(txtOpisTeme.Text, txtOznakaTima.Text);
            Osvjezi();
        }

        private void btnPredajPrvuFazu_Click(object sender, EventArgs e)
        {
            _projekt.PredajPrvuFazu(dtpDatumPrveFaze.Value);
            Osvjezi();
        }

        private void btnOdbijTemu_Click(object sender, EventArgs e)
        {
            _projekt.OdbijTemu();
            Osvjezi();
        }

        private void btnPrihvatiTemu_Click(object sender, EventArgs e)
        {
            _projekt.PrihvatiTemu();
            Osvjezi();
        }

        private void btnPredajCijeliProjekt_Click(object sender, EventArgs e)
        {
            _projekt.PredajCijeliProjekt(dtpDatumPredajeCijelogProjekta.Value);
            Osvjezi();
        }

        private void btnOcijeni_Click(object sender, EventArgs e)
        {
            _projekt.OcijeniProjekt(int.Parse(txtBrojBodova.Text));
            Osvjezi();
        }
    }
}
