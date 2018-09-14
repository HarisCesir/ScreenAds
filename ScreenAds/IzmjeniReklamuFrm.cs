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
using FtpLib;

namespace ScreenAds
{
    public partial class IzmjeniReklamuFrm : Form
    {
        int reklamaId;
        public IzmjeniReklamuFrm(int reklamaID)
        {
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();

            reklamaId = reklamaID;
        }

        private void IzmjeniReklamuFrm_Load(object sender, EventArgs e)
        {
            try
            {
                ReklamaByID_Result Reklama = ReklameDB.ReklamaByID(reklamaId);

                textBoxNaziv.Text = Reklama.Naziv;
                textBoxVideo.Text = Reklama.Video;
                comboBoxKlijenti.DataSource = KlijentiDB.SviKlijentiCombo();
                comboBoxKlijenti.DisplayMember = "Naziv";
                comboBoxKlijenti.ValueMember = "KlijentID";
                comboBoxKlijenti.SelectedIndex = comboBoxKlijenti.FindStringExact(Reklama.Klijent);
            }
            catch
            {

            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {



                try
                {
                    Reklama reklama = ReklameDB.ReklamaByNaziv(textBoxNaziv.Text.Trim());

                    if (reklama != null)
                    {
                        MessageBox.Show("Reklama sa unešenim nazivom već postoji");
                    }
                    else
                    {
                        using (FtpConnection ftp = new FtpConnection("ftp.titovbunker.com", "titovbunker", "5xT5@7g#CquG"))
                        {
                            ReklamaByID_Result Reklama = ReklameDB.ReklamaByID(reklamaId);
                            ftp.Open();
                            ftp.Login();
                            ftp.SetCurrentDirectory("/public_html/Upload");

                            ftp.RenameFile(Reklama.Naziv + ".mp4", textBoxNaziv.Text.Trim() + ".mp4");

                        }

                        string video = "titovbunker.com/Upload/" + textBoxNaziv.Text.Trim() + ".mp4";

                        ReklameDB.IzmjeniReklamu(textBoxNaziv.Text.Trim(), Convert.ToInt32(comboBoxKlijenti.SelectedValue), reklamaId, video);

                        this.Close();



                    }
                }

                catch
                {
                    MessageBox.Show("Dogodila se greska, molimo pokušajte ponovo");
                }

                }
            }
        

        private void textBoxNaziv_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNaziv.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNaziv, "Molimo dodajte naziv");
            
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxNaziv, "");
            }
        }

        private void comboBoxKlijenti_Validating(object sender, CancelEventArgs e)
        {
            if(comboBoxKlijenti.SelectedIndex==0)
            {
                e.Cancel = true;
                errorProvider2.SetError(comboBoxKlijenti, "Molimo odaberite klijenta");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(comboBoxKlijenti, "");
            }
        }
    }
}
