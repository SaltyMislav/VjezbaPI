using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RadniNalog
{
    public partial class RadniNalogForm : Form
    {
        private RadniNalog _radniNalog;
        public RadniNalogForm()
        {
            _radniNalog = new RadniNalog();
            InitializeComponent();
            Osvjezi();
        }

        public void Osvjezi()
        {
            txtDatumKreiranja.Enabled = _radniNalog.Osnovni_Enabled;
            txtOpis.Enabled = _radniNalog.Osnovni_Enabled;
            btnZakljucaj.Enabled = _radniNalog.Osnovni_Enabled;

            btnOtkaziNalog.Enabled = _radniNalog.Otkazi_Enabled;

            dtpDatumPredaje.Enabled = _radniNalog.Predaja_Enabled;
            btnPredajNalog.Enabled = _radniNalog.Predaja_Enabled;

            dtpDatumPocetka.Enabled = _radniNalog.Zapocni_Enabled;
            btnZapocniProizvodnju.Enabled = _radniNalog.Zapocni_Enabled;

            dtpDatumDovrsetka.Enabled = _radniNalog.Dovrsi_Enabled;
            btnDovrsiProizvodnju.Enabled = _radniNalog.Dovrsi_Enabled;

            txtStatus.Text = _radniNalog.TrenutacnoStanje.ToString();

            Application.DoEvents();
        }

        private void RadniNalogForm_Load(object sender, EventArgs e)
        {
        }

        private void btnZakljucaj_Click(object sender, EventArgs e)
        {
            _radniNalog.ZakljucajNalog(txtOpis.Text);
            txtDatumKreiranja.Text = _radniNalog.DatumKreiranja.ToString();
            Osvjezi();
        }

        private void btnPredajNalog_Click(object sender, EventArgs e)
        {
            _radniNalog.PredajUProizvodnju(dtpDatumPredaje.Value);
            Osvjezi();
        }

        private void btnZapocniProizvodnju_Click(object sender, EventArgs e)
        {
            _radniNalog.ZapocniProizvodnju(dtpDatumPocetka.Value);
            Osvjezi();
        }

        private void btnDovrsiProizvodnju_Click(object sender, EventArgs e)
        {
            _radniNalog.DovrsiProizvodnju(dtpDatumDovrsetka.Value);
            Osvjezi();
        }

        private void btnOtkaziNalog_Click(object sender, EventArgs e)
        {
            _radniNalog.OtkaziNalog();
            Osvjezi();
        }
    }
}
