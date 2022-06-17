namespace Projektni_zadatak
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.lbOdabirReprezentacije = new System.Windows.Forms.Label();
            this.btnPostavke = new System.Windows.Forms.Button();
            this.ddlReprezentacija = new System.Windows.Forms.ComboBox();
            this.btnOdabirReprezentacije = new System.Windows.Forms.Button();
            this.lbNaslov = new System.Windows.Forms.Label();
            this.btnOdabirIgraca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clbSvi = new System.Windows.Forms.CheckedListBox();
            this.pnlOmiljeni = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOstali = new System.Windows.Forms.FlowLayoutPanel();
            this.lbOmiljeni = new System.Windows.Forms.Label();
            this.lbOstali = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbOdabirReprezentacije
            // 
            resources.ApplyResources(this.lbOdabirReprezentacije, "lbOdabirReprezentacije");
            this.lbOdabirReprezentacije.Name = "lbOdabirReprezentacije";
            // 
            // btnPostavke
            // 
            resources.ApplyResources(this.btnPostavke, "btnPostavke");
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.UseVisualStyleBackColor = true;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            // 
            // ddlReprezentacija
            // 
            this.ddlReprezentacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlReprezentacija.FormattingEnabled = true;
            resources.ApplyResources(this.ddlReprezentacija, "ddlReprezentacija");
            this.ddlReprezentacija.Name = "ddlReprezentacija";
            // 
            // btnOdabirReprezentacije
            // 
            resources.ApplyResources(this.btnOdabirReprezentacije, "btnOdabirReprezentacije");
            this.btnOdabirReprezentacije.Name = "btnOdabirReprezentacije";
            this.btnOdabirReprezentacije.UseVisualStyleBackColor = true;
            this.btnOdabirReprezentacije.Click += new System.EventHandler(this.btnOdabirReprezentacije_Click);
            // 
            // lbNaslov
            // 
            resources.ApplyResources(this.lbNaslov, "lbNaslov");
            this.lbNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbNaslov.Name = "lbNaslov";
            // 
            // btnOdabirIgraca
            // 
            resources.ApplyResources(this.btnOdabirIgraca, "btnOdabirIgraca");
            this.btnOdabirIgraca.Name = "btnOdabirIgraca";
            this.btnOdabirIgraca.UseVisualStyleBackColor = true;
            this.btnOdabirIgraca.Click += new System.EventHandler(this.btnOdabirIgraca_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // clbSvi
            // 
            this.clbSvi.FormattingEnabled = true;
            resources.ApplyResources(this.clbSvi, "clbSvi");
            this.clbSvi.Name = "clbSvi";
            this.clbSvi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbSvi_ItemCheck);
            // 
            // pnlOmiljeni
            // 
            this.pnlOmiljeni.AllowDrop = true;
            resources.ApplyResources(this.pnlOmiljeni, "pnlOmiljeni");
            this.pnlOmiljeni.Name = "pnlOmiljeni";
            // 
            // pnlOstali
            // 
            this.pnlOstali.AllowDrop = true;
            resources.ApplyResources(this.pnlOstali, "pnlOstali");
            this.pnlOstali.Name = "pnlOstali";
            // 
            // lbOmiljeni
            // 
            resources.ApplyResources(this.lbOmiljeni, "lbOmiljeni");
            this.lbOmiljeni.Name = "lbOmiljeni";
            // 
            // lbOstali
            // 
            resources.ApplyResources(this.lbOstali, "lbOstali");
            this.lbOstali.Name = "lbOstali";
            // 
            // HomePage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.lbOstali);
            this.Controls.Add(this.lbOmiljeni);
            this.Controls.Add(this.pnlOstali);
            this.Controls.Add(this.pnlOmiljeni);
            this.Controls.Add(this.clbSvi);
            this.Controls.Add(this.btnOdabirIgraca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNaslov);
            this.Controls.Add(this.btnOdabirReprezentacije);
            this.Controls.Add(this.ddlReprezentacija);
            this.Controls.Add(this.btnPostavke);
            this.Controls.Add(this.lbOdabirReprezentacije);
            this.Name = "HomePage";
            this.Load += new System.EventHandler(this.OdabirReprezentacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOdabirReprezentacije;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.ComboBox ddlReprezentacija;
        private System.Windows.Forms.Button btnOdabirReprezentacije;
        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Button btnOdabirIgraca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbSvi;
        private System.Windows.Forms.FlowLayoutPanel pnlOmiljeni;
        private System.Windows.Forms.FlowLayoutPanel pnlOstali;
        private System.Windows.Forms.Label lbOmiljeni;
        private System.Windows.Forms.Label lbOstali;
    }
}