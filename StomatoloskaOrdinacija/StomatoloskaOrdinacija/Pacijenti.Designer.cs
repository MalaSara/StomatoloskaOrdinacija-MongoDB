
namespace StomatoloskaOrdinacija
{
    partial class Pacijenti
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
            System.Windows.Forms.ColumnHeader columnHeader1;
            this.lvPacijenti = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiPacijenta = new System.Windows.Forms.Button();
            this.btnAzurirajIntervencije = new System.Windows.Forms.Button();
            this.btnAzurirajBolesti = new System.Windows.Forms.Button();
            this.tbIntervencija = new System.Windows.Forms.TextBox();
            this.tbBolest = new System.Windows.Forms.TextBox();
            this.btnPrikaziSve = new System.Windows.Forms.Button();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvPacijenti
            // 
            this.lvPacijenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPacijenti.HideSelection = false;
            this.lvPacijenti.Location = new System.Drawing.Point(12, 12);
            this.lvPacijenti.Name = "lvPacijenti";
            this.lvPacijenti.Size = new System.Drawing.Size(418, 229);
            this.lvPacijenti.TabIndex = 0;
            this.lvPacijenti.UseCompatibleStateImageBehavior = false;
            this.lvPacijenti.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Broj kartona";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.Width = 83;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Datum rodjenja";
            this.columnHeader5.Width = 107;
            // 
            // btnObrisiPacijenta
            // 
            this.btnObrisiPacijenta.Location = new System.Drawing.Point(466, 12);
            this.btnObrisiPacijenta.Name = "btnObrisiPacijenta";
            this.btnObrisiPacijenta.Size = new System.Drawing.Size(136, 23);
            this.btnObrisiPacijenta.TabIndex = 1;
            this.btnObrisiPacijenta.Text = "Obrisi pacijenta";
            this.btnObrisiPacijenta.UseVisualStyleBackColor = true;
            this.btnObrisiPacijenta.Click += new System.EventHandler(this.btnObrisiPacijenta_Click);
            // 
            // btnAzurirajIntervencije
            // 
            this.btnAzurirajIntervencije.Location = new System.Drawing.Point(629, 54);
            this.btnAzurirajIntervencije.Name = "btnAzurirajIntervencije";
            this.btnAzurirajIntervencije.Size = new System.Drawing.Size(127, 23);
            this.btnAzurirajIntervencije.TabIndex = 2;
            this.btnAzurirajIntervencije.Text = "Azuriraj intervencije";
            this.btnAzurirajIntervencije.UseVisualStyleBackColor = true;
            this.btnAzurirajIntervencije.Click += new System.EventHandler(this.btnAzurirajIntervencije_Click);
            // 
            // btnAzurirajBolesti
            // 
            this.btnAzurirajBolesti.Location = new System.Drawing.Point(629, 97);
            this.btnAzurirajBolesti.Name = "btnAzurirajBolesti";
            this.btnAzurirajBolesti.Size = new System.Drawing.Size(127, 23);
            this.btnAzurirajBolesti.TabIndex = 3;
            this.btnAzurirajBolesti.Text = "Azuriraj bolesti";
            this.btnAzurirajBolesti.UseVisualStyleBackColor = true;
            this.btnAzurirajBolesti.Click += new System.EventHandler(this.btnAzurirajBolesti_Click);
            // 
            // tbIntervencija
            // 
            this.tbIntervencija.Location = new System.Drawing.Point(466, 57);
            this.tbIntervencija.Name = "tbIntervencija";
            this.tbIntervencija.Size = new System.Drawing.Size(136, 20);
            this.tbIntervencija.TabIndex = 4;
            // 
            // tbBolest
            // 
            this.tbBolest.Location = new System.Drawing.Point(466, 97);
            this.tbBolest.Name = "tbBolest";
            this.tbBolest.Size = new System.Drawing.Size(136, 20);
            this.tbBolest.TabIndex = 5;
            // 
            // btnPrikaziSve
            // 
            this.btnPrikaziSve.Location = new System.Drawing.Point(466, 159);
            this.btnPrikaziSve.Name = "btnPrikaziSve";
            this.btnPrikaziSve.Size = new System.Drawing.Size(290, 23);
            this.btnPrikaziSve.TabIndex = 6;
            this.btnPrikaziSve.Text = "Prikazi sve podatke o zeljenom pacijentu";
            this.btnPrikaziSve.UseVisualStyleBackColor = true;
            this.btnPrikaziSve.Click += new System.EventHandler(this.btnPrikaziSve_Click);
            // 
            // Pacijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikaziSve);
            this.Controls.Add(this.tbBolest);
            this.Controls.Add(this.tbIntervencija);
            this.Controls.Add(this.btnAzurirajBolesti);
            this.Controls.Add(this.btnAzurirajIntervencije);
            this.Controls.Add(this.btnObrisiPacijenta);
            this.Controls.Add(this.lvPacijenti);
            this.Name = "Pacijenti";
            this.Text = "Pacijenti";
            this.Load += new System.EventHandler(this.Pacijenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPacijenti;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnObrisiPacijenta;
        private System.Windows.Forms.Button btnAzurirajIntervencije;
        private System.Windows.Forms.Button btnAzurirajBolesti;
        private System.Windows.Forms.TextBox tbIntervencija;
        private System.Windows.Forms.TextBox tbBolest;
        private System.Windows.Forms.Button btnPrikaziSve;
    }
}