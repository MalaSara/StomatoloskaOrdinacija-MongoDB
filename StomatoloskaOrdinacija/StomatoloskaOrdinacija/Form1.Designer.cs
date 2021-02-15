
namespace StomatoloskaOrdinacija
{
    partial class StomatoloskaOrdinacija
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
            this.grbStomatolog = new System.Windows.Forms.GroupBox();
            this.btnSviStomatolozi = new System.Windows.Forms.Button();
            this.btnDodajStomatologa = new System.Windows.Forms.Button();
            this.grpTehnicar = new System.Windows.Forms.GroupBox();
            this.DodajTehnicara = new System.Windows.Forms.Button();
            this.grbPacijent = new System.Windows.Forms.GroupBox();
            this.SviTehnicari = new System.Windows.Forms.Button();
            this.grbStomatolog.SuspendLayout();
            this.grpTehnicar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbStomatolog
            // 
            this.grbStomatolog.Controls.Add(this.btnSviStomatolozi);
            this.grbStomatolog.Controls.Add(this.btnDodajStomatologa);
            this.grbStomatolog.Location = new System.Drawing.Point(12, 12);
            this.grbStomatolog.Name = "grbStomatolog";
            this.grbStomatolog.Size = new System.Drawing.Size(200, 251);
            this.grbStomatolog.TabIndex = 0;
            this.grbStomatolog.TabStop = false;
            this.grbStomatolog.Text = "Stomatolog";
           
            // 
            // btnSviStomatolozi
            // 
            this.btnSviStomatolozi.Location = new System.Drawing.Point(21, 78);
            this.btnSviStomatolozi.Name = "btnSviStomatolozi";
            this.btnSviStomatolozi.Size = new System.Drawing.Size(135, 23);
            this.btnSviStomatolozi.TabIndex = 3;
            this.btnSviStomatolozi.Text = "Svi stomatolozi";
            this.btnSviStomatolozi.UseVisualStyleBackColor = true;
            this.btnSviStomatolozi.Click += new System.EventHandler(this.btnSviStomatolozi_Click);
            // 
            // btnDodajStomatologa
            // 
            this.btnDodajStomatologa.Location = new System.Drawing.Point(21, 32);
            this.btnDodajStomatologa.Name = "btnDodajStomatologa";
            this.btnDodajStomatologa.Size = new System.Drawing.Size(135, 23);
            this.btnDodajStomatologa.TabIndex = 3;
            this.btnDodajStomatologa.Text = "Dodaj stomatologa";
            this.btnDodajStomatologa.UseVisualStyleBackColor = true;
            this.btnDodajStomatologa.Click += new System.EventHandler(this.btnDodajStomatologa_Click);
            // 
            // grpTehnicar
            // 
            this.grpTehnicar.Controls.Add(this.SviTehnicari);
            this.grpTehnicar.Controls.Add(this.DodajTehnicara);
            this.grpTehnicar.Location = new System.Drawing.Point(248, 12);
            this.grpTehnicar.Name = "grpTehnicar";
            this.grpTehnicar.Size = new System.Drawing.Size(200, 251);
            this.grpTehnicar.TabIndex = 1;
            this.grpTehnicar.TabStop = false;
            this.grpTehnicar.Text = "Tehnicar";
            // 
            // DodajTehnicara
            // 
            this.DodajTehnicara.Location = new System.Drawing.Point(33, 32);
            this.DodajTehnicara.Name = "DodajTehnicara";
            this.DodajTehnicara.Size = new System.Drawing.Size(135, 23);
            this.DodajTehnicara.TabIndex = 4;
            this.DodajTehnicara.Text = "Dodaj tehnicara";
            this.DodajTehnicara.UseVisualStyleBackColor = true;
            this.DodajTehnicara.Click += new System.EventHandler(this.DodajTehnicara_Click);
            // 
            // grbPacijent
            // 
            this.grbPacijent.Location = new System.Drawing.Point(479, 12);
            this.grbPacijent.Name = "grbPacijent";
            this.grbPacijent.Size = new System.Drawing.Size(200, 251);
            this.grbPacijent.TabIndex = 2;
            this.grbPacijent.TabStop = false;
            this.grbPacijent.Text = "Pacijent";
            // 
            // SviTehnicari
            // 
            this.SviTehnicari.Location = new System.Drawing.Point(33, 78);
            this.SviTehnicari.Name = "SviTehnicari";
            this.SviTehnicari.Size = new System.Drawing.Size(135, 23);
            this.SviTehnicari.TabIndex = 5;
            this.SviTehnicari.Text = "Svi tehnicari";
            this.SviTehnicari.UseVisualStyleBackColor = true;
            this.SviTehnicari.Click += new System.EventHandler(this.SviTehnicari_Click);
            // 
            // StomatoloskaOrdinacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbPacijent);
            this.Controls.Add(this.grpTehnicar);
            this.Controls.Add(this.grbStomatolog);
            this.Name = "StomatoloskaOrdinacija";
            this.Text = "Stomatoloska ordinacija";
            this.grbStomatolog.ResumeLayout(false);
            this.grpTehnicar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStomatolog;
        private System.Windows.Forms.GroupBox grpTehnicar;
        private System.Windows.Forms.GroupBox grbPacijent;
        private System.Windows.Forms.Button btnDodajStomatologa;
        private System.Windows.Forms.Button btnSviStomatolozi;
        private System.Windows.Forms.Button DodajTehnicara;
        private System.Windows.Forms.Button SviTehnicari;
    }
}

