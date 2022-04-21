using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_Dishwasher
{
    public partial class FrmPerilica : Form
    {
        Perilica _perilica;
        public FrmPerilica()
        {
            _perilica = new Perilica();
            InitializeComponent();
            Osvjezi();
        }

        private void Osvjezi()
        {
            btnOnOff.Enabled = _perilica.On_Enabled;

            btn60min.Enabled = _perilica.Program_Enabled;
            btn90min.Enabled = _perilica.Program_Enabled;
            btn120min.Enabled = _perilica.Program_Enabled;

            btnStart.Enabled = _perilica.Start_Enabled;

            btnPauzirajNastavi.Enabled = _perilica.Nastavi_Enabled;
            
            btnPranjeZavrsilo.Enabled = _perilica.Zavrsilo_Enabled;

            txtStatus.Text = _perilica.TrenutacnoStanje.ToString();

            Application.DoEvents();
        }

        private void FrmPerilica_Load(object sender, EventArgs e)
        {
            
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (_perilica.TrenutacnoStanje == Perilica.Stanje.Ugasena)
            {
                _perilica.Upali();
            }
            else
            {
                _perilica.Ugasi();
            }
            Osvjezi();
        }

        private void btn60min_Click(object sender, EventArgs e)
        {
            _perilica.OdaberiProgram(ProgramRada.Pranje_60min);
            Osvjezi();
        }

        private void btn90min_Click(object sender, EventArgs e)
        {
            _perilica.OdaberiProgram(ProgramRada.Pranje_90min);
            Osvjezi();
        }

        private void btn120min_Click(object sender, EventArgs e)
        {
            _perilica.OdaberiProgram(ProgramRada.Pranje_120min);
            Osvjezi();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _perilica.ZapocniPranje();
            Osvjezi();
        }

        private void btnPauzirajNastavi_Click(object sender, EventArgs e)
        {
            if(_perilica.TrenutacnoStanje == Perilica.Stanje.PranjeUToku)
            {
                _perilica.PauzirajPranje();
            }
            else
            {
                _perilica.NastaviPranje();
            }
            Osvjezi();
        }

        private void btnPranjeZavrsilo_Click(object sender, EventArgs e)
        {
            _perilica.OznaciPranjeZavrsilo();
            Osvjezi();
        }
    }
}
