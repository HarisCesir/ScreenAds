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
    public partial class KlijentiInfoForm : Form
    {
        int klijentId;
        public KlijentiInfoForm(int KlijentID)
        {
            klijentId = KlijentID;

            InitializeComponent();
        }

        private void KlijentiInfoForm_Load(object sender, EventArgs e)
        {
            ucitajKlijenta();
            ucitajReklame();
        }

        private void ucitajReklame()
        {
            try
            {
               
                List<Reklama> reklame = ReklameDB.ReklamaByKlijent(klijentId);

                dataGridViewReklame.AutoGenerateColumns = false;

                dataGridViewReklame.DataSource = reklame;




            }
            catch
            {

            }
        }

        private void ucitajKlijenta()
        {
            try
            {
                Klijenti klijent = KlijentiDB.KlijentByID(klijentId);

                textBoxNaziv.Text = klijent.Naziv;
                textBoxKontakOsoba.Text = klijent.KontaktOsoba;
                textBoxKontaktTelefon.Text = klijent.KontaktTelefon;


            }
            catch
            {
                
            }
        }

        private void dataGridViewReklame_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string value = dataGridViewReklame.SelectedRows[0].Cells[0].Value.ToString();
                int reklamaID = Convert.ToInt32(value);

                List<MarketingByReklama_Result> marketing = MarketingDB.MarketingByReklama(reklamaID);


                dataGridViewmarketing.AutoGenerateColumns = false;

                dataGridViewmarketing.DataSource = marketing;


            }

            catch
            {

            }



        }
    }
}
