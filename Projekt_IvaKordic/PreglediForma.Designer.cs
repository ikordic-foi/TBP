
namespace Projekt_IvaKordic
{
    partial class PreglediForma
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblPacijent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvZakazaniPregledi = new System.Windows.Forms.DataGridView();
            this.btnZakaziPregled = new System.Windows.Forms.Button();
            this.btnObaviPregled = new System.Windows.Forms.Button();
            this.dgvKilaze = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOpsezi = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvMjere = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakazaniPregledi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKilaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpsezi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjere)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(71, 41);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datum:";
            // 
            // lblPacijent
            // 
            this.lblPacijent.AutoSize = true;
            this.lblPacijent.Location = new System.Drawing.Point(134, 9);
            this.lblPacijent.Name = "lblPacijent";
            this.lblPacijent.Size = new System.Drawing.Size(0, 17);
            this.lblPacijent.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Odabrani pacijent:";
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledi.Location = new System.Drawing.Point(12, 95);
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.RowHeadersWidth = 51;
            this.dgvPregledi.RowTemplate.Height = 24;
            this.dgvPregledi.Size = new System.Drawing.Size(482, 254);
            this.dgvPregledi.TabIndex = 15;
            this.dgvPregledi.SelectionChanged += new System.EventHandler(this.dgvPregledi_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Obavljeni pregledi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Zakazani pregledi";
            // 
            // dgvZakazaniPregledi
            // 
            this.dgvZakazaniPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakazaniPregledi.Location = new System.Drawing.Point(511, 95);
            this.dgvZakazaniPregledi.Name = "dgvZakazaniPregledi";
            this.dgvZakazaniPregledi.RowHeadersWidth = 51;
            this.dgvZakazaniPregledi.RowTemplate.Height = 24;
            this.dgvZakazaniPregledi.Size = new System.Drawing.Size(337, 254);
            this.dgvZakazaniPregledi.TabIndex = 17;
            // 
            // btnZakaziPregled
            // 
            this.btnZakaziPregled.Location = new System.Drawing.Point(720, 355);
            this.btnZakaziPregled.Name = "btnZakaziPregled";
            this.btnZakaziPregled.Size = new System.Drawing.Size(128, 41);
            this.btnZakaziPregled.TabIndex = 20;
            this.btnZakaziPregled.Text = "Zakaži pregled";
            this.btnZakaziPregled.UseVisualStyleBackColor = true;
            this.btnZakaziPregled.Click += new System.EventHandler(this.btnZakaziPregled_Click);
            // 
            // btnObaviPregled
            // 
            this.btnObaviPregled.Location = new System.Drawing.Point(366, 355);
            this.btnObaviPregled.Name = "btnObaviPregled";
            this.btnObaviPregled.Size = new System.Drawing.Size(128, 41);
            this.btnObaviPregled.TabIndex = 21;
            this.btnObaviPregled.Text = "Obavi pregled";
            this.btnObaviPregled.UseVisualStyleBackColor = true;
            this.btnObaviPregled.Click += new System.EventHandler(this.btnObaviPregled_Click);
            // 
            // dgvKilaze
            // 
            this.dgvKilaze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKilaze.Location = new System.Drawing.Point(12, 450);
            this.dgvKilaze.Name = "dgvKilaze";
            this.dgvKilaze.RowHeadersWidth = 51;
            this.dgvKilaze.RowTemplate.Height = 24;
            this.dgvKilaze.Size = new System.Drawing.Size(343, 254);
            this.dgvKilaze.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Povijest kilaže";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Povijest opsega";
            // 
            // dgvOpsezi
            // 
            this.dgvOpsezi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOpsezi.Location = new System.Drawing.Point(364, 450);
            this.dgvOpsezi.Name = "dgvOpsezi";
            this.dgvOpsezi.RowHeadersWidth = 51;
            this.dgvOpsezi.RowTemplate.Height = 24;
            this.dgvOpsezi.Size = new System.Drawing.Size(343, 254);
            this.dgvOpsezi.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Informacije o plodu";
            // 
            // dgvMjere
            // 
            this.dgvMjere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMjere.Location = new System.Drawing.Point(716, 450);
            this.dgvMjere.Name = "dgvMjere";
            this.dgvMjere.RowHeadersWidth = 51;
            this.dgvMjere.RowTemplate.Height = 24;
            this.dgvMjere.Size = new System.Drawing.Size(343, 254);
            this.dgvMjere.TabIndex = 26;
            // 
            // PreglediForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 884);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvMjere);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvOpsezi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvKilaze);
            this.Controls.Add(this.btnObaviPregled);
            this.Controls.Add(this.btnZakaziPregled);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvZakazaniPregledi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvPregledi);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPacijent);
            this.Controls.Add(this.label1);
            this.Name = "PreglediForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreglediForma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakazaniPregledi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKilaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOpsezi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMjere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvZakazaniPregledi;
        private System.Windows.Forms.Button btnZakaziPregled;
        private System.Windows.Forms.Button btnObaviPregled;
        private System.Windows.Forms.DataGridView dgvKilaze;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOpsezi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvMjere;
    }
}