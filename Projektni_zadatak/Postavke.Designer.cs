namespace Projektni_zadatak
{
    partial class Postavke
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavke));
            this.lbPrvenstvo = new System.Windows.Forms.Label();
            this.cbIzborPrvenstva = new System.Windows.Forms.ComboBox();
            this.lbJezik = new System.Windows.Forms.Label();
            this.cbIzborJezika = new System.Windows.Forms.ComboBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPrvenstvo
            // 
            resources.ApplyResources(this.lbPrvenstvo, "lbPrvenstvo");
            this.lbPrvenstvo.Name = "lbPrvenstvo";
            // 
            // cbIzborPrvenstva
            // 
            this.cbIzborPrvenstva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzborPrvenstva.Items.AddRange(new object[] {
            resources.GetString("cbIzborPrvenstva.Items"),
            resources.GetString("cbIzborPrvenstva.Items1")});
            resources.ApplyResources(this.cbIzborPrvenstva, "cbIzborPrvenstva");
            this.cbIzborPrvenstva.Name = "cbIzborPrvenstva";
            // 
            // lbJezik
            // 
            resources.ApplyResources(this.lbJezik, "lbJezik");
            this.lbJezik.Name = "lbJezik";
            // 
            // cbIzborJezika
            // 
            this.cbIzborJezika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzborJezika.FormattingEnabled = true;
            this.cbIzborJezika.Items.AddRange(new object[] {
            resources.GetString("cbIzborJezika.Items"),
            resources.GetString("cbIzborJezika.Items1")});
            resources.ApplyResources(this.cbIzborJezika, "cbIzborJezika");
            this.cbIzborJezika.Name = "cbIzborJezika";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.btnOdaberi, "btnOdaberi");
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.UseVisualStyleBackColor = false;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // Postavke
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.cbIzborJezika);
            this.Controls.Add(this.lbJezik);
            this.Controls.Add(this.cbIzborPrvenstva);
            this.Controls.Add(this.lbPrvenstvo);
            this.Name = "Postavke";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPrvenstvo;
        private System.Windows.Forms.ComboBox cbIzborPrvenstva;
        private System.Windows.Forms.Label lbJezik;
        private System.Windows.Forms.ComboBox cbIzborJezika;
        private System.Windows.Forms.Button btnOdaberi;
    }
}

