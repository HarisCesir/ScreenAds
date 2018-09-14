using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database;
using Database.Klase;
namespace ScreenAds
{
    public partial class IzmjeneTv : Form
    {
        int TelevizijaID;
        TelevizijaByID_Result tv = new TelevizijaByID_Result();
        public IzmjeneTv(int TvID)
        {
            AutoValidate = AutoValidate.Disable;
            TelevizijaID = TvID;
            try
            {
                tv = TelevizijeDB.TelevizijaByID(TelevizijaID);
            }
            catch
            {

            }
            InitializeComponent();

        }

        private void IzmjeneTv_Load(object sender, EventArgs e)
        {
            bindTV();
        }

        private void bindTV()
        {
            try
            {
                textBoxNaziv.Text = tv.NazivTelevizije;
                bindGrad();
                bindObjekat();
            }
            catch
            {

            }
        }

        private void bindObjekat()
        {
            try
            {
                comboBoxObjekti.DataSource = ObjektiDB.SviObjekti();
                comboBoxObjekti.DisplayMember = "Naziv";
                comboBoxObjekti.ValueMember = "ObjekatID";
                comboBoxObjekti.SelectedIndex = comboBoxObjekti.FindStringExact(tv.NazivObjekta);
            }
            catch
            {

            }
        }

        private void bindGrad()
        {
            try
            {
                comboBoxGradovi.DataSource = GradoviDB.SviGradoviCombo();
                comboBoxGradovi.DisplayMember = "Naziv";
                comboBoxGradovi.ValueMember = "GradID";

                comboBoxGradovi.SelectedIndex = comboBoxGradovi.FindStringExact(tv.NazivGrada);
            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    TelevizijeDB.IzmjeniTV(tv.TelevizijaID, Convert.ToInt32(comboBoxGradovi.SelectedValue), Convert.ToInt32(comboBoxObjekti.SelectedValue));
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Dogodila se greška, molimo pokušajte kasnije");
                }
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TelevizijeDB.ObrisiTvFromPaketiTelevzije(tv.TelevizijaID);
                TelevizijeDB.BrisiTv(tv.TelevizijaID);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
            }
        }

        private void comboBoxGradovi_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxGradovi.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBoxGradovi, "Molimo odaberite grad");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBoxGradovi, "");
            }
        }

        private void comboBoxObjekti_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxObjekti.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider2.SetError(comboBoxObjekti, "Molimo odaberite objekat");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(comboBoxObjekti, "");
            }
        }
    }
}
