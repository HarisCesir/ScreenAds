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
    public partial class GradoviForm : Form
    {
        public GradoviForm()
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    Database.Klase.GradoviDB.DodajGrad(textBoxNazivGrada.Text.Trim());

                    BindGradovi();
                    textBoxNazivGrada.Text = "";

                    MessageBox.Show("Uspješno dodano");
                }
                catch
                {
                    MessageBox.Show("Dogodila se greška molimo pokušajte ponovo");
                }

            }
            
        }

        private void textBoxNazivGrada_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNazivGrada.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNazivGrada, "Molimo dodajte naziv grada");
            }
            else
            {
                errorProvider1.SetError(textBoxNazivGrada, "");
            }

        }

        private void GradoviForm_Load(object sender, EventArgs e)
        {
            BindGradovi();
        }

        private void BindGradovi()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = Database.Klase.GradoviDB.SviGradovi();
            }
            catch
            {

            }
        }

        private void GradoviForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            errorProvider1.SetError(textBoxNazivGrada, "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            int GradID = Convert.ToInt32(value);

            try
            {
                GradoviDB.BrisiGrad(GradID);
                BindGradovi();
            }
            catch
            {
                MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
            }

        }
    }
}
