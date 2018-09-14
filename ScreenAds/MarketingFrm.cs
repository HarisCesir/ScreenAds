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
using WMPLib;
using AxWMPLib;
namespace ScreenAds
{
    public partial class MarketingFrm : Form
    {
        public MarketingFrm()
        {
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();
        }

        private void MarketingFrm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

            dateTimePicker1.MinDate = DateTime.Now.Date;
            dateTimePicker2.MinDate = DateTime.Now.Date;
            bindPaketi();
            bindReklame();

           


        }

        private void bindReklame()
        {
            try
            {
                comboBoxReklama.DataSource = ReklameDB.SveReklameCombo();
                comboBoxReklama.DisplayMember = "Naziv";
                comboBoxReklama.ValueMember = "ReklamaID";
            }
            catch
            {

            }
        }

        private void bindPaketi()
        {
            try
            {
                comboBoxPaketi.DataSource = PaketiDB.SviPaketi();
                comboBoxPaketi.DisplayMember = "Naziv";
                comboBoxPaketi.ValueMember = "PaketID";
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                DateTime DatumOD = dateTimePicker1.Value.Date;
                DateTime DatumDO = dateTimePicker2.Value.Date;

                //Marketing marketing = MarketingDB.MarketingProvjera(Convert.ToInt32(comboBoxPaketi.SelectedValue), Convert.ToInt32(comboBoxReklama.SelectedValue), DatumOD, DatumDO);

                //if (marketing != null)
                //{
                //    MessageBox.Show("Marketing sa unesenim podatcima vec postoji");
                //}
                //else
                //{
                    try
                    {

                        MarketingDB.DodajMarketing(Convert.ToInt32(comboBoxPaketi.SelectedValue), Convert.ToInt32(comboBoxReklama.SelectedValue), DatumOD, DatumDO);
                        MessageBox.Show("Uspješno dodano");
                    }
                    catch
                    {
                        MessageBox.Show("Dogodila se greška, molimo pokušajte ponovo");
                    }
                }


            

           

        }

        private void comboBoxPaketi_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxPaketi.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBoxPaketi, "Molimo odaberite paket");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBoxPaketi, "");
            }
        }

        private void comboBoxReklama_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxReklama.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider2.SetError(comboBoxReklama, "Molimo odaberite reklamu");

            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(comboBoxReklama, "");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(Convert.ToInt32(comboBoxPaketi.SelectedValue)>0)
            {
                bool ok = true;
                monthCalendar1.RemoveAllBoldedDates();


                DateTime startdate = dateTimePicker1.Value.Date;
                DateTime endDate = dateTimePicker2.Value.Date;




                for (DateTime i = startdate; i <= endDate; i = i.AddDays(1))
                {

                    int suma = MarketingDB.ProvjeraSlobodnih(Convert.ToInt32(comboBoxPaketi.SelectedValue), i);

                    if (suma > 200)
                    {

                        monthCalendar1.AddBoldedDate(i);

                        ok = false;
                    }

                }

                monthCalendar1.UpdateBoldedDates();

                if (ok == true)
                {
                    button1.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite paket");
            }

            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime datum = dateTimePicker3.Value.Date;

                List<MarketingPoDatumu_Result> podatumu = Database.Klase.MarketingDB.MarketingPodatumu(datum);

                List<MarketingPoDatumu_Result> BezDuplih = new List<MarketingPoDatumu_Result>();

                foreach(MarketingPoDatumu_Result m in podatumu)
                {
                    int a = 0;
                    foreach(MarketingPoDatumu_Result p in BezDuplih)
                    {
                        if(m.Naziv==p.Naziv)
                        {
                            a = 1;
                        }
                    }

                    if(a==0)
                    {
                        BezDuplih.Add(m);
                    }

                }


                dataGridViewPaketi.AutoGenerateColumns = false;

                dataGridViewPaketi.DataSource = BezDuplih;





            }
            catch
            {

            }
        }

        private void dataGridViewPaketi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{

            //    string a = dataGridViewPaketi.SelectedRows[0].Cells[0].Value.ToString();

            //    int paketID = Convert.ToInt32(a);

            //    dataGridViewTermini.AutoGenerateColumns = false;
            //    dataGridViewTermini.DataSource = Database.Klase.PaketiDB.TerminiByPaket(paketID);


            //    dataGridViewTelevizije.AutoGenerateColumns = false;
            //    dataGridViewTelevizije.DataSource = Database.Klase.TelevizijeDB.TelevizijeByPaket(paketID);

            //    dataGridViewReklame.AutoGenerateColumns = false;
            //    dataGridViewReklame.DataSource = Database.Klase.ReklameDB.ReklameByPaketDatum(paketID, dateTimePicker1.Value.Date);
            //}
            //catch
            //{

            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dataGridViewReklame.SelectedRows[0].Cells[1].Value.ToString();
                axWindowsMediaPlayer1.URL = a;
            }
            catch
            {

            }
        }

        private void dataGridViewPaketi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string a = dataGridViewPaketi.SelectedRows[0].Cells[0].Value.ToString();

                int paketID = Convert.ToInt32(a);

                dataGridViewTermini.AutoGenerateColumns = false;
                dataGridViewTermini.DataSource = Database.Klase.PaketiDB.TerminiByPaket(paketID);


                dataGridViewTelevizije.AutoGenerateColumns = false;
                dataGridViewTelevizije.DataSource = Database.Klase.TelevizijeDB.TelevizijeByPaket(paketID);

                dataGridViewReklame.AutoGenerateColumns = false;
                dataGridViewReklame.DataSource = Database.Klase.ReklameDB.ReklameByPaketDatum(paketID, dateTimePicker1.Value.Date);
            }
            catch
            {

            }
        }
    }
}
