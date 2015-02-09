namespace OS2_Kriptografija
{
    partial class DigitalniPotpis
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
            this.odaberiKljuc_btn = new System.Windows.Forms.Button();
            this.putanjaKljuca_textbox = new System.Windows.Forms.TextBox();
            this.vrstaKljuca_label = new System.Windows.Forms.Label();
            this.potpisi_btn = new System.Windows.Forms.Button();
            this.odaberiPoruku_btn = new System.Windows.Forms.Button();
            this.porukaPutanja_textbox = new System.Windows.Forms.TextBox();
            this.tekst_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.provjeraPotpisa_group = new System.Windows.Forms.GroupBox();
            this.valjanostPotpisa_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.provjeraPotpisa_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // odaberiKljuc_btn
            // 
            this.odaberiKljuc_btn.Location = new System.Drawing.Point(391, 12);
            this.odaberiKljuc_btn.Name = "odaberiKljuc_btn";
            this.odaberiKljuc_btn.Size = new System.Drawing.Size(75, 23);
            this.odaberiKljuc_btn.TabIndex = 12;
            this.odaberiKljuc_btn.Text = "Odaberite";
            this.odaberiKljuc_btn.UseVisualStyleBackColor = true;
            this.odaberiKljuc_btn.Click += new System.EventHandler(this.odaberiKljuc_btn_Click);
            // 
            // putanjaKljuca_textbox
            // 
            this.putanjaKljuca_textbox.Location = new System.Drawing.Point(120, 12);
            this.putanjaKljuca_textbox.Name = "putanjaKljuca_textbox";
            this.putanjaKljuca_textbox.ReadOnly = true;
            this.putanjaKljuca_textbox.Size = new System.Drawing.Size(265, 20);
            this.putanjaKljuca_textbox.TabIndex = 10;
            // 
            // vrstaKljuca_label
            // 
            this.vrstaKljuca_label.AutoSize = true;
            this.vrstaKljuca_label.Location = new System.Drawing.Point(9, 15);
            this.vrstaKljuca_label.Name = "vrstaKljuca_label";
            this.vrstaKljuca_label.Size = new System.Drawing.Size(76, 13);
            this.vrstaKljuca_label.TabIndex = 11;
            this.vrstaKljuca_label.Text = "%VrstaKljuca%";
            // 
            // potpisi_btn
            // 
            this.potpisi_btn.Location = new System.Drawing.Point(120, 108);
            this.potpisi_btn.Name = "potpisi_btn";
            this.potpisi_btn.Size = new System.Drawing.Size(96, 23);
            this.potpisi_btn.TabIndex = 17;
            this.potpisi_btn.Text = "Digitalno potpiši";
            this.potpisi_btn.UseVisualStyleBackColor = true;
            this.potpisi_btn.Click += new System.EventHandler(this.potpisi_btn_Click);
            // 
            // odaberiPoruku_btn
            // 
            this.odaberiPoruku_btn.Location = new System.Drawing.Point(391, 59);
            this.odaberiPoruku_btn.Name = "odaberiPoruku_btn";
            this.odaberiPoruku_btn.Size = new System.Drawing.Size(75, 23);
            this.odaberiPoruku_btn.TabIndex = 15;
            this.odaberiPoruku_btn.Text = "Odaberite";
            this.odaberiPoruku_btn.UseVisualStyleBackColor = true;
            this.odaberiPoruku_btn.Click += new System.EventHandler(this.odaberiPoruku_btn_Click);
            // 
            // porukaPutanja_textbox
            // 
            this.porukaPutanja_textbox.Location = new System.Drawing.Point(120, 59);
            this.porukaPutanja_textbox.Name = "porukaPutanja_textbox";
            this.porukaPutanja_textbox.ReadOnly = true;
            this.porukaPutanja_textbox.Size = new System.Drawing.Size(265, 20);
            this.porukaPutanja_textbox.TabIndex = 16;
            // 
            // tekst_label
            // 
            this.tekst_label.AutoSize = true;
            this.tekst_label.Location = new System.Drawing.Point(10, 62);
            this.tekst_label.Name = "tekst_label";
            this.tekst_label.Size = new System.Drawing.Size(90, 13);
            this.tekst_label.TabIndex = 14;
            this.tekst_label.Text = "Originalna poruka";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Provjera digitalnog potpisa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // provjeraPotpisa_group
            // 
            this.provjeraPotpisa_group.Controls.Add(this.valjanostPotpisa_label);
            this.provjeraPotpisa_group.Controls.Add(this.label1);
            this.provjeraPotpisa_group.Controls.Add(this.button1);
            this.provjeraPotpisa_group.Location = new System.Drawing.Point(274, 108);
            this.provjeraPotpisa_group.Name = "provjeraPotpisa_group";
            this.provjeraPotpisa_group.Size = new System.Drawing.Size(192, 121);
            this.provjeraPotpisa_group.TabIndex = 18;
            this.provjeraPotpisa_group.TabStop = false;
            this.provjeraPotpisa_group.Text = "Provjera digitalnog potpisa";
            // 
            // valjanostPotpisa_label
            // 
            this.valjanostPotpisa_label.AutoSize = true;
            this.valjanostPotpisa_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.valjanostPotpisa_label.Location = new System.Drawing.Point(6, 85);
            this.valjanostPotpisa_label.Name = "valjanostPotpisa_label";
            this.valjanostPotpisa_label.Size = new System.Drawing.Size(156, 25);
            this.valjanostPotpisa_label.TabIndex = 19;
            this.valjanostPotpisa_label.Text = "(nije provjeren)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Valjanost digitalnog potpisa:";
            // 
            // DigitalniPotpis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 241);
            this.Controls.Add(this.provjeraPotpisa_group);
            this.Controls.Add(this.potpisi_btn);
            this.Controls.Add(this.odaberiPoruku_btn);
            this.Controls.Add(this.porukaPutanja_textbox);
            this.Controls.Add(this.tekst_label);
            this.Controls.Add(this.odaberiKljuc_btn);
            this.Controls.Add(this.putanjaKljuca_textbox);
            this.Controls.Add(this.vrstaKljuca_label);
            this.Name = "DigitalniPotpis";
            this.Text = "Digitalno potpisivanje";
            this.provjeraPotpisa_group.ResumeLayout(false);
            this.provjeraPotpisa_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odaberiKljuc_btn;
        private System.Windows.Forms.TextBox putanjaKljuca_textbox;
        private System.Windows.Forms.Label vrstaKljuca_label;
        private System.Windows.Forms.Button potpisi_btn;
        private System.Windows.Forms.Button odaberiPoruku_btn;
        private System.Windows.Forms.TextBox porukaPutanja_textbox;
        private System.Windows.Forms.Label tekst_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox provjeraPotpisa_group;
        private System.Windows.Forms.Label valjanostPotpisa_label;
        private System.Windows.Forms.Label label1;
    }
}