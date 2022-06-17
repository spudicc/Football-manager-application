namespace Projektni_zadatak
{
    partial class Igraci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Igraci));
            this.pnlSvi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOmiljeni = new System.Windows.Forms.FlowLayoutPanel();
            this.clbSvi = new System.Windows.Forms.CheckedListBox();
            this.clbOmiljeni = new System.Windows.Forms.CheckedListBox();
            this.pnlSvi.SuspendLayout();
            this.pnlOmiljeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSvi
            // 
            this.pnlSvi.Controls.Add(this.clbSvi);
            resources.ApplyResources(this.pnlSvi, "pnlSvi");
            this.pnlSvi.Name = "pnlSvi";
            // 
            // pnlOmiljeni
            // 
            this.pnlOmiljeni.Controls.Add(this.clbOmiljeni);
            resources.ApplyResources(this.pnlOmiljeni, "pnlOmiljeni");
            this.pnlOmiljeni.Name = "pnlOmiljeni";
            // 
            // clbSvi
            // 
            this.clbSvi.FormattingEnabled = true;
            resources.ApplyResources(this.clbSvi, "clbSvi");
            this.clbSvi.Name = "clbSvi";
            // 
            // clbOmiljeni
            // 
            this.clbOmiljeni.FormattingEnabled = true;
            resources.ApplyResources(this.clbOmiljeni, "clbOmiljeni");
            this.clbOmiljeni.Name = "clbOmiljeni";
            // 
            // Igraci
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlOmiljeni);
            this.Controls.Add(this.pnlSvi);
            this.Name = "Igraci";
            this.Load += new System.EventHandler(this.Igraci_Load);
            this.pnlSvi.ResumeLayout(false);
            this.pnlOmiljeni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSvi;
        private System.Windows.Forms.FlowLayoutPanel pnlOmiljeni;
        private System.Windows.Forms.CheckedListBox clbSvi;
        private System.Windows.Forms.CheckedListBox clbOmiljeni;
    }
}