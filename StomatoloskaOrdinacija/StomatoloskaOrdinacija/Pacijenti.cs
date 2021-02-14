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
    public partial class Pacijenti : Form
    {
        public Pacijenti()
        {
            InitializeComponent();
        }

        private void Pacijenti_Load(object sender, EventArgs e)
        {
            fromDatabase();
        }

        public void fromDatabase()
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<Pacijent>("pacijenti");
            var pacijenti = collection.Find(new BsonDocument()).ToList();

            foreach (Pacijent p in pacijenti)
            {
                ListViewItem data = new ListViewItem(new string[]
                { p.Id.ToString(),p.BrojKartona.ToString(), p.Ime.ToString(), p.Prezime.ToString(), 
                  p.DatumRodjenja.ToString()});

                lvPacijenti.Items.Add(data);
            }
        }

        private void btnObrisiPacijenta_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("pacijenti");

            if (lvPacijenti.SelectedItems.Count != 0)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(lvPacijenti.SelectedItems[0].SubItems[0].Text));

                collection.DeleteOne(filter);
                lvPacijenti.Items.Clear();
                this.fromDatabase();
            }
            else
                MessageBox.Show("Selektujte zeljenog pacijenta!");
        }

        private void btnAzurirajIntervencije_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("pacijenti");

            if (lvPacijenti.SelectedItems.Count != 0)
            {
                if (tbIntervencija.Text != null)
                {
                    ObjectId id = new ObjectId(lvPacijenti.SelectedItems[0].SubItems[0].Text);
                    var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                    var update = Builders<BsonDocument>.Update.Set("Intervencije", tbIntervencija.Text);

                    collection.UpdateOne(filter, update);
                    lvPacijenti.Items.Clear();
                    this.fromDatabase();
                    tbIntervencija.Clear();
                }
                else
                    MessageBox.Show("Upisite intervenciju!");
            }
            else
                MessageBox.Show("Selektujte zeljenog pacijenta!");
        }

        private void btnAzurirajBolesti_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("pacijenti");

            if (lvPacijenti.SelectedItems.Count != 0)
            {
                if (tbBolest.Text != null)
                {
                    ObjectId id = new ObjectId(lvPacijenti.SelectedItems[0].SubItems[0].Text);
                    var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                    var update = Builders<BsonDocument>.Update.Set("BolestiIzAnamneze", tbBolest.Text);

                    collection.UpdateOne(filter, update);
                    lvPacijenti.Items.Clear();
                    this.fromDatabase();
                    tbBolest.Clear();
                }
                else
                    MessageBox.Show("Upisite bolest!");
            }
            else
                MessageBox.Show("Selektujte zeljenog pacijenta!");
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("pacijenti");
            var sCollection = database.GetCollection<BsonDocument>("stomatolozi");

            if (lvPacijenti.SelectedItems.Count != 0)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(lvPacijenti.SelectedItems[0].SubItems[0].Text));

                var find = collection.Find(filter).FirstOrDefault();
                Pacijent pacijent = BsonSerializer.Deserialize<Pacijent>(find.ToBsonDocument());

                var filter2 = Builders<BsonDocument>.Filter.Eq("_id", pacijent.stomatolog);
                var find2 = sCollection.Find(filter2).FirstOrDefault();
                Stomatolog stom = BsonSerializer.Deserialize<Stomatolog>(find2.ToBsonDocument());

                string intervencije = "";
                if (pacijent.Intervencije != null)
                {
                    foreach (string i in pacijent.Intervencije)
                    {
                        intervencije += "\n- " + i.ToString();
                    }
                }
                else
                    intervencije = "Nema intervencija.";

                string bolesti = "";
                if (pacijent.BolestiIzAnamneze != null)
                {
                    foreach (string b in pacijent.BolestiIzAnamneze)
                    {
                        bolesti += "\n- " + b.ToString();
                    }
                }
                else
                    bolesti = "Nema bolesti iz anamneze.";


                MessageBox.Show("Broj kartona:" + pacijent.BrojKartona + 
                                "\nIme i prezime: " + pacijent.Ime + " " + pacijent.Prezime + 
                                "\nDatum rodjenja: " + pacijent.DatumRodjenja +
                                "\nIntervencije: " + intervencije +
                                "\nBolesti iz anamneze: " + bolesti + 
                                "\nStomatolog: " + stom.Ime + " " + stom.Prezime);

            }
            else
                MessageBox.Show("Selektujte zeljenog pacijenta!");
        }
    }
}
