
namespace Projekt_IvaKordic
{
    partial class DnevnikForma
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPacijent = new System.Windows.Forms.Label();
            this.lblLabelPacijenta = new System.Windows.Forms.Label();
            this.dgvZapisiDnevnika = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDetaljniOpis = new System.Windows.Forms.RichTextBox();
            this.btnNoviZapis = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZapisiDnevnika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(71, 41);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Datum:";
            // 
            // lblPacijent
            // 
            this.lblPacijent.AutoSize = true;
            this.lblPacijent.Location = new System.Drawing.Point(134, 9);
            this.lblPacijent.Name = "lblPacijent";
            this.lblPacijent.Size = new System.Drawing.Size(0, 17);
            this.lblPacijent.TabIndex = 17;
            // 
            // lblLabelPacijenta
            // 
            this.lblLabelPacijenta.AutoSize = true;
            this.lblLabelPacijenta.Location = new System.Drawing.Point(12, 9);
            this.lblLabelPacijenta.Name = "lblLabelPacijenta";
            this.lblLabelPacijenta.Size = new System.Drawing.Size(124, 17);
            this.lblLabelPacijenta.TabIndex = 16;
            this.lblLabelPacijenta.Text = "Odabrani pacijent:";
            // 
            // dgvZapisiDnevnika
            // 
            this.dgvZapisiDnevnika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZapisiDnevnika.Location = new System.Drawing.Point(12, 90);
            this.dgvZapisiDnevnika.Name = "dgvZapisiDnevnika";
            this.dgvZapisiDnevnika.RowHeadersWidth = 51;
            this.dgvZapisiDnevnika.RowTemplate.Height = 24;
            this.dgvZapisiDnevnika.Size = new System.Drawing.Size(348, 247);
            this.dgvZapisiDnevnika.TabIndex = 20;
            this.dgvZapisiDnevnika.SelectionChanged += new System.EventHandler(this.dgvZapisiDnevnika_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Zapisi u dnevnik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Detaljni zapis";
            // 
            // rtbDetaljniOpis
            // 
            this.rtbDetaljniOpis.Enabled = false;
            this.rtbDetaljniOpis.Location = new System.Drawing.Point(385, 90);
            this.rtbDetaljniOpis.Name = "rtbDetaljniOpis";
            this.rtbDetaljniOpis.ReadOnly = true;
            this.rtbDetaljniOpis.Size = new System.Drawing.Size(365, 247);
            this.rtbDetaljniOpis.TabIndex = 23;
            this.rtbDetaljniOpis.Text = "";
            // 
            // btnNoviZapis
            // 
            this.btnNoviZapis.Location = new System.Drawing.Point(660, 343);
            this.btnNoviZapis.Name = "btnNoviZapis";
            this.btnNoviZapis.Size = new System.Drawing.Size(90, 36);
            this.btnNoviZapis.TabIndex = 24;
            this.btnNoviZapis.Text = "Novi zapis";
            this.btnNoviZapis.UseVisualStyleBackColor = true;
            this.btnNoviZapis.Click += new System.EventHandler(this.btnNoviZapis_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(385, 343);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(131, 36);
            this.btnSpremi.TabIndex = 25;
            this.btnSpremi.Text = "Spremi izmjene";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // DnevnikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 388);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnNoviZapis);
            this.Controls.Add(this.rtbDetaljniOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZapisiDnevnika);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPacijent);
            this.Controls.Add(this.lblLabelPacijenta);
            this.Name = "DnevnikForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DnevnikForma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZapisiDnevnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPacijent;
        private System.Windows.Forms.Label lblLabelPacijenta;
        private System.Windows.Forms.DataGridView dgvZapisiDnevnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDetaljniOpis;
        private System.Windows.Forms.Button btnNoviZapis;
        private System.Windows.Forms.Button btnSpremi;
    }
}