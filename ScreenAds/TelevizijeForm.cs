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
    public partial class TelevizijeForm : Form
    {
        public TelevizijeForm()
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            InitializeComponent();
        }

        private void TelevizijeForm_Load(object sender, EventArgs e)
        {
            
                bindObjekti();
                bindGradovi();
                bindTelevizije();
            
            
        }

        private void bindTelevizije()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = TelevizijeDB.TelevizijeInfo();
            }
            catch
            {
              
            }
        }

        private void bindGradovi()
        {
            try
            {
                comboBoxGrad.DataSource = GradoviDB.SviGradoviCombo();
                comboBoxGrad.DisplayMember = "Naziv";
                comboBoxGrad.ValueMember = "GradID";
            }
            catch
            {

            }
        }

        private void bindObjekti()
        {
            try
            {
                comboBoxObjekat.DataSource = ObjektiDB.SviObjekti();
                comboBoxObjekat.DisplayMember = "Naziv";
                comboBoxObjekat.ValueMember = "ObjekatID";
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {

                TelevizijaByName_Result televizija = TelevizijeDB.TelevizijaByName(textBoxNazivTV.Text.Trim());

                if (televizija != null)
                {
                    MessageBox.Show("Televezija sa unesenim imenom već postoji");
                }
                else
                {



                    try
                    {
                        TelevizijeDB.DodajTelevizija(textBoxNazivTV.Text.Trim(), Convert.ToInt32(comboBoxGrad.SelectedValue), Convert.ToInt32(comboBoxObjekat.SelectedValue));
                        bindTelevizije();
                        MessageBox.Show("Uspješno dodano");
                    }
                    catch
                    {
                        MessageBox.Show("Dogodila se greška molimo pokušajte ponovo");
                    }
                }
            }

           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindTelevizije();
        }

        private void textBoxNazivTV_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNazivTV.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNazivTV,"Molimo unesite naziv televizije");
            }
            else
            {
                errorProvider1.SetError(textBoxNazivTV, "");
            }
        }

        private void comboBoxGrad_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxGrad.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider2.SetError(comboBoxGrad, "Molimo odaberite grad");
            }
            else
            {
                e.Cancel=false;
                errorProvider2.SetError(comboBoxGrad, "");
            }

        }

        private void comboBoxObjekat_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxObjekat.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider2.SetError(comboBoxObjekat, "Molimo odaberite objekat");
            }
            else
            {
                errorProvider2.SetError(comboBoxObjekat, "");
                e.Cancel = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                int TelevizijaID = Convert.ToInt32(value);

                TelevizijeDB.BrisiTv(TelevizijaID);
                bindTelevizije();
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
                int TelevizijaID = Convert.ToInt32(value);
                    IzmjeneTv frm = new IzmjeneTv(TelevizijaID);
                    frm.Show();
                }
                catch
                {

                }

            
        }

        private void textBoxNazivTV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
