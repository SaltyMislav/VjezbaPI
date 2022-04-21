using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_ServisniZahtjev
{
    public partial class FrmServisniZahtjev : Form
    {
        private ServisniZahtjev _servisniZahtjev;
        public FrmServisniZahtjev()
        {
            _servisniZahtjev = new ServisniZahtjev();
            InitializeComponent();
            Osvjezi();
        }

        public void Osvjezi()
        {
            dtpDatumIzrade.Enabled = _servisniZahtjev.Osnovni_Enabled;
            txtOpisKvara.Enabled = _servisniZahtjev.Osnovni_Enabled;
            btnPodnesiZahtjev.Enabled = _servisniZahtjev.Osnovni_Enabled;

            btnOdbijZahtjev.Enabled = _servisniZahtjev.Zaprimanje_Enabled;

            dtpDatumZaprimanja.Enabled = _servisniZahtjev.Zaprimanje_Enabled;
            btnZaprimiZahtjev.Enabled = _servisniZahtjev.Zaprimanje_Enabled;

            dtpDatumPocetka.Enabled = _servisniZahtjev.Pocetak_Enabled;
            btnZapocniServisiranje.Enabled = _servisniZahtjev.Pocetak_Enabled;

            dtpDatumZatvaranja.Enabled = _servisniZahtjev.Zavrsetak_Enabled;
            btnZatvoriZahtjev.Enabled = _servisniZahtjev.Zavrsetak_Enabled;

            txtStatusZahtjeva.Text = _servisniZahtjev.TrenutacnoStanje.ToString();

            Application.DoEvents();

        }

        private void FrmServisniZahtjev_Load(object sender, EventArgs e)
        {

        }

        private void btnPodnesiZahtjev_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.PodnesiZahtjev(txtOpisKvara.Text, dtpDatumIzrade.Value);
            Osvjezi();
        }

        private void btnZaprimiZahtjev_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.ZaprimiZahtjev(dtpDatumZaprimanja.Value);
            Osvjezi();
        }

        private void btnZapocniServisiranje_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.ZapocniServisiranje(dtpDatumPocetka.Value);
            Osvjezi();
        }

        private void btnZatvoriZahtjev_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.ZatvoriZahtjev(dtpDatumZatvaranja.Value);
            Osvjezi();
        }

        private void btnOdbijZahtjev_Click(object sender, EventArgs e)
        {
            _servisniZahtjev.OdbijZahtjev();
            Osvjezi();
        }
    }
}
