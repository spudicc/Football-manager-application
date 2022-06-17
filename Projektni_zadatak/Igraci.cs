using RestSharp;
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
using Podatkovni_Sloj.Models;
using static Podatkovni_Sloj.Models.Utakmica;

namespace Projektni_zadatak
{
    public partial class Igraci : Form
    {
        private string reprezentacijaFile = "OdabirReprezentacije.txt";
        private string file = "Odabir.txt";
        public Igraci()
        {
            InitializeComponent();
        }

        private void Igraci_Load(object sender, EventArgs e)
        {
            SetInfo();
        }

        private async void SetInfo()
        {
            try
            {
                if (!File.Exists(reprezentacijaFile))
                {
                    new HomePage().Show();
                    return;

                }

                List<string> reprezentacijainfo = new List<string>(Podatkovni_Sloj.Podatkovni_Sloj.LoadDataFromTxt(reprezentacijaFile));
                List<string> info = new List<string>(Podatkovni_Sloj.Podatkovni_Sloj.LoadDataFromTxt(file));
                RestResponse<Utakmica> restResponse = await Podatkovni_Sloj.Podatkovni_Sloj.GetUtakmica(reprezentacijainfo[0], info[1]);
                List<Utakmica> utakmice = Podatkovni_Sloj.Podatkovni_Sloj.DeserijalizirajPodatkeIgraca(restResponse);

                DodajIgraceUDDL(utakmice, reprezentacijainfo);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void DodajIgraceUDDL(List<Utakmica> utakmice, List<string> reprezentacija)
        {

            Utakmica tekma = utakmice[0];
            if (tekma.HomeTeam.Code == reprezentacija[0])
            {
                foreach (Player player in tekma.HomeTeamStatistics.StartingEleven)
                {
                    clbSvi.Items.Add(player.Name);
                }
                foreach (Player player in tekma.HomeTeamStatistics.Substitutes)
                {
                    clbSvi.Items.Add(player.Name);
                }
            }
            else
            {
                foreach (Player player in tekma.AwayTeamStatistics.StartingEleven)
                {
                    clbSvi.Items.Add(player.Name);
                }
                foreach (Player player in tekma.AwayTeamStatistics.Substitutes)
                {
                    clbSvi.Items.Add(player.Name);
                }
            }

        }
    }
}
