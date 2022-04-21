using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_Oven
{
    public partial class FrmPecnica : Form
    {
        Pecnica _pecnica;
        public FrmPecnica()
        {
            _pecnica = new Pecnica();
            InitializeComponent();
            Osvjezi();
        }

        private void Osvjezi()
        {
            btnOnOff.Enabled = _pecnica.OnOff_Enabled;

            btn150C.Enabled = _pecnica.Program_enabled;
            btn180C.Enabled = _pecnica.Program_enabled;
            btn200C.Enabled = _pecnica.Program_enabled;

            btnStart.Enabled = _pecnica.Start_Enabled;

            btnIstekloVrijeme.Enabled = _pecnica.Isteklo_enabled;

            btnOhladiPecnicu.Enabled = _pecnica.Ohladi_enabled;

            txtStatus.Text = _pecnica.TrenutnoStanje.ToString();

            Application.DoEvents();
        }

        private void FrmPerilica_Load(object sender, EventArgs e)
        {

        }



        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if(_pecnica.TrenutnoStanje == Pecnica.Stanje.Ugasena)
            {
                _pecnica.Upali();
            }
            else
            {
                _pecnica.Ugasi();
            }
            Osvjezi();
        }

        private void btn150C_Click(object sender, EventArgs e)
        {
            _pecnica.OdaberiProgram(ProgramRada.Pečenje_150C);
            Osvjezi();
        }

        private void btn180C_Click(object sender, EventArgs e)
        {
            _pecnica.OdaberiProgram(ProgramRada.Pečenje_180C);
            Osvjezi();
        }

        private void btn200C_Click(object sender, EventArgs e)
        {
            _pecnica.OdaberiProgram(ProgramRada.Pečenje_200C);
            Osvjezi();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _pecnica.ZapocniPecenje();
            Osvjezi();
        }

        private void btnIstekloVrijeme_Click(object sender, EventArgs e)
        {
            _pecnica.OznaciKaoZavrseno();
            Osvjezi();
        }

        private void btnOhladiPecnicu_Click(object sender, EventArgs e)
        {
            _pecnica.OhladiPecnicu();
            Osvjezi();
        }
    }
}
