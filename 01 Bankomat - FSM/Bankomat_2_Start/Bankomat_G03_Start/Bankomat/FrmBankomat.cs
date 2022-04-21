using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Bankomat.Bankomat;

namespace Bankomat
{
    public partial class frmBankomat : Form
    {
        Bankomat bankomat;

        public frmBankomat()
        {
            InitializeComponent();
            bankomat = new Bankomat();
            OsvjeziSucelje();
        }

        private void OsvjeziSucelje()
        {
            btnKartica.Enabled = bankomat.Kartica_Enabled;

            lblPin.Enabled = bankomat.Pin_Enabled;
            txtPin.Enabled = bankomat.Pin_Enabled;
            btnPin.Enabled = bankomat.Pin_Enabled;

            lblIznos.Enabled = bankomat.Iznos_Enabled;
            txtIznos.Enabled = bankomat.Iznos_Enabled;
            btnIznos.Enabled = bankomat.Iznos_Enabled;

            lblIspravanPIN.Visible = bankomat.Pin_Enabled;
            lblIspravanPIN2.Visible = bankomat.Pin_Enabled;
            lblIspravanPIN2.Text = bankomat.IspravanPin.ToString();

            lblMaxIznos.Visible = bankomat.Iznos_Enabled;
            lblMaxIznos2.Visible = bankomat.Iznos_Enabled;
            lblMaxIznos2.Text = bankomat.MaxIznos.ToString("N2");

            btnOdustani.Enabled = bankomat.Odustani_Enabled;
            btnIsplati.Enabled = bankomat.Isplata_Enabled;

            lblStanje.Text = bankomat.TrenutnoStanje.ToString();

            Application.DoEvents();
        }

        private void btnKartica_Click(object sender, EventArgs e)
        {
            bankomat.ObradiDogadjaj(Dogadjaj.KARTICA_UMETNUTA);
            OsvjeziSucelje();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            bankomat.ObradiDogadjaj(Dogadjaj.PIN_UNESEN);
            OsvjeziSucelje();
        }

        private void btnIznos_Click(object sender, EventArgs e)
        {
            bankomat.ObradiDogadjaj(Dogadjaj.IZNOS_UNESEN);
            OsvjeziSucelje();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            bankomat.ObradiDogadjaj(Dogadjaj.ODUSTANI);
            OsvjeziSucelje();
        }

        private void btnIsplati_Click(object sender, EventArgs e)
        {
            bankomat.ObradiDogadjaj(Dogadjaj.ISPLATA_GOTOVA);
            OsvjeziSucelje();
        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {
            int pin = 0;
            int.TryParse(txtPin.Text, out pin);
            bankomat.Pin = pin;
        }

        private void txtIznos_TextChanged(object sender, EventArgs e)
        {
            float iznos = 0;
            float.TryParse(txtIznos.Text, out iznos);
            bankomat.Iznos = iznos;
        }
    }
}
