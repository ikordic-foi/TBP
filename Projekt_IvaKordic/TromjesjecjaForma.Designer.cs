
namespace Projekt_IvaKordic
{
    partial class TromjesjecjaForma
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
            this.dgvTromjesjecja = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbDetaljniOpis = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTromjesjecja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(71, 41);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Datum:";
            // 
            // lblPacijent
            // 
            this.lblPacijent.AutoSize = true;
            this.lblPacijent.Location = new System.Drawing.Point(134, 9);
            this.lblPacijent.Name = "lblPacijent";
            this.lblPacijent.Size = new System.Drawing.Size(0, 17);
            this.lblPacijent.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Odabrani pacijent:";
            // 
            // dgvTromjesjecja
            // 
            this.dgvTromjesjecja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTromjesjecja.Location = new System.Drawing.Point(15, 108);
            this.dgvTromjesjecja.Name = "dgvTromjesjecja";
            this.dgvTromjesjecja.RowHeadersWidth = 51;
            this.dgvTromjesjecja.RowTemplate.Height = 24;
            this.dgvTromjesjecja.Size = new System.Drawing.Size(471, 247);
            this.dgvTromjesjecja.TabIndex = 19;
            this.dgvTromjesjecja.SelectionChanged += new System.EventHandler(this.dgvTromjesjecja_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tromjesječja:";
            // 
            // rtbDetaljniOpis
            // 
            this.rtbDetaljniOpis.Location = new System.Drawing.Point(492, 108);
            this.rtbDetaljniOpis.Name = "rtbDetaljniOpis";
            this.rtbDetaljniOpis.Size = new System.Drawing.Size(365, 247);
            this.rtbDetaljniOpis.TabIndex = 25;
            this.rtbDetaljniOpis.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Detaljni zapis";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(769, 361);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(88, 37);
            this.btnSpremi.TabIndex = 26;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // TromjesjecjaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 410);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.rtbDetaljniOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTromjesjecja);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPacijent);
            this.Controls.Add(this.label1);
            this.Name = "TromjesjecjaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TromjesjecjaForma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTromjesjecja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTromjesjecja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbDetaljniOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSpremi;
    }
}