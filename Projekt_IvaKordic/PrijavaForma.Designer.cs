
namespace Projekt_IvaKordic
{
    partial class PrijavaForma
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.btnPrijavaDoktora = new System.Windows.Forms.Button();
            this.btnPrijavaPacijenta = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(102, 121);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(230, 22);
            this.tbIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRIJAVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime:";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(104, 224);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(230, 22);
            this.tbPrezime.TabIndex = 3;
            // 
            // btnPrijavaDoktora
            // 
            this.btnPrijavaDoktora.Location = new System.Drawing.Point(233, 277);
            this.btnPrijavaDoktora.Name = "btnPrijavaDoktora";
            this.btnPrijavaDoktora.Size = new System.Drawing.Size(99, 42);
            this.btnPrijavaDoktora.TabIndex = 5;
            this.btnPrijavaDoktora.Text = "Prijava doktora";
            this.btnPrijavaDoktora.UseVisualStyleBackColor = true;
            this.btnPrijavaDoktora.Click += new System.EventHandler(this.btnPrijavaDoktora_Click);
            // 
            // btnPrijavaPacijenta
            // 
            this.btnPrijavaPacijenta.Location = new System.Drawing.Point(104, 277);
            this.btnPrijavaPacijenta.Name = "btnPrijavaPacijenta";
            this.btnPrijavaPacijenta.Size = new System.Drawing.Size(99, 42);
            this.btnPrijavaPacijenta.TabIndex = 6;
            this.btnPrijavaPacijenta.Text = "Prijava pacijenta";
            this.btnPrijavaPacijenta.UseVisualStyleBackColor = true;
            this.btnPrijavaPacijenta.Click += new System.EventHandler(this.btnPrijavaPacijenta_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(163, 346);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(99, 42);
            this.btnRegistracija.TabIndex = 7;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // PrijavaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnPrijavaPacijenta);
            this.Controls.Add(this.btnPrijavaDoktora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIme);
            this.Name = "PrijavaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.Button btnPrijavaDoktora;
        private System.Windows.Forms.Button btnPrijavaPacijenta;
        private System.Windows.Forms.Button btnRegistracija;
    }
}

