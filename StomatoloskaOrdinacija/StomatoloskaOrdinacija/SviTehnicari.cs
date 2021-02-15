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
    public partial class SviTehnicari : Form
    {
        public SviTehnicari()
        {
            InitializeComponent();
        }

        private void SviTehnicari_Load(object sender, EventArgs e)
        {
            podaci();
        }

        private void podaci()
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<Tehnicar>("tehnicari");
            var tehnicari = collection.Find<Tehnicar>(new BsonDocument()).ToList();

            foreach (Tehnicar t in tehnicari)
            {
                ListViewItem podatak = new ListViewItem(new string[]
                { t.Id.ToString(), t.Ime.ToString(), t.Prezime.ToString()});

                this.lstViewTehncari.Items.Add(podatak);
            }
        }

        private void btnObrisiTehnicara_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("tehnicari");

            if (lstViewTehncari.SelectedItems.Count != 0)
            {
                var tehnicarZaBrisanje = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(lstViewTehncari.SelectedItems[0].SubItems[0].Text));

                collection.DeleteOne(tehnicarZaBrisanje);
                lstViewTehncari.Items.Clear();
                this.podaci();

                MessageBox.Show("Obrisan je selektovani tehnicar");
            }
            else MessageBox.Show("Selektuj tehnicara");

        }

        private void AzurirajNjegovogStomatolaga_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("stomatolozi");

            if (lstViewTehncari.SelectedItems.Count != 0)
            {
                if (tboxStomatolog.Text != null)
                {
                    ObjectId id = new ObjectId(lstViewTehncari.SelectedItems[0].SubItems[0].Text);
                    var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
                    var dodaj = Builders<BsonDocument>.Update.AddToSet("Stomatolozi", tboxStomatolog.Text);

                    collection.UpdateOne(filter, dodaj);
                    lstViewTehncari.Items.Clear();
                    this.podaci();
                    tboxStomatolog.Clear();
                }
                else MessageBox.Show("Upisite stomatologa");
            }
            else MessageBox.Show("Selektuj tehnicara");
        }

        private void PrikaziPodatkeSelektovanogTehnicara_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<BsonDocument>("tehnicari");

            if (lstViewTehncari.SelectedItems.Count != 0)
            {
                var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(lstViewTehncari.SelectedItems[0].SubItems[0].Text));

                var find = collection.Find(filter).FirstOrDefault();
                Tehnicar tehnicar = BsonSerializer.Deserialize<Tehnicar>(find.ToBsonDocument());

                string stomatolozi = " ";
                if (tehnicar.Stomatolozi != null)
                {
                    foreach(ObjectId idstom in tehnicar.Stomatolozi)
                    {
                        stomatolozi += "\n" + idstom.ToString();
                    }
                }

                MessageBox.Show("Ime i prezime: " + tehnicar.Ime + " " + tehnicar.Prezime + "\nStomatolozi: " + stomatolozi);
            }
            else MessageBox.Show("Selektuj tehnicara");
        }
    }
}
