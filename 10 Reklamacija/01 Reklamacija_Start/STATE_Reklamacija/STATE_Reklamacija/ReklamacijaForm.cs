using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_Reklamacija
{
    public partial class ReklamacijaForm : Form
    {
        private Reklamacija _reklamacija;
        public ReklamacijaForm()
        {
            _reklamacija = new Reklamacija
            {
                Id = 1112,
                Opis = "Tablet je stigao sa puknutim ekranom..."
            };
            InitializeComponent();
            Osvjezi();
        }

        private void Osvjezi()
        {
            txtIdReklamacije.Enabled = _reklamacija.Osnovno_Enabled;
            txtOpisReklamacije.Enabled = _reklamacija.Osnovno_Enabled;
            txtAgent.Enabled = _reklamacija.Osnovno_Enabled;
            btnDodijeliAgenta.Enabled = _reklamacija.Osnovno_Enabled;

            radOpravdana.Enabled = _reklamacija.Obrada_Enabled;
            rbNeutemeljen.Enabled = _reklamacija.Obrada_Enabled;
            btnOcijeni.Enabled = _reklamacija.Obrada_Enabled;

            rbPristigla.Enabled = _reklamacija.Zalba_Enabled;
            rbNijePristigla.Enabled = _reklamacija.Zalba_Enabled;
            btnObradiŽalbu.Enabled = _reklamacija.Zalba_Enabled;

            txtStatusReklamacije.Text = _reklamacija.TrenutnoStanje.ToString();

            Application.DoEvents();
        }

        private void ReklamacijaForm_Load(object sender, EventArgs e)
        {
            txtIdReklamacije.Text = _reklamacija.Id.ToString();
            txtOpisReklamacije.Text = _reklamacija.Opis;
            Osvjezi();
        }

        private void btnDodijeliAgenta_Click(object sender, EventArgs e)
        {
            _reklamacija.DodijeliAgenta(txtAgent.Text);
            Osvjezi();
        }

        private void btnOcijeni_Click(object sender, EventArgs e)
        {
            if (radOpravdana.Checked == true)
            {
                _reklamacija.Prihvati();
            }
            else
            {
                _reklamacija.Odbij();
            }
            Osvjezi();
        }

        private void btnObradiŽalbu_Click(object sender, EventArgs e)
        {
            if (rbPristigla.Checked == true)
            {
                _reklamacija.VratiUPostupak();
            }
            else
            {
                _reklamacija.KonačnoOdbij();
            }
            Osvjezi();
        }
    }
}
