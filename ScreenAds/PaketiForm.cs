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
    public partial class PaketiForm : Form
    {
        public PaketiForm()
        {
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();
            bindPaketi();
            bindTelevizije();
        }

        private void bindTelevizije()
        {
            try
            {
                comboBoxTV.DataSource = TelevizijeDB.TelevizijeCombo();
                comboBoxTV.DisplayMember = "NazivTelevizije";
                comboBoxTV.ValueMember = "TelevizijaID";
            }
            catch
            {

            }
        }

        private void bindPaketi()
        {
            try
            {
                comboBoxPaketiTv.DataSource = PaketiDB.SviPaketi();
                comboBoxPaketiTv.DisplayMember = "Naziv";
                comboBoxPaketiTv.ValueMember = "PaketID";

                comboBoxPaketiTermin.DataSource = PaketiDB.SviPaketi();
                comboBoxPaketiTermin.DisplayMember = "Naziv";
                comboBoxPaketiTermin.ValueMember = "PaketID";

                comboBoxpaketiGrid.DataSource = PaketiDB.SviPaketi();
                comboBoxpaketiGrid.DisplayMember = "Naziv";
                comboBoxpaketiGrid.ValueMember = "PaketID";


                comboBoxPaketiBrisanje.DataSource = PaketiDB.SviPaketi();
                comboBoxPaketiBrisanje.DisplayMember = "Naziv";
                comboBoxPaketiBrisanje.ValueMember = "PaketID";
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {

                Paketi paket = PaketiDB.PaketByNaziv(textBoxNazivPaketa.Text.Trim());

                if(paket!=null)
                {
                    MessageBox.Show("Paket sa unesenim nazivom već postoji");
                }
                else
                {
                    try
                    {
                        PaketiDB.DodajPaket(textBoxNazivPaketa.Text.Trim());
                        bindPaketi();
                        MessageBox.Show("Uspješno dodano");
                    }
                    catch
                    {
                        MessageBox.Show("Dogodila se greška,molimo pokušajte ponovo");
                    }
                }


                
            }

            

        }

        private void PaketiForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                PaketiTelevizije a = PaketiDB.ProvjeraPaketiTelevizije(Convert.ToInt32(comboBoxPaketiTv.SelectedValue), Convert.ToInt32(comboBoxTV.SelectedValue));

                if(a!=null)
                {
                    MessageBox.Show("U odabranom paketu već postoji odabrana televizija");
                }
                else
                {
                    PaketiDB.PaketiTvDodaj(Convert.ToInt32(comboBoxPaketiTv.SelectedValue), Convert.ToInt32(comboBoxTV.SelectedValue));

                    MessageBox.Show("Uspješno dodano");
                }


            }
            catch
            {
                MessageBox.Show("Dogodila se greška,molimo pokušajte ponovo");
            }


            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                PaketiTermini t = PaketiDB.ProvjeraPaketiTermini(Convert.ToInt32(comboBoxPaketiTermin.SelectedValue), maskedTextBoxTermin.Text);

                if (t != null)
                {

                    MessageBox.Show("U odabranom paketu već postoji dodani termin");
                }
                else
                {
                    PaketiDB.PaketiTerminiDodaj(Convert.ToInt32(comboBoxPaketiTermin.SelectedValue), maskedTextBoxTermin.Text);

                    MessageBox.Show("Uspješno dodano");
                }

            }
            catch
            {
                MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
            }

            
        }

        private void comboBoxpaketiGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool check;
            try
            {
                int value = Convert.ToInt32(comboBoxpaketiGrid.SelectedValue);
                check = true;

            }
            catch
            {
                check = false;
            }

            if (check == true)
            {
                dataGridViewTelevizije.AutoGenerateColumns = false;
                dataGridViewTelevizije.DataSource = TelevizijeDB.TelevizijeByPaket(Convert.ToInt32(comboBoxpaketiGrid.SelectedValue));

                dataGridViewTermini.AutoGenerateColumns = false;

                dataGridViewTermini.DataSource = TelevizijeDB.TerminiByPaket(Convert.ToInt32(comboBoxpaketiGrid.SelectedValue));
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string termin = dataGridViewTermini.SelectedRows[0].Cells[0].Value.ToString();

            int PaketID = Convert.ToInt32(comboBoxpaketiGrid.SelectedValue);


            TelevizijeDB.BrisiTerminPaket(PaketID, termin);

            dataGridViewTermini.AutoGenerateColumns = false;

            dataGridViewTermini.DataSource = TelevizijeDB.TerminiByPaket(Convert.ToInt32(comboBoxpaketiGrid.SelectedValue));



        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                string a = dataGridViewTelevizije.SelectedRows[0].Cells[0].Value.ToString();



                TelevizijeDB.BrisiPaketiTelevizije(Convert.ToInt32(Convert.ToInt32(a)));

                dataGridViewTelevizije.AutoGenerateColumns = false;
                dataGridViewTelevizije.DataSource = TelevizijeDB.TelevizijeByPaket(Convert.ToInt32(comboBoxpaketiGrid.SelectedValue));

                dataGridViewTermini.AutoGenerateColumns = false;

                dataGridViewTermini.DataSource = TelevizijeDB.TerminiByPaket(Convert.ToInt32(comboBoxpaketiGrid.SelectedValue));

                MessageBox.Show("Uspješno obrisano");
            }
            catch
            {
                MessageBox.Show("Dogodila se greška,pokušajte ponovo");
            }
        }

        private void buttonObrisiPake_Click(object sender, EventArgs e)
        {
            if(comboBoxPaketiBrisanje.SelectedIndex!=0)
            {
                try
                {

                    PaketiDB.BrisiPaket(Convert.ToInt32(comboBoxPaketiBrisanje.SelectedValue));
                    bindPaketi();
                }
                catch
                {
                    MessageBox.Show("Dogodila se greška molimo pokušajte ponovo");
                }
            }

            
        }

        private void textBoxNazivPaketa_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNazivPaketa.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNazivPaketa, "Molimo dodajte naziv paketa");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxNazivPaketa, "");
            }
        }
    }
}
