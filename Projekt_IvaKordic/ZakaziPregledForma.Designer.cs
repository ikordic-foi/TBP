
namespace Projekt_IvaKordic
{
    partial class ZakaziPregledForma
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
            this.tbVrsta = new System.Windows.Forms.TextBox();
            this.dtpDatumPregleda = new System.Windows.Forms.DateTimePicker();
            this.lblPacijent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbVrsta
            // 
            this.tbVrsta.Location = new System.Drawing.Point(137, 67);
            this.tbVrsta.Name = "tbVrsta";
            this.tbVrsta.Size = new System.Drawing.Size(129, 22);
            this.tbVrsta.TabIndex = 0;
            // 
            // dtpDatumPregleda
            // 
            this.dtpDatumPregleda.Location = new System.Drawing.Point(137, 109);
            this.dtpDatumPregleda.Name = "dtpDatumPregleda";
            this.dtpDatumPregleda.Size = new System.Drawing.Size(200, 22);
            this.dtpDatumPregleda.TabIndex = 1;
            // 
            // lblPacijent
            // 
            this.lblPacijent.AutoSize = true;
            this.lblPacijent.Location = new System.Drawing.Point(134, 9);
            this.lblPacijent.Name = "lblPacijent";
            this.lblPacijent.Size = new System.Drawing.Size(0, 17);
            this.lblPacijent.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Odabrani pacijent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vrsta pregleda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Datum pregleda:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(119, 164);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(97, 39);
            this.btnSpremi.TabIndex = 17;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // ZakaziPregledForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 215);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPacijent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDatumPregleda);
            this.Controls.Add(this.tbVrsta);
            this.Name = "ZakaziPregledForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZakaziPregledForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVrsta;
        private System.Windows.Forms.DateTimePicker dtpDatumPregleda;
        private System.Windows.Forms.Label lblPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSpremi;
    }
}