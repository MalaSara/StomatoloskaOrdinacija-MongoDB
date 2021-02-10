
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
            this.grpTehnicar = new System.Windows.Forms.GroupBox();
            this.grbPacijent = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // grbStomatolog
            // 
            this.grbStomatolog.Location = new System.Drawing.Point(12, 12);
            this.grbStomatolog.Name = "grbStomatolog";
            this.grbStomatolog.Size = new System.Drawing.Size(200, 251);
            this.grbStomatolog.TabIndex = 0;
            this.grbStomatolog.TabStop = false;
            this.grbStomatolog.Text = "Stomatolog";
            // 
            // grpTehnicar
            // 
            this.grpTehnicar.Location = new System.Drawing.Point(248, 12);
            this.grpTehnicar.Name = "grpTehnicar";
            this.grpTehnicar.Size = new System.Drawing.Size(200, 251);
            this.grpTehnicar.TabIndex = 1;
            this.grpTehnicar.TabStop = false;
            this.grpTehnicar.Text = "Tehnicar";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbStomatolog;
        private System.Windows.Forms.GroupBox grpTehnicar;
        private System.Windows.Forms.GroupBox grbPacijent;
    }
}

