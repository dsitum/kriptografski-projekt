namespace OS2_Kriptografija
{
    partial class Pocetna_forma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ključeviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generirajSimetrciniKljuc = new System.Windows.Forms.ToolStripMenuItem();
            this.generirajParAsimetricnihKljuceva = new System.Windows.Forms.ToolStripMenuItem();
            this.kriptografijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AesEnkripcijaDijalog = new System.Windows.Forms.ToolStripMenuItem();
            this.AesDekripcijaDijalog = new System.Windows.Forms.ToolStripMenuItem();
            this.rSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rsaEnkripcijaDijalog = new System.Windows.Forms.ToolStripMenuItem();
            this.rsaDekripcijaDijalog = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalniPotpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalnoPotpisivanjeDijalog = new System.Windows.Forms.ToolStripMenuItem();
            this.provjeraPotpisaDijalog = new System.Windows.Forms.ToolStripMenuItem();
            this.shaHashDijalog = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ključeviToolStripMenuItem,
            this.kriptografijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ključeviToolStripMenuItem
            // 
            this.ključeviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generirajSimetrciniKljuc,
            this.generirajParAsimetricnihKljuceva});
            this.ključeviToolStripMenuItem.Name = "ključeviToolStripMenuItem";
            this.ključeviToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.ključeviToolStripMenuItem.Text = "Generator ključeva";
            // 
            // generirajSimetrciniKljuc
            // 
            this.generirajSimetrciniKljuc.Name = "generirajSimetrciniKljuc";
            this.generirajSimetrciniKljuc.Size = new System.Drawing.Size(159, 22);
            this.generirajSimetrciniKljuc.Text = "Simetrični";
            this.generirajSimetrciniKljuc.Click += new System.EventHandler(this.generirajSimetrciniKljuc_click);
            // 
            // generirajParAsimetricnihKljuceva
            // 
            this.generirajParAsimetricnihKljuceva.Name = "generirajParAsimetricnihKljuceva";
            this.generirajParAsimetricnihKljuceva.Size = new System.Drawing.Size(159, 22);
            this.generirajParAsimetricnihKljuceva.Text = "Par asimetričnih";
            this.generirajParAsimetricnihKljuceva.Click += new System.EventHandler(this.generirajParAsimetricnihKljuceva_click);
            // 
            // kriptografijaToolStripMenuItem
            // 
            this.kriptografijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aESToolStripMenuItem,
            this.rSAToolStripMenuItem,
            this.digitalniPotpisToolStripMenuItem,
            this.shaHashDijalog});
            this.kriptografijaToolStripMenuItem.Name = "kriptografijaToolStripMenuItem";
            this.kriptografijaToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.kriptografijaToolStripMenuItem.Text = "Kriptografija";
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AesEnkripcijaDijalog,
            this.AesDekripcijaDijalog});
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aESToolStripMenuItem.Text = "AES";
            // 
            // AesEnkripcijaDijalog
            // 
            this.AesEnkripcijaDijalog.Name = "AesEnkripcijaDijalog";
            this.AesEnkripcijaDijalog.Size = new System.Drawing.Size(126, 22);
            this.AesEnkripcijaDijalog.Text = "Enkripcija";
            this.AesEnkripcijaDijalog.Click += new System.EventHandler(this.AesEnkripcijaDijalog_click);
            // 
            // AesDekripcijaDijalog
            // 
            this.AesDekripcijaDijalog.Name = "AesDekripcijaDijalog";
            this.AesDekripcijaDijalog.Size = new System.Drawing.Size(126, 22);
            this.AesDekripcijaDijalog.Text = "Dekripcija";
            this.AesDekripcijaDijalog.Click += new System.EventHandler(this.AesDekripcijaDijalog_click);
            // 
            // rSAToolStripMenuItem
            // 
            this.rSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rsaEnkripcijaDijalog,
            this.rsaDekripcijaDijalog});
            this.rSAToolStripMenuItem.Name = "rSAToolStripMenuItem";
            this.rSAToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.rSAToolStripMenuItem.Text = "RSA";
            // 
            // rsaEnkripcijaDijalog
            // 
            this.rsaEnkripcijaDijalog.Name = "rsaEnkripcijaDijalog";
            this.rsaEnkripcijaDijalog.Size = new System.Drawing.Size(126, 22);
            this.rsaEnkripcijaDijalog.Text = "Enkripcija";
            this.rsaEnkripcijaDijalog.Click += new System.EventHandler(this.rsaEnkripcijaDijalog_Click);
            // 
            // rsaDekripcijaDijalog
            // 
            this.rsaDekripcijaDijalog.Name = "rsaDekripcijaDijalog";
            this.rsaDekripcijaDijalog.Size = new System.Drawing.Size(126, 22);
            this.rsaDekripcijaDijalog.Text = "Dekripcija";
            this.rsaDekripcijaDijalog.Click += new System.EventHandler(this.rsaDekripcijaDijalog_Click);
            // 
            // digitalniPotpisToolStripMenuItem
            // 
            this.digitalniPotpisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.digitalnoPotpisivanjeDijalog,
            this.provjeraPotpisaDijalog});
            this.digitalniPotpisToolStripMenuItem.Name = "digitalniPotpisToolStripMenuItem";
            this.digitalniPotpisToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.digitalniPotpisToolStripMenuItem.Text = "Digitalni potpis";
            // 
            // digitalnoPotpisivanjeDijalog
            // 
            this.digitalnoPotpisivanjeDijalog.Name = "digitalnoPotpisivanjeDijalog";
            this.digitalnoPotpisivanjeDijalog.Size = new System.Drawing.Size(229, 22);
            this.digitalnoPotpisivanjeDijalog.Text = "Digitalno potpisivanje";
            this.digitalnoPotpisivanjeDijalog.Click += new System.EventHandler(this.digitalnoPotpisivanjeDijalog_Click);
            // 
            // provjeraPotpisaDijalog
            // 
            this.provjeraPotpisaDijalog.Name = "provjeraPotpisaDijalog";
            this.provjeraPotpisaDijalog.Size = new System.Drawing.Size(229, 22);
            this.provjeraPotpisaDijalog.Text = "Provjera autentičnosti poruke";
            this.provjeraPotpisaDijalog.Click += new System.EventHandler(this.provjeraPotpisaDijalog_Click);
            // 
            // shaHashDijalog
            // 
            this.shaHashDijalog.Name = "shaHashDijalog";
            this.shaHashDijalog.Size = new System.Drawing.Size(154, 22);
            this.shaHashDijalog.Text = "SHA-2 Hash";
            this.shaHashDijalog.Click += new System.EventHandler(this.shaHashDijalog_Click);
            // 
            // Pocetna_forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OS2_Kriptografija.Properties.Resources.bgImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(413, 426);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pocetna_forma";
            this.Text = "OS2 kriptografija";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ključeviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generirajSimetrciniKljuc;
        private System.Windows.Forms.ToolStripMenuItem generirajParAsimetricnihKljuceva;
        private System.Windows.Forms.ToolStripMenuItem kriptografijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AesEnkripcijaDijalog;
        private System.Windows.Forms.ToolStripMenuItem AesDekripcijaDijalog;
        private System.Windows.Forms.ToolStripMenuItem rSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rsaEnkripcijaDijalog;
        private System.Windows.Forms.ToolStripMenuItem rsaDekripcijaDijalog;
        private System.Windows.Forms.ToolStripMenuItem shaHashDijalog;
        private System.Windows.Forms.ToolStripMenuItem digitalniPotpisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalnoPotpisivanjeDijalog;
        private System.Windows.Forms.ToolStripMenuItem provjeraPotpisaDijalog;
    }
}

