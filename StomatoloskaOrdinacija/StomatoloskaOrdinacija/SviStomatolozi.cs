using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System.Globalization;

namespace StomatoloskaOrdinacija
{
    public partial class SviStomatolozi : Form
    {
        public SviStomatolozi()
        {
            InitializeComponent();
        }

        private void SviStomatolozi_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<Stomatolog>("stomatolozi");
            var stomatolozi = collection.Find<Stomatolog>(new BsonDocument()).ToList();

            foreach (Stomatolog s in stomatolozi)
            {
                ListViewItem podatak = new ListViewItem(new string[]
                { s.Id.ToString(), s.Ime.ToString(), s.Prezime.ToString(), s.Specijalizacija.ToString()});

                this.lstViewStomatolozi.Items.Add(podatak);
            }
        }

        public string prikaziSertifikate(Stomatolog stomatolog)
        {
            string sertifikati = "";
            if (stomatolog.Sertifikati != null)
            {
                foreach (string sertifikat in stomatolog.Sertifikati)
                {
                    sertifikati += "\n- " + sertifikat;
                }
            }
            else
                sertifikati = "Nema sertifikata.";

            return sertifikati;
        }

        public string prikaziZakazaneTermine(Stomatolog stomatolog)
        {
            string termini = "";
            if (stomatolog.ZakazaniTermini != null)
            {
                foreach (DateTime t in stomatolog.ZakazaniTermini)
                {
                    termini += "\n- " + t.ToString();
                }
            }
            else
                termini = "Nema zakazih termina.";

            return termini;
        }
        public void prikaziInformacije(Stomatolog stomatolog, string sertifikati, string termini)
        {
            MessageBox.Show("Ime i prezime: " + stomatolog.Ime + " " + stomatolog.Prezime + "\nSpecijalizacija: " +
                    stomatolog.Specijalizacija + "\nGodine iskustva: " + stomatolog.GodineIskustva +
                    "\nSertifikati: " + sertifikati + "\nZakazani termini: " + termini);
        }

        private void btnAzurirajSpecijalizaciju_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("stomatolozi");

            if (lstViewStomatolozi.SelectedItems.Count != 0)
            {
                if (txtBoxSpecijalizacija.Text != null)
                {
                    ObjectId id = new ObjectId(lstViewStomatolozi.SelectedItems[0].SubItems[0].Text);
                    var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                    var update = Builders<BsonDocument>.Update.Set("Specijalizacija", txtBoxSpecijalizacija.Text);

                    collection.UpdateOne(filter, update);
                    lstViewStomatolozi.Items.Clear();
                    this.popuniPodacima();
                    txtBoxSpecijalizacija.Clear();
                }
                else
                    MessageBox.Show("Upisite specijalizaciju!");
            }
            else
                MessageBox.Show("Selektujte zeljenog stomatologa!");
        }

        private void btnObrisiStomatologa_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("stomatolozi");

            if (lstViewStomatolozi.SelectedItems.Count != 0)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(lstViewStomatolozi.SelectedItems[0].SubItems[0].Text));

                collection.DeleteOne(filter);
                lstViewStomatolozi.Items.Clear();
                this.popuniPodacima();
            }
            else
                MessageBox.Show("Selektujte zeljenog stomatologa!");
        }

        private void btnPrikaziSvePodatkeOZeljenomStomatologu_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("stomatolozi");

            if (lstViewStomatolozi.SelectedItems.Count != 0)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(lstViewStomatolozi.SelectedItems[0].SubItems[0].Text));

                var find = collection.Find(filter).FirstOrDefault();
                Stomatolog stomatolog = BsonSerializer.Deserialize<Stomatolog>(find.ToBsonDocument());

                string sertifikati = prikaziSertifikate(stomatolog);

                string termini = prikaziZakazaneTermine(stomatolog);

                prikaziInformacije(stomatolog, sertifikati, termini);
            }
            else
                MessageBox.Show("Selektujte zeljenog stomatologa!");
        }

        private void btnPrikaziSvePodatkeOSvimStomatolozima_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<Stomatolog>("stomatolozi");
            var stomatolozi = collection.Find(new BsonDocument()).ToList();

            foreach (Stomatolog stomatolog in stomatolozi)
            {
                string sertifikati = prikaziSertifikate(stomatolog);

                string termini = prikaziZakazaneTermine(stomatolog);

                prikaziInformacije(stomatolog, sertifikati, termini);
            }
        }
    }
}
