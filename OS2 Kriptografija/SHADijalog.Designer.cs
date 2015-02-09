namespace OS2_Kriptografija
{
    partial class SHADijalog
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
            this.odaberiDatoteku_btn = new System.Windows.Forms.Button();
            this.shaPutanjaDoDatoteke_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shaHash_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pohraniHash_btn = new System.Windows.Forms.Button();
            this.izracunajHash_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // odaberiDatoteku_btn
            // 
            this.odaberiDatoteku_btn.Location = new System.Drawing.Point(337, 30);
            this.odaberiDatoteku_btn.Name = "odaberiDatoteku_btn";
            this.odaberiDatoteku_btn.Size = new System.Drawing.Size(75, 23);
            this.odaberiDatoteku_btn.TabIndex = 5;
            this.odaberiDatoteku_btn.Text = "Odaberite";
            this.odaberiDatoteku_btn.UseVisualStyleBackColor = true;
            this.odaberiDatoteku_btn.Click += new System.EventHandler(this.odaberiDatoteku_btn_Click);
            // 
            // shaPutanjaDoDatoteke_textbox
            // 
            this.shaPutanjaDoDatoteke_textbox.Location = new System.Drawing.Point(69, 32);
            this.shaPutanjaDoDatoteke_textbox.Name = "shaPutanjaDoDatoteke_textbox";
            this.shaPutanjaDoDatoteke_textbox.ReadOnly = true;
            this.shaPutanjaDoDatoteke_textbox.Size = new System.Drawing.Size(262, 20);
            this.shaPutanjaDoDatoteke_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datoteka";
            // 
            // shaHash_textbox
            // 
            this.shaHash_textbox.Location = new System.Drawing.Point(94, 87);
            this.shaHash_textbox.Multiline = true;
            this.shaHash_textbox.Name = "shaHash_textbox";
            this.shaHash_textbox.ReadOnly = true;
            this.shaHash_textbox.Size = new System.Drawing.Size(318, 46);
            this.shaHash_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SHA-256 hash";
            // 
            // pohraniHash_btn
            // 
            this.pohraniHash_btn.Location = new System.Drawing.Point(418, 110);
            this.pohraniHash_btn.Name = "pohraniHash_btn";
            this.pohraniHash_btn.Size = new System.Drawing.Size(75, 23);
            this.pohraniHash_btn.TabIndex = 5;
            this.pohraniHash_btn.Text = "Pohrani";
            this.pohraniHash_btn.UseVisualStyleBackColor = true;
            this.pohraniHash_btn.Click += new System.EventHandler(this.pohraniHash_btn_Click);
            // 
            // izracunajHash_button
            // 
            this.izracunajHash_button.Location = new System.Drawing.Point(418, 29);
            this.izracunajHash_button.Name = "izracunajHash_button";
            this.izracunajHash_button.Size = new System.Drawing.Size(75, 23);
            this.izracunajHash_button.TabIndex = 7;
            this.izracunajHash_button.Text = "Izračunaj";
            this.izracunajHash_button.UseVisualStyleBackColor = true;
            this.izracunajHash_button.Click += new System.EventHandler(this.izracunajHash_button_Click);
            // 
            // SHADijalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 145);
            this.Controls.Add(this.izracunajHash_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pohraniHash_btn);
            this.Controls.Add(this.odaberiDatoteku_btn);
            this.Controls.Add(this.shaHash_textbox);
            this.Controls.Add(this.shaPutanjaDoDatoteke_textbox);
            this.Controls.Add(this.label1);
            this.Name = "SHADijalog";
            this.Text = "SHA-256 hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button odaberiDatoteku_btn;
        private System.Windows.Forms.TextBox shaPutanjaDoDatoteke_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shaHash_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pohraniHash_btn;
        private System.Windows.Forms.Button izracunajHash_button;
    }
}