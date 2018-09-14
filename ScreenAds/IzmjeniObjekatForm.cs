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
    public partial class IzmjeniObjekatForm : Form
    {
        
        ObjekatByID_Result objekat = new ObjekatByID_Result();
        public IzmjeniObjekatForm(int ObjekatID)
        {
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();
            try
            {

                objekat = ObjektiDB.ObjekatByID(ObjekatID);
            }
            catch
            {
                
            }
        }

        private void IzmjeniObjekatForm_Load(object sender, EventArgs e)
        {
            ucitajpodatke();
        }

        private void ucitajpodatke()
        {

            try
            {
                textBoxNaziv.Text = objekat.NazivObjekta;
                textBox2.Text = objekat.AdresaObjekta;
                textBoxKontaktOsoba.Text = objekat.KontaktOsoba;
                textBoxKontaktTelefon.Text = objekat.KontaktTelefon;
                comboBoxTip.DataSource = TipoviObjektaDB.SviTipoviCombo();
                comboBoxTip.ValueMember = "TipObjektaID";
                comboBoxTip.DisplayMember = "Naziv";
                comboBoxTip.SelectedIndex = comboBoxTip.FindStringExact(objekat.TipObjekta);
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                ObjektiDB.ObrisiObjekat(objekat.ObjekatID);
                this.Close();

            }
            catch {
                MessageBox.Show("Dogodila se greška,molimo pokušajte ponovo");
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    ObjektiDB.IzmjeniObjekat(textBoxNaziv.Text.Trim(), textBox2.Text.Trim(), Convert.ToInt32(comboBoxTip.SelectedValue), objekat.ObjekatID, textBoxKontaktOsoba.Text.Trim(), textBoxKontaktTelefon.Text.Trim());
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Dogodila se greška molimo pokušajte ponovo");
                }
            }
            
           
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNaziv.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNaziv, "Molimo dodajte naziv objekta");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxNaziv, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider2.SetError(textBox2, "Molimo dodajte adresu objekta");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox2, "");
            }
        }

        private void comboBoxTip_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxTip.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider3.SetError(comboBoxTip,"Molimo odaberite objekat");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(comboBoxTip, "");
            }
        }

        private void textBoxKontaktOsoba_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxKontaktOsoba.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider4.SetError(textBoxKontaktOsoba, "Molimo dodajte kontakt osobu");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(textBoxKontaktOsoba, "");
            }
        }

        private void textBoxKontaktTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxKontaktTelefon.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider5.SetError(textBoxKontaktTelefon, "Molimo dodajte kontakt telefon");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(textBoxKontaktTelefon, "");
            }
        }
    }
}
