
namespace Projekt_IvaKordic
{
    partial class GlavnaFormaDoktor
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
            this.btnPregledi = new System.Windows.Forms.Button();
            this.btnDnevnik = new System.Windows.Forms.Button();
            this.btnTromjesjecja = new System.Windows.Forms.Button();
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrijavljeniDoktor = new System.Windows.Forms.Label();
            this.btnNoviPacijent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPregledi
            // 
            this.btnPregledi.Location = new System.Drawing.Point(1361, 64);
            this.btnPregledi.Name = "btnPregledi";
            this.btnPregledi.Size = new System.Drawing.Size(128, 41);
            this.btnPregledi.TabIndex = 0;
            this.btnPregledi.Text = "Pregledi";
            this.btnPregledi.UseVisualStyleBackColor = true;
            this.btnPregledi.Click += new System.EventHandler(this.btnPregledi_Click);
            // 
            // btnDnevnik
            // 
            this.btnDnevnik.Location = new System.Drawing.Point(1361, 131);
            this.btnDnevnik.Name = "btnDnevnik";
            this.btnDnevnik.Size = new System.Drawing.Size(128, 41);
            this.btnDnevnik.TabIndex = 1;
            this.btnDnevnik.Text = "Dnevnik";
            this.btnDnevnik.UseVisualStyleBackColor = true;
            this.btnDnevnik.Click += new System.EventHandler(this.btnDnevnik_Click);
            // 
            // btnTromjesjecja
            // 
            this.btnTromjesjecja.Location = new System.Drawing.Point(1361, 198);
            this.btnTromjesjecja.Name = "btnTromjesjecja";
            this.btnTromjesjecja.Size = new System.Drawing.Size(128, 41);
            this.btnTromjesjecja.TabIndex = 3;
            this.btnTromjesjecja.Text = "Tromjesječja";
            this.btnTromjesjecja.UseVisualStyleBackColor = true;
            this.btnTromjesjecja.Click += new System.EventHandler(this.btnTromjesjecja_Click);
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Location = new System.Drawing.Point(12, 64);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.RowHeadersWidth = 51;
            this.dgvPacijenti.RowTemplate.Height = 24;
            this.dgvPacijenti.Size = new System.Drawing.Size(1343, 451);
            this.dgvPacijenti.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prijavljeni doktor:";
            // 
            // lblPrijavljeniDoktor
            // 
            this.lblPrijavljeniDoktor.AutoSize = true;
            this.lblPrijavljeniDoktor.Location = new System.Drawing.Point(134, 9);
            this.lblPrijavljeniDoktor.Name = "lblPrijavljeniDoktor";
            this.lblPrijavljeniDoktor.Size = new System.Drawing.Size(0, 17);
            this.lblPrijavljeniDoktor.TabIndex = 6;
            // 
            // btnNoviPacijent
            // 
            this.btnNoviPacijent.Location = new System.Drawing.Point(1361, 474);
            this.btnNoviPacijent.Name = "btnNoviPacijent";
            this.btnNoviPacijent.Size = new System.Drawing.Size(128, 41);
            this.btnNoviPacijent.TabIndex = 7;
            this.btnNoviPacijent.Text = "Novi pacijent";
            this.btnNoviPacijent.UseVisualStyleBackColor = true;
            this.btnNoviPacijent.Click += new System.EventHandler(this.btnNoviPacijent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(71, 41);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 10;
            // 
            // GlavnaFormaDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 527);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNoviPacijent);
            this.Controls.Add(this.lblPrijavljeniDoktor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPacijenti);
            this.Controls.Add(this.btnTromjesjecja);
            this.Controls.Add(this.btnDnevnik);
            this.Controls.Add(this.btnPregledi);
            this.Name = "GlavnaFormaDoktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnaFormaDoktor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregledi;
        private System.Windows.Forms.Button btnDnevnik;
        private System.Windows.Forms.Button btnTromjesjecja;
        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrijavljeniDoktor;
        private System.Windows.Forms.Button btnNoviPacijent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDatum;
    }
}