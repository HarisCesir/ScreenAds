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
    public partial class KlijentiForm : Form
    {
        public KlijentiForm()
        {
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    KlijentiDB.KlijentiDodaj(textBoxNazivKlijenta.Text.Trim(), maskedTextBoxKontaktTelefon.Text, textBoxKontaktOsoba.Text.Trim());
                    BindKlijenti();
                    MessageBox.Show("Uspješno dodano");
                }
                catch
                {
                    MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
                }
            }
           
        }

        private void KlijentiForm_Load(object sender, EventArgs e)
        {
            BindKlijenti();
        }

        private void BindKlijenti()
        {
            try
            {
                dataGridViewKlijenti.AutoGenerateColumns = false;
                dataGridViewKlijenti.DataSource = KlijentiDB.SviKlijenti();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dataGridViewKlijenti.SelectedRows[0].Cells[0].Value.ToString();

                KlijentiDB.BrisiKlijent(Convert.ToInt32(a));

                BindKlijenti();

                MessageBox.Show("Uspješno obrisano");
            }
            catch
            {
                MessageBox.Show("Dogodila se greška molimo pokušajte ponovo");
            }

        }

        private void textBoxNazivKlijenta_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNazivKlijenta.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNazivKlijenta, "Molimo dodajte naziv klijenta");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxNazivKlijenta, "");
            }
        }

        private void textBoxKontaktOsoba_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxKontaktOsoba.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider2.SetError(textBoxKontaktOsoba, "Molimo dodajte kontakt osobu");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBoxKontaktOsoba, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dataGridViewKlijenti.SelectedRows[0].Cells[0].Value.ToString();

                int KlijentID = Convert.ToInt32(a);

                KlijentiInfoForm frm = new KlijentiInfoForm(KlijentID);

                frm.Show();

            }
            catch
            {
                MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
            }


        }
    }
}
