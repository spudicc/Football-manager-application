using Podatkovni_Sloj.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektni_zadatak
{
    public partial class UCIgrac : UserControl
    {
        public Player Player { get; set; }
        

        public UCIgrac(Player player, HomePage form)
        {
            InitializeComponent();
            Player = player;
            PostaviPodatke(player);
        }

        private void PostaviPodatke(Player player)
        {
            lbIme.Text = player.Name;
            lbBroj.Text = player.ShirtNumber;
            lbPozicija.Text = player.Position.ToString();
            lbKapetan.Text = (player.Captain ? "KAPETAN" : "");            
        }

        private void prebaciUDruguEkipuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomePage form;
            form = (HomePage)this.FindForm();

            Panel pnlomiljeni = form.GetFavPanel();
            Panel pnlostali = form.GetOtherPanel();

            List<UserControl> kontroleKojeSePrebacujuUostale = new List<UserControl>();
            foreach (UserControl userControl in pnlomiljeni.Controls)
            {
                if (userControl.BorderStyle == BorderStyle.Fixed3D)
                {
                    kontroleKojeSePrebacujuUostale.Add(userControl);
                }
            }

            foreach (UserControl userControl in kontroleKojeSePrebacujuUostale)
            {
                pnlostali.Controls.Add(userControl);
                pnlomiljeni.Controls.Remove(userControl);
            }


            //List<UserControl> kontroleKojeSePrebacuju = new List<UserControl>();
            //foreach (UserControl userControl in pnlostali.Controls)
            //{
            //    if (userControl.BorderStyle == BorderStyle.Fixed3D)
            //    {
            //        kontroleKojeSePrebacuju.Add(userControl);
            //    }
            //}

            //if (pnlomiljeni.Controls.Count > 3)
            //{
            //    MessageBox.Show("Mozete imati samo 3 omiljena igraca!");
            //    return;
            //}
            //else
            //{
            //    foreach (UserControl userControl in kontroleKojeSePrebacuju)
            //    {
            //        pnlomiljeni.Controls.Add(userControl);
            //        pnlostali.Controls.Remove(userControl);
            //    }
            //}
        }
                

        public void UCIgrac_MouseClick(object sender, MouseEventArgs e)
        {          
            
            if (this.BorderStyle == BorderStyle.FixedSingle)
            {
                this.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {                
                this.BorderStyle = BorderStyle.FixedSingle;
            }
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


            //List<UserControl> kontroleKojeSePrebacuju = new List<UserControl();
            //foreach (var item in collection)
            //{

            //}
        }
    }
}
