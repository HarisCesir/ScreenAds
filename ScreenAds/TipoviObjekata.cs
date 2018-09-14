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
    public partial class TipoviObjekata : Form
    {
        public TipoviObjekata()
        {
            InitializeComponent();
            labelError.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="")
            {
                labelError.Visible = true;
            }
            else
            {
                TipObjekta tip = TipoviObjektaDB.TipByName(textBox1.Text.Trim());
                if (tip != null)
                {
                    MessageBox.Show("Tip objekta sa tim nazivom već postoji");
                }
                else
                {

                    try
                    {
                        labelError.Visible = false;
                        TipoviObjektaDB.DodajTip(textBox1.Text.Trim());
                        textBox1.Text = "";
                        bindTipovi();
                        MessageBox.Show("Uspješno dodano");
                    }
                    catch
                    {
                        MessageBox.Show("Dogodila se greška molimo pokušajte kasnije");
                    }
                }
            }
           
        }

        private void TipoviObjekata_Load(object sender, EventArgs e)
        {
            bindTipovi();
        }

        private void bindTipovi()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = Database.Klase.TipoviObjektaDB.SviTipoviObjekta();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                int TipID = Convert.ToInt32(value);

                TipoviObjektaDB.ObrisiTipObjekta(TipID);
                bindTipovi();

            }
            catch
            {
                MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
            }
        }
    }
}
