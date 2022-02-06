
namespace Projekt_IvaKordic
{
    partial class DodajPacijentaForma
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
            this.dgvSviPacijenti = new System.Windows.Forms.DataGridView();
            this.btnDodajPacijenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviPacijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviPacijenti
            // 
            this.dgvSviPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviPacijenti.Location = new System.Drawing.Point(20, 36);
            this.dgvSviPacijenti.Name = "dgvSviPacijenti";
            this.dgvSviPacijenti.RowHeadersWidth = 51;
            this.dgvSviPacijenti.RowTemplate.Height = 24;
            this.dgvSviPacijenti.Size = new System.Drawing.Size(760, 318);
            this.dgvSviPacijenti.TabIndex = 0;
            // 
            // btnDodajPacijenta
            // 
            this.btnDodajPacijenta.Location = new System.Drawing.Point(666, 360);
            this.btnDodajPacijenta.Name = "btnDodajPacijenta";
            this.btnDodajPacijenta.Size = new System.Drawing.Size(114, 58);
            this.btnDodajPacijenta.TabIndex = 1;
            this.btnDodajPacijenta.Text = "Dodaj pacijenta";
            this.btnDodajPacijenta.UseVisualStyleBackColor = true;
            this.btnDodajPacijenta.Click += new System.EventHandler(this.btnDodajPacijenta_Click);
            // 
            // DodajPacijentaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.btnDodajPacijenta);
            this.Controls.Add(this.dgvSviPacijenti);
            this.Name = "DodajPacijentaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajPacijentaForma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviPacijenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviPacijenti;
        private System.Windows.Forms.Button btnDodajPacijenta;
    }
}