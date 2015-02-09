namespace OS2_Kriptografija
{
    partial class RSADijalog
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
            this.enkriptirajDekriptiraj_btn = new System.Windows.Forms.Button();
            this.odaberiKljuc_btn = new System.Windows.Forms.Button();
            this.odaberiTekst_btn = new System.Windows.Forms.Button();
            this.rsaPorukaPutanja_textbox = new System.Windows.Forms.TextBox();
            this.tekst_label = new System.Windows.Forms.Label();
            this.rsaPutanjaKljuca_textbox = new System.Windows.Forms.TextBox();
            this.vrstaKljuca_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enkriptirajDekriptiraj_btn
            // 
            this.enkriptirajDekriptiraj_btn.Location = new System.Drawing.Point(230, 94);
            this.enkriptirajDekriptiraj_btn.Name = "enkriptirajDekriptiraj_btn";
            this.enkriptirajDekriptiraj_btn.Size = new System.Drawing.Size(75, 23);
            this.enkriptirajDekriptiraj_btn.TabIndex = 13;
            this.enkriptirajDekriptiraj_btn.Text = "%EncDec%";
            this.enkriptirajDekriptiraj_btn.UseVisualStyleBackColor = true;
            this.enkriptirajDekriptiraj_btn.Click += new System.EventHandler(this.enkriptirajDekriptiraj_btn_Click);
            // 
            // odaberiKljuc_btn
            // 
            this.odaberiKljuc_btn.Location = new System.Drawing.Point(394, 12);
            this.odaberiKljuc_btn.Name = "odaberiKljuc_btn";
            this.odaberiKljuc_btn.Size = new System.Drawing.Size(75, 23);
            this.odaberiKljuc_btn.TabIndex = 9;
            this.odaberiKljuc_btn.Text = "Odaberite";
            this.odaberiKljuc_btn.UseVisualStyleBackColor = true;
            this.odaberiKljuc_btn.Click += new System.EventHandler(this.odaberiKljuc_btn_Click);
            // 
            // odaberiTekst_btn
            // 
            this.odaberiTekst_btn.Location = new System.Drawing.Point(394, 53);
            this.odaberiTekst_btn.Name = "odaberiTekst_btn";
            this.odaberiTekst_btn.Size = new System.Drawing.Size(75, 23);
            this.odaberiTekst_btn.TabIndex = 11;
            this.odaberiTekst_btn.Text = "Odaberite";
            this.odaberiTekst_btn.UseVisualStyleBackColor = true;
            this.odaberiTekst_btn.Click += new System.EventHandler(this.odaberiTekst_btn_Click);
            // 
            // rsaPorukaPutanja_textbox
            // 
            this.rsaPorukaPutanja_textbox.Location = new System.Drawing.Point(123, 53);
            this.rsaPorukaPutanja_textbox.Name = "rsaPorukaPutanja_textbox";
            this.rsaPorukaPutanja_textbox.ReadOnly = true;
            this.rsaPorukaPutanja_textbox.Size = new System.Drawing.Size(265, 20);
            this.rsaPorukaPutanja_textbox.TabIndex = 12;
            // 
            // tekst_label
            // 
            this.tekst_label.AutoSize = true;
            this.tekst_label.Location = new System.Drawing.Point(13, 56);
            this.tekst_label.Name = "tekst_label";
            this.tekst_label.Size = new System.Drawing.Size(50, 13);
            this.tekst_label.TabIndex = 4;
            this.tekst_label.Text = "%Tekst%";
            // 
            // rsaPutanjaKljuca_textbox
            // 
            this.rsaPutanjaKljuca_textbox.Location = new System.Drawing.Point(123, 12);
            this.rsaPutanjaKljuca_textbox.Name = "rsaPutanjaKljuca_textbox";
            this.rsaPutanjaKljuca_textbox.ReadOnly = true;
            this.rsaPutanjaKljuca_textbox.Size = new System.Drawing.Size(265, 20);
            this.rsaPutanjaKljuca_textbox.TabIndex = 5;
            // 
            // vrstaKljuca_label
            // 
            this.vrstaKljuca_label.AutoSize = true;
            this.vrstaKljuca_label.Location = new System.Drawing.Point(12, 15);
            this.vrstaKljuca_label.Name = "vrstaKljuca_label";
            this.vrstaKljuca_label.Size = new System.Drawing.Size(76, 13);
            this.vrstaKljuca_label.TabIndex = 7;
            this.vrstaKljuca_label.Text = "%VrstaKljuca%";
            // 
            // RSADijalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 136);
            this.Controls.Add(this.enkriptirajDekriptiraj_btn);
            this.Controls.Add(this.odaberiKljuc_btn);
            this.Controls.Add(this.odaberiTekst_btn);
            this.Controls.Add(this.rsaPorukaPutanja_textbox);
            this.Controls.Add(this.tekst_label);
            this.Controls.Add(this.rsaPutanjaKljuca_textbox);
            this.Controls.Add(this.vrstaKljuca_label);
            this.Name = "RSADijalog";
            this.Text = "RSA Enkripcija/Dekripcija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enkriptirajDekriptiraj_btn;
        private System.Windows.Forms.Button odaberiKljuc_btn;
        private System.Windows.Forms.Button odaberiTekst_btn;
        private System.Windows.Forms.TextBox rsaPorukaPutanja_textbox;
        private System.Windows.Forms.Label tekst_label;
        private System.Windows.Forms.TextBox rsaPutanjaKljuca_textbox;
        private System.Windows.Forms.Label vrstaKljuca_label;
    }
}