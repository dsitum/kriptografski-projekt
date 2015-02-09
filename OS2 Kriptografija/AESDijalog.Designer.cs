namespace OS2_Kriptografija
{
    partial class AESDijalog
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
            this.label1 = new System.Windows.Forms.Label();
            this.aesIVputanja_textbox = new System.Windows.Forms.TextBox();
            this.odaberiIV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aesKljucPutanja_textbox = new System.Windows.Forms.TextBox();
            this.odaberiKljuc = new System.Windows.Forms.Button();
            this.tekst_label = new System.Windows.Forms.Label();
            this.aesPorukaPutanja_textbox = new System.Windows.Forms.TextBox();
            this.odaberiTekst = new System.Windows.Forms.Button();
            this.enkriptirajDekriptiraj_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicijalizacijski vektor";
            // 
            // aesIVputanja_textbox
            // 
            this.aesIVputanja_textbox.Location = new System.Drawing.Point(123, 35);
            this.aesIVputanja_textbox.Name = "aesIVputanja_textbox";
            this.aesIVputanja_textbox.ReadOnly = true;
            this.aesIVputanja_textbox.Size = new System.Drawing.Size(265, 20);
            this.aesIVputanja_textbox.TabIndex = 0;
            // 
            // odaberiIV
            // 
            this.odaberiIV.Location = new System.Drawing.Point(394, 35);
            this.odaberiIV.Name = "odaberiIV";
            this.odaberiIV.Size = new System.Drawing.Size(75, 23);
            this.odaberiIV.TabIndex = 2;
            this.odaberiIV.Text = "Odaberite";
            this.odaberiIV.UseVisualStyleBackColor = true;
            this.odaberiIV.Click += new System.EventHandler(this.odaberiIV_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Simetrični ključ";
            // 
            // aesKljucPutanja_textbox
            // 
            this.aesKljucPutanja_textbox.Location = new System.Drawing.Point(123, 70);
            this.aesKljucPutanja_textbox.Name = "aesKljucPutanja_textbox";
            this.aesKljucPutanja_textbox.ReadOnly = true;
            this.aesKljucPutanja_textbox.Size = new System.Drawing.Size(265, 20);
            this.aesKljucPutanja_textbox.TabIndex = 1;
            // 
            // odaberiKljuc
            // 
            this.odaberiKljuc.Location = new System.Drawing.Point(394, 70);
            this.odaberiKljuc.Name = "odaberiKljuc";
            this.odaberiKljuc.Size = new System.Drawing.Size(75, 23);
            this.odaberiKljuc.TabIndex = 2;
            this.odaberiKljuc.Text = "Odaberite";
            this.odaberiKljuc.UseVisualStyleBackColor = true;
            this.odaberiKljuc.Click += new System.EventHandler(this.odaberiKljuc_Click);
            // 
            // tekst_label
            // 
            this.tekst_label.AutoSize = true;
            this.tekst_label.Location = new System.Drawing.Point(13, 111);
            this.tekst_label.Name = "tekst_label";
            this.tekst_label.Size = new System.Drawing.Size(50, 13);
            this.tekst_label.TabIndex = 0;
            this.tekst_label.Text = "%Tekst%";
            // 
            // aesPorukaPutanja_textbox
            // 
            this.aesPorukaPutanja_textbox.Location = new System.Drawing.Point(123, 108);
            this.aesPorukaPutanja_textbox.Name = "aesPorukaPutanja_textbox";
            this.aesPorukaPutanja_textbox.ReadOnly = true;
            this.aesPorukaPutanja_textbox.Size = new System.Drawing.Size(265, 20);
            this.aesPorukaPutanja_textbox.TabIndex = 2;
            // 
            // odaberiTekst
            // 
            this.odaberiTekst.Location = new System.Drawing.Point(394, 108);
            this.odaberiTekst.Name = "odaberiTekst";
            this.odaberiTekst.Size = new System.Drawing.Size(75, 23);
            this.odaberiTekst.TabIndex = 2;
            this.odaberiTekst.Text = "Odaberite";
            this.odaberiTekst.UseVisualStyleBackColor = true;
            this.odaberiTekst.Click += new System.EventHandler(this.odaberiTekst_Click);
            // 
            // enkriptirajDekriptiraj_btn
            // 
            this.enkriptirajDekriptiraj_btn.Location = new System.Drawing.Point(216, 163);
            this.enkriptirajDekriptiraj_btn.Name = "enkriptirajDekriptiraj_btn";
            this.enkriptirajDekriptiraj_btn.Size = new System.Drawing.Size(75, 23);
            this.enkriptirajDekriptiraj_btn.TabIndex = 3;
            this.enkriptirajDekriptiraj_btn.Text = "%EncDec%";
            this.enkriptirajDekriptiraj_btn.UseVisualStyleBackColor = true;
            this.enkriptirajDekriptiraj_btn.Click += new System.EventHandler(this.enkriptirajDekriptiraj_btn_Click);
            // 
            // AESDijalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 198);
            this.Controls.Add(this.enkriptirajDekriptiraj_btn);
            this.Controls.Add(this.odaberiIV);
            this.Controls.Add(this.odaberiKljuc);
            this.Controls.Add(this.odaberiTekst);
            this.Controls.Add(this.aesPorukaPutanja_textbox);
            this.Controls.Add(this.aesKljucPutanja_textbox);
            this.Controls.Add(this.tekst_label);
            this.Controls.Add(this.aesIVputanja_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AESDijalog";
            this.Text = "AES enkripcija/dekripcija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aesIVputanja_textbox;
        private System.Windows.Forms.Button odaberiIV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aesKljucPutanja_textbox;
        private System.Windows.Forms.Button odaberiKljuc;
        private System.Windows.Forms.Label tekst_label;
        private System.Windows.Forms.TextBox aesPorukaPutanja_textbox;
        private System.Windows.Forms.Button odaberiTekst;
        private System.Windows.Forms.Button enkriptirajDekriptiraj_btn;
    }
}