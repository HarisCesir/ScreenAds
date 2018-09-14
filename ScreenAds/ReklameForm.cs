using Database;
using Database.Klase;
using FtpLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace ScreenAds
{
    public partial class ReklameForm : Form
    {
        
        string fileName = "";
      public static string duration;
        public ReklameForm()
        {
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();


            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "";
            string VideoFormat = "Video files |*.mp4; ";


          openFileDialog1.Filter = VideoFormat;
            openFileDialog1.Title = "Dodaj video";
            
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = System.IO.Path.GetFileName(openFileDialog1.FileName);
                path = Path.GetDirectoryName(openFileDialog1.FileName);
                textBoxVideo.Text = path + "\\" + fileName;

            }



        }
        private void ReklameForm_Load(object sender, EventArgs e)
        {
            bindKlijenti();
            bindReklame();
        }

        private void bindReklame()
        {
            dataGridViewReklame.AutoGenerateColumns = false;
            dataGridViewReklame.DataSource = ReklameDB.SveReklame();
        }

        private void bindKlijenti()
        {
            comboBoxKlijenti.DataSource = KlijentiDB.SviKlijentiCombo();
            comboBoxKlijenti.ValueMember = "KlijentID";
            comboBoxKlijenti.DisplayMember = "Naziv";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Reklama reklama = ReklameDB.ReklamaByNaziv(textBoxNazivReklame.Text.Trim());

                if (reklama != null)
                {
                    MessageBox.Show("Reklama sa unešenim nazivom već postoji");
                }
                else
                {
                    fileName = textBoxNazivReklame.Text.Trim() + ".mp4";

                    backgroundWorker1.RunWorkerAsync();

                    button2.Enabled = false;
                    button2.Text = "Uploading";
                    textBoxVideo.ReadOnly = true;
                    button1.Enabled = false;
                    comboBoxKlijenti.Enabled = false;
                    while (this.backgroundWorker1.IsBusy)
                    {


                        Application.DoEvents();
                    }
                    
                    string url = "http://goldelectric.ba/videoupload/" + fileName;

                    int duzina = 0;
                    try {

                        duzina = Convert.ToInt32(maskedTextBoxDuzina.Text.Trim());
                           }
                    catch
                    {

                    }

                    ReklameDB.DodajReklamu(url, textBoxNazivReklame.Text.Trim(), Convert.ToInt32(comboBoxKlijenti.SelectedValue),duzina);

                    button2.Text = "Dodaj reklamu";
                    button2.Enabled = true;
                    button1.Enabled = true;
                    textBoxVideo.ReadOnly = false;
                    comboBoxKlijenti.Enabled = true;
                    bindReklame();








                    MessageBox.Show("Uspješno dodano");
                }
            }
        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            saveFileDialog1.FileName = fileName;
           
            using (FtpConnection ftp = new FtpConnection("goldelectric.ba", "goldelectric", "w11p3hOV4n"))
            {
                ftp.Open();
                ftp.Login();
                ftp.SetCurrentDirectory("/httpdocs/videoupload");

                ftp.PutFile(openFileDialog1.FileName, fileName);
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = dataGridViewReklame.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                using (FtpConnection ftp = new FtpConnection("goldelectric.ba", "goldelectric", "w11p3hOV4n"))
                {
                    ftp.Open();
                    ftp.Login();
                    ftp.SetCurrentDirectory("/httpdocs/videoupload");

                    string naziv = Path.GetFileName(ReklameDB.ReklamaByID(Convert.ToInt32(a)).Video);

                    ftp.RemoveFile(naziv);
                    

                }


                ReklameDB.BrisiReklamu(Convert.ToInt32(a));

               
            }
            catch
            {

            }

            bindReklame();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dataGridViewReklame.SelectedRows[0].Cells[0].Value.ToString();

                int ReklamaID = Convert.ToInt32(a);

                IzmjeniReklamuFrm frm = new IzmjeniReklamuFrm(ReklamaID);
                frm.Show();
            }
            catch
            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindReklame();
        }

        private void comboBoxKlijenti_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxKlijenti.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBoxKlijenti, "Molimo odaberite klijenta");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBoxKlijenti, "");
            }
        }

        private void textBoxNazivReklame_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxVideo.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider2.SetError(textBoxVideo, "Molimo dodajte video");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBoxVideo, "");

                if(textBoxNazivReklame.Text=="")
                {
                    e.Cancel = true;
                    errorProvider2.SetError(textBoxNazivReklame, "Molimo dodajte naziv reklame");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider2.SetError(textBoxNazivReklame, "");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           


        }
    }
}
