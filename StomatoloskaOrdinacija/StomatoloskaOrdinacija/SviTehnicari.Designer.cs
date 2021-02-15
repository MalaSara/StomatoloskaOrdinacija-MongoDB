namespace StomatoloskaOrdinacija
{
    partial class SviTehnicari
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
            this.lstViewTehncari = new System.Windows.Forms.ListView();
            this.clmnHdrId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHdrIme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnHdrPrezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnObrisiTehnicara = new System.Windows.Forms.Button();
            this.AzurirajNjegovogStomatolaga = new System.Windows.Forms.Button();
            this.tboxStomatolog = new System.Windows.Forms.TextBox();
            this.PrikaziPodatkeSelektovanogTehnicara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewTehncari
            // 
            this.lstViewTehncari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnHdrId,
            this.clmnHdrIme,
            this.clmnHdrPrezime});
            this.lstViewTehncari.HideSelection = false;
            this.lstViewTehncari.Location = new System.Drawing.Point(12, 12);
            this.lstViewTehncari.Name = "lstViewTehncari";
            this.lstViewTehncari.Size = new System.Drawing.Size(349, 220);
            this.lstViewTehncari.TabIndex = 2;
            this.lstViewTehncari.UseCompatibleStateImageBehavior = false;
            this.lstViewTehncari.View = System.Windows.Forms.View.Details;
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
            // btnObrisiTehnicara
            // 
            this.btnObrisiTehnicara.Location = new System.Drawing.Point(379, 12);
            this.btnObrisiTehnicara.Name = "btnObrisiTehnicara";
            this.btnObrisiTehnicara.Size = new System.Drawing.Size(119, 23);
            this.btnObrisiTehnicara.TabIndex = 3;
            this.btnObrisiTehnicara.Text = "Obrisi tehnicara";
            this.btnObrisiTehnicara.UseVisualStyleBackColor = true;
            this.btnObrisiTehnicara.Click += new System.EventHandler(this.btnObrisiTehnicara_Click);
            // 
            // AzurirajNjegovogStomatolaga
            // 
            this.AzurirajNjegovogStomatolaga.Location = new System.Drawing.Point(486, 60);
            this.AzurirajNjegovogStomatolaga.Name = "AzurirajNjegovogStomatolaga";
            this.AzurirajNjegovogStomatolaga.Size = new System.Drawing.Size(211, 23);
            this.AzurirajNjegovogStomatolaga.TabIndex = 4;
            this.AzurirajNjegovogStomatolaga.Text = "Azuriraj njegovog stomatologa";
            this.AzurirajNjegovogStomatolaga.UseVisualStyleBackColor = true;
            this.AzurirajNjegovogStomatolaga.Click += new System.EventHandler(this.AzurirajNjegovogStomatolaga_Click);
            // 
            // tboxStomatolog
            // 
            this.tboxStomatolog.Location = new System.Drawing.Point(380, 62);
            this.tboxStomatolog.Name = "tboxStomatolog";
            this.tboxStomatolog.Size = new System.Drawing.Size(100, 20);
            this.tboxStomatolog.TabIndex = 7;
            // 
            // PrikaziPodatkeSelektovanogTehnicara
            // 
            this.PrikaziPodatkeSelektovanogTehnicara.Location = new System.Drawing.Point(380, 103);
            this.PrikaziPodatkeSelektovanogTehnicara.Name = "PrikaziPodatkeSelektovanogTehnicara";
            this.PrikaziPodatkeSelektovanogTehnicara.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PrikaziPodatkeSelektovanogTehnicara.Size = new System.Drawing.Size(211, 23);
            this.PrikaziPodatkeSelektovanogTehnicara.TabIndex = 8;
            this.PrikaziPodatkeSelektovanogTehnicara.Text = "Prikazi podatke selektovanog tehnicara";
            this.PrikaziPodatkeSelektovanogTehnicara.UseVisualStyleBackColor = true;
            this.PrikaziPodatkeSelektovanogTehnicara.Click += new System.EventHandler(this.PrikaziPodatkeSelektovanogTehnicara_Click);
            // 
            // SviTehnicari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrikaziPodatkeSelektovanogTehnicara);
            this.Controls.Add(this.tboxStomatolog);
            this.Controls.Add(this.AzurirajNjegovogStomatolaga);
            this.Controls.Add(this.btnObrisiTehnicara);
            this.Controls.Add(this.lstViewTehncari);
            this.Name = "SviTehnicari";
            this.Text = "SviTehnicari";
            this.Load += new System.EventHandler(this.SviTehnicari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewTehncari;
        private System.Windows.Forms.ColumnHeader clmnHdrId;
        private System.Windows.Forms.ColumnHeader clmnHdrIme;
        private System.Windows.Forms.ColumnHeader clmnHdrPrezime;
        private System.Windows.Forms.Button btnObrisiTehnicara;
        private System.Windows.Forms.Button AzurirajNjegovogStomatolaga;
        private System.Windows.Forms.TextBox tboxStomatolog;
        private System.Windows.Forms.Button PrikaziPodatkeSelektovanogTehnicara;
    }
}