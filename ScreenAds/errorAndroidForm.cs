using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenAds
{
    public partial class errorAndroidForm : Form
    {
        public errorAndroidForm()
        {
            InitializeComponent();
        }

        private void errorAndroidForm_Load(object sender, EventArgs e)
        {
            bindProvjera();
            binderrori();
            bindProvjeraError();
        }

        private void bindProvjeraError()
        {
            try
            {
                dataGridViewProvjeraKasni.AutoGenerateColumns = false;
                dataGridViewProvjeraKasni.DataSource = Database.Klase.errorAndroid.SelectProvjera2SataCheck();
            }
            catch
            {

            }
        }

        private void binderrori()
        {
            try
            {
                dataGridViewError.AutoGenerateColumns = false;
                dataGridViewError.DataSource = Database.Klase.errorAndroid.SelectErrorAndroid();
            }
            catch
            {

            }
        }

        private void bindProvjera()
        {
            try
            {
                dataGridViewProvjera.AutoGenerateColumns = false;
                dataGridViewProvjera.DataSource = Database.Klase.errorAndroid.SelectProvjeraApi();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindProvjera();
            binderrori();
            bindProvjeraError();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dataGridViewError.SelectedRows[0].Cells[0].Value.ToString();

                int errorID = Convert.ToInt32(a);

                Database.Klase.errorAndroid.BrisiError(errorID);

                binderrori();
                bindProvjera();


            }
            catch
            {

            }
        }
    }
}
