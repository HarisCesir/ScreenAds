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

namespace ScreenAds
{
    public partial class AndroidUpdateFrm : Form
    {
        string fileName = "";
        public AndroidUpdateFrm()
        {
            AutoValidate = AutoValidate.Disable;
            InitializeComponent();
            bindTrenutno();
        }

        private void bindTrenutno()
        {
            textBoxTrenutna.Text = Database.Klase.androidUpdate.Check().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "";
            string Format = "Android aplication |*.apk; ";


            openFileDialog1.Filter = Format;
            openFileDialog1.Title = "Dodaj video";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = System.IO.Path.GetFileName(openFileDialog1.FileName);
                path = Path.GetDirectoryName(openFileDialog1.FileName);
                textBox1.Text = path + "\\" + fileName;

            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Molimo dodajte apk");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                fileName = "adsmovieplayer.apk";

                backgroundWorker1.RunWorkerAsync();
                button2.Enabled = false;
                button2.Text = "Uploading";
                button1.Enabled = false;
                while(this.backgroundWorker1.IsBusy)
                {
                    Application.DoEvents();
                }

                button1.Text = "Dodaj";
                button2.Text = "Ucitaj";
                button1.Enabled = true;
                button2.Enabled = true;
                textBox1.Text = "";
                Database.Klase.androidUpdate.PromjeniBrojUpdate();
                bindTrenutno();
                MessageBox.Show("Uspjesno dodano");

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            saveFileDialog1.FileName = fileName;

            using (FtpConnection ftp = new FtpConnection("goldelectric.ba", "goldelectric", "w11p3hOV4n"))
            {
                ftp.Open();
                ftp.Login();
                ftp.SetCurrentDirectory("/httpdocs/AndroidApk");

                ftp.PutFile(openFileDialog1.FileName, fileName);

            }
        }
    }
}
