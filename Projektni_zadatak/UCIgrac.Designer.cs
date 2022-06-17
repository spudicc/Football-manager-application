namespace Projektni_zadatak
{
    partial class UCIgrac
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIgrac));
            this.lbIme = new System.Windows.Forms.Label();
            this.lbBroj = new System.Windows.Forms.Label();
            this.lbPozicija = new System.Windows.Forms.Label();
            this.lbKapetan = new System.Windows.Forms.Label();
            this.lbOmiljeni = new System.Windows.Forms.Label();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.contextMenuUC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.prebaciUDruguEkipuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.contextMenuUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIme
            // 
            resources.ApplyResources(this.lbIme, "lbIme");
            this.lbIme.Name = "lbIme";
            // 
            // lbBroj
            // 
            resources.ApplyResources(this.lbBroj, "lbBroj");
            this.lbBroj.Name = "lbBroj";
            // 
            // lbPozicija
            // 
            resources.ApplyResources(this.lbPozicija, "lbPozicija");
            this.lbPozicija.Name = "lbPozicija";
            // 
            // lbKapetan
            // 
            resources.ApplyResources(this.lbKapetan, "lbKapetan");
            this.lbKapetan.Name = "lbKapetan";
            // 
            // lbOmiljeni
            // 
            resources.ApplyResources(this.lbOmiljeni, "lbOmiljeni");
            this.lbOmiljeni.Name = "lbOmiljeni";
            // 
            // pbSlika
            // 
            resources.ApplyResources(this.pbSlika, "pbSlika");
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.TabStop = false;
            // 
            // contextMenuUC
            // 
            this.contextMenuUC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prebaciUDruguEkipuToolStripMenuItem});
            this.contextMenuUC.Name = "contextMenuUC";
            resources.ApplyResources(this.contextMenuUC, "contextMenuUC");
            // 
            // prebaciUDruguEkipuToolStripMenuItem
            // 
            this.prebaciUDruguEkipuToolStripMenuItem.Name = "prebaciUDruguEkipuToolStripMenuItem";
            resources.ApplyResources(this.prebaciUDruguEkipuToolStripMenuItem, "prebaciUDruguEkipuToolStripMenuItem");
            this.prebaciUDruguEkipuToolStripMenuItem.Click += new System.EventHandler(this.prebaciUDruguEkipuToolStripMenuItem_Click);
            // 
            // UCIgrac
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuUC;
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.lbOmiljeni);
            this.Controls.Add(this.lbKapetan);
            this.Controls.Add(this.lbPozicija);
            this.Controls.Add(this.lbBroj);
            this.Controls.Add(this.lbIme);
            this.Name = "UCIgrac";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UCIgrac_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.contextMenuUC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBroj;
        private System.Windows.Forms.Label lbPozicija;
        private System.Windows.Forms.Label lbKapetan;
        private System.Windows.Forms.Label lbOmiljeni;
        private System.Windows.Forms.PictureBox pbSlika;
        public System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.ContextMenuStrip contextMenuUC;
        private System.Windows.Forms.ToolStripMenuItem prebaciUDruguEkipuToolStripMenuItem;
    }
}
