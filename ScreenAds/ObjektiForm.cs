using Database;
using Database.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenAds
{
    public partial class ObjektiForm : Form
    {
        public ObjektiForm()
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            InitializeComponent();
        }

        private void ObjektiForm_Load(object sender, EventArgs e)
        {
            bindTipovi();
            bindObjekti();
        }

        private void bindObjekti()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = ObjektiDB.ObjektiSaTipovima();
            }
            catch
            {

            }
        }

        private void bindTipovi()
        {
            try
            {
                comboBoxTipObjekta.DataSource = TipoviObjektaDB.SviTipoviCombo();
                comboBoxTipObjekta.DisplayMember = "Naziv";
                comboBoxTipObjekta.ValueMember = "TipObjektaID";
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                ObjekatByNaziv_Result objekat = ObjektiDB.ObjekatByNaziv(textBoxNaziv.Text.Trim());

                if(objekat!=null)
                {
                    MessageBox.Show("Objekat sa tim nazivom već postoji");
                }
                else
                {
                    try
                    {
                        Database.Klase.Korisnici.DodajKorisnika(textBoxKorisnickoIme.Text, "Objekat", textBoxLozinka.Text, textBoxAdresa.Text, textBoxNaziv.Text, Convert.ToInt32(comboBoxTipObjekta.SelectedValue), maskedTextBoxKontaktTelefon.Text, textBoxKontaktOsoba.Text);

                        bindObjekti();
                        MessageBox.Show("Uspješno dodano");
                    }
                    catch
                    {
                        MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
                    }
                }

                
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bindObjekti();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxKontaktOsoba.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxKontaktOsoba, "Molimo dodajte kontakt osobu");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxKontaktOsoba, "");
            }
        }

        private void textBoxNaziv_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNaziv.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider2.SetError(textBoxNaziv, "Molimo dodajte naziv objekta");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBoxNaziv, "");
            }
        }

        private void textBoxAdresa_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxAdresa.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider3.SetError(textBoxAdresa, "Molimo dodajte adresu objekta");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(textBoxAdresa, "");
            }
        }

        private void comboBoxTipObjekta_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxTipObjekta.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider4.SetError(comboBoxTipObjekta, "Molimo odaberite tip objekta");
            }
            else
            {
                e.Cancel = false;
                errorProvider4.SetError(comboBoxTipObjekta, "");
            }
        }

        private void maskedTextBoxKontaktTelefon_Validating(object sender, CancelEventArgs e)
        {
            if(maskedTextBoxKontaktTelefon.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider5.SetError(maskedTextBoxKontaktTelefon, "Molimo dodajte kontakt telefon");
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(maskedTextBoxKontaktTelefon, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                int ObjekatID = Convert.ToInt32(value);
               
                ObjektiDB.ObrisiObjekat(ObjekatID);

                bindObjekti();


            }
            catch
            {
                MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                int ObjekatID = Convert.ToInt32(value);

                IzmjeniObjekatForm frm = new IzmjeniObjekatForm(ObjekatID);
                frm.Show();

            }
            catch
            {
                MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
            }

        }
    }
}
