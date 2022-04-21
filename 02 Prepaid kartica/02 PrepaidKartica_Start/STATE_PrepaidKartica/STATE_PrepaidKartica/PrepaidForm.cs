using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_PrepaidKartica
{
    public partial class PrepaidForm : Form
    {
        private PrepaidKartica _kartica;
        public PrepaidForm()
        {
            _kartica = new PrepaidKartica("HR12312414213");
            InitializeComponent();
            Osvjezi();
        }

        private void PrepaidForm_Load(object sender, EventArgs e)
        {
            
            txtSerijskiBroj.Text = _kartica.SerijskiBroj;
        }

        private void Osvjezi()
        {
            txtIznosUplate.Enabled = _kartica.Uplati_Enabled;
            btnUplati.Enabled = _kartica.Uplati_Enabled;

            txtIznosIsplate.Enabled = _kartica.Isplati_Enabled;
            btnIsplati.Enabled = _kartica.Isplati_Enabled;

            btnAktiviraj.Enabled = _kartica.Aktiviraj_Enabled;
            
            txtIznos.Text = _kartica.Iznos.ToString();
            txtStatus.Text = _kartica.TrenutnoStanje.ToString();

            Application.DoEvents();
        }

        private void btnAktiviraj_Click(object sender, EventArgs e)
        {
            _kartica.Aktiviraj();
            _kartica.ObradiDogadaj(PrepaidKartica.Dogadaji.ProdajaKartice);
            Osvjezi();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            double iznosUplate = double.Parse(txtIznosUplate.Text);
            _kartica.Uplati(iznosUplate);
            txtIznosUplate.Clear();
            _kartica.ObradiDogadaj(PrepaidKartica.Dogadaji.UplacenaSredstva);
            Osvjezi();
        }

        private void btnIsplati_Click(object sender, EventArgs e)
        {
            double iznosIsplate = double.Parse(txtIznosIsplate.Text);
            _kartica.Isplati(iznosIsplate);
            txtIznosIsplate.Clear();
            _kartica.ObradiDogadaj(PrepaidKartica.Dogadaji.ImaSredstva);
            _kartica.ObradiDogadaj(PrepaidKartica.Dogadaji.NemaSredstva);
            Osvjezi();
        }
    }
}
