using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektni_zadatak
{
    public partial class Postavke : Form
    {
        private string file = "Odabir.txt";
        private const string HR = "hr";
        private const string EN = "en";

        public Postavke()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            try
            {

                List<string> info = new List<string>(Podatkovni_Sloj.Podatkovni_Sloj.LoadDataFromTxt(file));
                Podatkovni_Sloj.Podatkovni_Sloj.SetKultura(info[0]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            this.Controls.Clear();
            InitializeComponent();
        }


        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            List<string> info = new List<string>();
            info.Add((string)cbIzborJezika.SelectedItem);
            info.Add((string)cbIzborPrvenstva.SelectedItem);
            Podatkovni_Sloj.Podatkovni_Sloj.SaveDataToTxt(info, file);
            Podatkovni_Sloj.Podatkovni_Sloj.SetKultura((string)cbIzborJezika.SelectedItem);

            Close();
        }


    }
}
