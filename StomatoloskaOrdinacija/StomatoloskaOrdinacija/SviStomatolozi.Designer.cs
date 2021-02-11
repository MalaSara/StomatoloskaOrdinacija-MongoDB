
namespace StomatoloskaOrdinacija
{
    partial class SviStomatolozi
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
            this.lstViewStomatolozi = new System.Windows.Forms.ListView();
            this.clmnHdrId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHdrIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHdrPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHdrSpecijalizacija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiStomatologa = new System.Windows.Forms.Button();
            this.btnAzurirajSpecijalizaciju = new System.Windows.Forms.Button();
            this.txtBoxSpecijalizacija = new System.Windows.Forms.TextBox();
            this.btnPrikaziSvePodatkeOZeljenomStomatologu = new System.Windows.Forms.Button();
            this.btnPrikaziSvePodatkeOSvimStomatolozima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewStomatolozi
            // 
            this.lstViewStomatolozi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnHdrId,
            this.clmnHdrIme,
            this.clmnHdrPrezime,
            this.clmnHdrSpecijalizacija});
            this.lstViewStomatolozi.HideSelection = false;
            this.lstViewStomatolozi.Location = new System.Drawing.Point(12, 12);
            this.lstViewStomatolozi.Name = "lstViewStomatolozi";
            this.lstViewStomatolozi.Size = new System.Drawing.Size(377, 220);
            this.lstViewStomatolozi.TabIndex = 1;
            this.lstViewStomatolozi.UseCompatibleStateImageBehavior = false;
            this.lstViewStomatolozi.View = System.Windows.Forms.View.Details;
            // 
            // clmnHdrId
            // 
            this.clmnHdrId.Text = "Id";
            // 
            // clmnHdrIme
            // 
            this.clmnHdrIme.Text = "Ime";
            this.clmnHdrIme.Width = 99;
            // 
            // clmnHdrPrezime
            // 
            this.clmnHdrPrezime.Text = "Prezime";
            this.clmnHdrPrezime.Width = 113;
            // 
            // clmnHdrSpecijalizacija
            // 
            this.clmnHdrSpecijalizacija.Text = "Specijalizacija";
            this.clmnHdrSpecijalizacija.Width = 113;
            // 
            // btnObrisiStomatologa
            // 
            this.btnObrisiStomatologa.Location = new System.Drawing.Point(404, 12);
            this.btnObrisiStomatologa.Name = "btnObrisiStomatologa";
            this.btnObrisiStomatologa.Size = new System.Drawing.Size(119, 23);
            this.btnObrisiStomatologa.TabIndex = 2;
            this.btnObrisiStomatologa.Text = "Obrisi stomatologa";
            this.btnObrisiStomatologa.UseVisualStyleBackColor = true;
            this.btnObrisiStomatologa.Click += new System.EventHandler(this.btnObrisiStomatologa_Click);
            // 
            // btnAzurirajSpecijalizaciju
            // 
            this.btnAzurirajSpecijalizaciju.Location = new System.Drawing.Point(524, 51);
            this.btnAzurirajSpecijalizaciju.Name = "btnAzurirajSpecijalizaciju";
            this.btnAzurirajSpecijalizaciju.Size = new System.Drawing.Size(119, 23);
            this.btnAzurirajSpecijalizaciju.TabIndex = 3;
            this.btnAzurirajSpecijalizaciju.Text = "Azuriraj specijalizaciju";
            this.btnAzurirajSpecijalizaciju.UseVisualStyleBackColor = true;
            this.btnAzurirajSpecijalizaciju.Click += new System.EventHandler(this.btnAzurirajSpecijalizaciju_Click);
            // 
            // txtBoxSpecijalizacija
            // 
            this.txtBoxSpecijalizacija.Location = new System.Drawing.Point(404, 54);
            this.txtBoxSpecijalizacija.Name = "txtBoxSpecijalizacija";
            this.txtBoxSpecijalizacija.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSpecijalizacija.TabIndex = 4;
            // 
            // btnPrikaziSvePodatkeOZeljenomStomatologu
            // 
            this.btnPrikaziSvePodatkeOZeljenomStomatologu.Location = new System.Drawing.Point(404, 97);
            this.btnPrikaziSvePodatkeOZeljenomStomatologu.Name = "btnPrikaziSvePodatkeOZeljenomStomatologu";
            this.btnPrikaziSvePodatkeOZeljenomStomatologu.Size = new System.Drawing.Size(239, 23);
            this.btnPrikaziSvePodatkeOZeljenomStomatologu.TabIndex = 5;
            this.btnPrikaziSvePodatkeOZeljenomStomatologu.Text = "Prikazi sve podatke o zeljenom stomatologu";
            this.btnPrikaziSvePodatkeOZeljenomStomatologu.UseVisualStyleBackColor = true;
            this.btnPrikaziSvePodatkeOZeljenomStomatologu.Click += new System.EventHandler(this.btnPrikaziSvePodatkeOZeljenomStomatologu_Click);
            // 
            // btnPrikaziSvePodatkeOSvimStomatolozima
            // 
            this.btnPrikaziSvePodatkeOSvimStomatolozima.Location = new System.Drawing.Point(404, 136);
            this.btnPrikaziSvePodatkeOSvimStomatolozima.Name = "btnPrikaziSvePodatkeOSvimStomatolozima";
            this.btnPrikaziSvePodatkeOSvimStomatolozima.Size = new System.Drawing.Size(239, 23);
            this.btnPrikaziSvePodatkeOSvimStomatolozima.TabIndex = 6;
            this.btnPrikaziSvePodatkeOSvimStomatolozima.Text = "Prikazi sve podatke o svim stomatolozima";
            this.btnPrikaziSvePodatkeOSvimStomatolozima.UseVisualStyleBackColor = true;
            this.btnPrikaziSvePodatkeOSvimStomatolozima.Click += new System.EventHandler(this.btnPrikaziSvePodatkeOSvimStomatolozima_Click);
            // 
            // SviStomatolozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikaziSvePodatkeOSvimStomatolozima);
            this.Controls.Add(this.btnPrikaziSvePodatkeOZeljenomStomatologu);
            this.Controls.Add(this.txtBoxSpecijalizacija);
            this.Controls.Add(this.btnAzurirajSpecijalizaciju);
            this.Controls.Add(this.btnObrisiStomatologa);
            this.Controls.Add(this.lstViewStomatolozi);
            this.Name = "SviStomatolozi";
            this.Text = "SviStomatolozi";
            this.Load += new System.EventHandler(this.SviStomatolozi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lstViewStomatolozi;
        private System.Windows.Forms.ColumnHeader clmnHdrIme;
        private System.Windows.Forms.ColumnHeader clmnHdrPrezime;
        private System.Windows.Forms.ColumnHeader clmnHdrSpecijalizacija;
        private System.Windows.Forms.Button btnObrisiStomatologa;
        private System.Windows.Forms.ColumnHeader clmnHdrId;
        private System.Windows.Forms.Button btnAzurirajSpecijalizaciju;
        private System.Windows.Forms.TextBox txtBoxSpecijalizacija;
        private System.Windows.Forms.Button btnPrikaziSvePodatkeOZeljenomStomatologu;
        private System.Windows.Forms.Button btnPrikaziSvePodatkeOSvimStomatolozima;
    }
}