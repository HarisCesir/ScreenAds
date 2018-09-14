using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenAds;
namespace ScreenAds
{
    public partial class ScreenAdsmain : Form
    {
        public ScreenAdsmain()
        {
            InitializeComponent();
        }

        private void ScreenAdsmain_Load(object sender, EventArgs e)
        {

        }

        private void gradoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradoviForm frm = new GradoviForm();
            frm.Show();

        }

        private void tipoviObjekataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoviObjekata frm = new TipoviObjekata();
            frm.Show();
        }

        private void televizijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelevizijeForm frm = new TelevizijeForm();
            frm.Show();
        }

        private void objektiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjektiForm frm = new ObjektiForm();
            frm.Show();
        }

        private void paketiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaketiForm frm = new PaketiForm();
            frm.Show();
        }

        private void klijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KlijentiForm frm = new KlijentiForm();
            frm.Show();

        }

        private void reklameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReklameForm frm = new ReklameForm();
            frm.Show();
        }

        private void marketingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MarketingFrm frm = new MarketingFrm();
            frm.Show();
        }

        private void androidUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AndroidUpdateFrm frm = new AndroidUpdateFrm();
            frm.Show();
        }

        private void errorAndroidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorAndroidForm frm = new errorAndroidForm();
            frm.Show();
        }
    }
}
