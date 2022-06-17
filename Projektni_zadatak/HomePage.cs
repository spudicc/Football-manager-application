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

namespace Projektni_zadatak
{
    public partial class HomePage : Form
    {
        private string file = "Odabir.txt";
        private string reprezentacijaFile = "OdabirReprezentacije.txt";
        private string najdraziIgraciFile = "NajdraziIgraci.txt";
        private string ostaliIgraciFile = "OstaliIgraci.txt";

        public HomePage()
        {
            InitializeComponent();
        }

        private void OdabirReprezentacije_Load(object sender, EventArgs e)
        {
            SetInfo();
        }

        private async void SetInfo()
        {
            try
            {
                if (!File.Exists(file))
                {
                    new Postavke().Show();
                    return;
                }

                List<string> info = new List<string>(Podatkovni_Sloj.Podatkovni_Sloj.LoadDataFromTxt(file));
                RestResponse<Prvenstvo> restResponse = await Podatkovni_Sloj.Podatkovni_Sloj.GetPrvenstvo(info[1]);

                List<Prvenstvo> prvenstva = Podatkovni_Sloj.Podatkovni_Sloj.DeserijalizirajPodatke(restResponse);

                foreach (var prvenstvo in prvenstva)
                {
                    ddlReprezentacija.Items.Add(prvenstvo.ToString());
                }

                SetIgraciInfo(info);
                SetUCIgracInfo(najdraziIgraciFile, pnlOmiljeni);
                SetUCIgracInfo(ostaliIgraciFile, pnlOstali);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private async void SetIgraciInfo(List<string> info)
        {
            try
            {
                List<string> reprezentacijainfo = new List<string>(Podatkovni_Sloj.Podatkovni_Sloj.LoadDataFromTxt(reprezentacijaFile));
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
                    clbSvi.Items.Add(player);
                }
                foreach (Player player in tekma.HomeTeamStatistics.Substitutes)
                {
                    clbSvi.Items.Add(player);
                }
            }
            else
            {
                foreach (Player player in tekma.AwayTeamStatistics.StartingEleven)
                {
                    clbSvi.Items.Add(player);
                }
                foreach (Player player in tekma.AwayTeamStatistics.Substitutes)
                {
                    clbSvi.Items.Add(player);
                }
            }


        }

        private void btnPostavke_Click(object sender, EventArgs e)
        {
            new Postavke().Show();
            this.Controls.Clear();
            SetInfo();
            InitializeComponent();
        }

        private void btnOdabirReprezentacije_Click(object sender, EventArgs e)
        {
            List<string> info = new List<string>();
            info.Add(ddlReprezentacija.SelectedItem.ToString());
            Podatkovni_Sloj.Podatkovni_Sloj.SaveDataToTxt(info, reprezentacijaFile);
            clbSvi.Controls.Clear();
            SetInfo();
            InitializeComponent();
        }

        private void btnOdabirIgraca_Click(object sender, EventArgs e)
        {            
            List<Player> players = new List<Player>();
            foreach (Player player in clbSvi.Items)
            {
                players.Add(player);
                
            }

            List<string> favplayersinfo = new List<string>();
            foreach (Player checkedplayer in clbSvi.CheckedItems)
            {
                players.Remove(checkedplayer);
                favplayersinfo.Add(Podatkovni_Sloj.Podatkovni_Sloj.ParsePlayerForFile(checkedplayer));
            }

            List<string> otherplayersinfo = new List<string>();
            foreach (Player p in players)
            {            
                otherplayersinfo.Add(Podatkovni_Sloj.Podatkovni_Sloj.ParsePlayerForFile(p));
            }

            Podatkovni_Sloj.Podatkovni_Sloj.SaveDataToTxt(favplayersinfo, najdraziIgraciFile);
            SetUCIgracInfo(najdraziIgraciFile, pnlOmiljeni);
            Podatkovni_Sloj.Podatkovni_Sloj.SaveDataToTxt(otherplayersinfo, ostaliIgraciFile);
            SetUCIgracInfo(ostaliIgraciFile, pnlOstali);
            
        }

        private void SetUCIgracInfo(string igracifile, FlowLayoutPanel panel)
        {
            List<string> igraci = new List<string>(Podatkovni_Sloj.Podatkovni_Sloj.LoadDataFromTxt(igracifile));
            foreach (string igrac in igraci)
            {
                Player p = new Player();
                p = Podatkovni_Sloj.Podatkovni_Sloj.ParsePlayerFromFile(igrac);
                UCIgrac playerUC = new UCIgrac(p, this);
                panel.Controls.Add(playerUC);
            }
        }

        private void clbSvi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox items = (CheckedListBox)sender;
            if (items.CheckedItems.Count >= 3)
            {
                e.NewValue = CheckState.Unchecked;
            }
        }

        public void prebaciUDruguEkipuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrebaciIgrace(pnlOmiljeni, pnlOstali);
        }

        private void PrebaciIgrace(Panel pnlomiljeni, Panel pnlostali)
        {
            List<UserControl> kontroleKojeSePrebacuju = new List<UserControl>();
            foreach (UserControl userControl in pnlomiljeni.Controls)
            {
                if (userControl.BorderStyle == BorderStyle.Fixed3D)
                {
                    kontroleKojeSePrebacuju.Add(userControl);
                }
            }

            if (pnlomiljeni.Controls.Count < 4)
            {
                MessageBox.Show("Mozete imati samo 3 omiljena igraca!");
                return;
            }
            else
            {
                foreach (UserControl userControl in kontroleKojeSePrebacuju)
                {
                    pnlostali.Controls.Add(userControl);
                }
            }
        }

        public Panel GetFavPanel()
        {            
            return pnlOmiljeni;
        }

        public Panel GetOtherPanel()
        {
            return pnlOstali;
        }
    }
}



