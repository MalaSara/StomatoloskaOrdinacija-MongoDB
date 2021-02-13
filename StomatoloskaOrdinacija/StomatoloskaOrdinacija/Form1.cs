using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StomatoloskaOrdinacija
{
    public partial class StomatoloskaOrdinacija : Form
    {
        public StomatoloskaOrdinacija()
        {
            InitializeComponent();
        }

        private void btnDodajStomatologa_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<Stomatolog>("stomatolozi");


            Stomatolog s1 = new Stomatolog
            {
                Specijalizacija = "Oralni hirurg",
                Ime = "Emilija",
                Prezime = "Mladenovic",
                GodineIskustva = 2,
                Sertifikati = new List<string> { "sert1", "sert2" },
                ZakazaniTermini = new List<BsonDateTime> { DateTime.Now, DateTime.Today.AddDays(2) }
            };

            collection.InsertOne(s1);

            Stomatolog s2 = new Stomatolog
            {
                Specijalizacija = "Proteticar",
                Ime = "Slavica",
                Prezime = "Mladenovic",
                GodineIskustva = 20
            };

            collection.InsertOne(s2);

        }

        private void btnSviStomatolozi_Click(object sender, EventArgs e)
        {
            SviStomatolozi forma = new SviStomatolozi();
            forma.Show();
        }

        private void DodajTehnicara_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb+srv://kate:ordinacija@stomatoloskaordinacija.l28eb.mongodb.net/<stomatoloskaOrdinacija>?retryWrites=true&w=majority");
            var database = client.GetDatabase("stomatoloskaOrdinacija");

            var collection = database.GetCollection<Tehnicar>("tehnicari");

            Tehnicar t1 = new Tehnicar
            {
                Ime = "Andjela",
                Prezime = "Milovanovic",
                Stomatolozi = new List<ObjectId>()
   
            };
            t1.Stomatolozi.Add(new ObjectId("6025bb1baa45380a97b7a9d2"));
            
            Tehnicar t2 = new Tehnicar
            {
                Ime = "Aleksandar",
                Prezime = "Petrovic",
                Stomatolozi=new List<ObjectId>()
            };
            t2.Stomatolozi.Add(new ObjectId("6025bed6b40d411c47819c28"));
      
            Tehnicar t3 = new Tehnicar
            {
                Ime = "Milos",
                Prezime = "Milosevic",
                Stomatolozi = new List<ObjectId>()
            };
            t3.Stomatolozi.Add(new ObjectId("6025bed6b40d411c47819c28"));
            t3.Stomatolozi.Add(new ObjectId("6025bb1baa45380a97b7a9d2"));

            collection.InsertOne(t1);
            collection.InsertOne(t2);
            collection.InsertOne(t3);
        }
    }
}
