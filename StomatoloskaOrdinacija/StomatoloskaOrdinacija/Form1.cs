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
            var collectionTehnicari = database.GetCollection<Tehnicar>("tehnicari");
            var collectionPacijenti = database.GetCollection<Pacijent>("pacijenti");

            Stomatolog s1 = new Stomatolog
            {
                Specijalizacija = "Oralni hirurg",
                Ime = "Emilija",
                Prezime = "Mladenovic",
                GodineIskustva = 2,
                Sertifikati = new List<string> { "sert1", "sert2" },
                ZakazaniTermini = new List<BsonDateTime> { DateTime.Now, DateTime.Today.AddDays(2) },
                Pacijenti = new List<ObjectId>(),
                Tehnicari = new List<ObjectId>()
            };

            var t1 = collectionTehnicari.Find((i => i.Ime == "Aleksandar")).FirstOrDefault();
            s1.Tehnicari.Add(new ObjectId(t1.Id.ToString()));

            var p1 = collectionPacijenti.Find((i => i.BrojKartona == 1)).FirstOrDefault();
            s1.Pacijenti.Add(new ObjectId(p1.Id.ToString()));

            collection.InsertOne(s1);

            Stomatolog s2 = new Stomatolog
            {
                Specijalizacija = "Proteticar",
                Ime = "Slavica",
                Prezime = "Mladenovic",
                GodineIskustva = 20,
                Pacijenti = new List<ObjectId>(),
                Tehnicari = new List<ObjectId>()
            };

            var t2 = collectionTehnicari.Find((i => i.Ime == "Andjela")).FirstOrDefault();
            s2.Tehnicari.Add(new ObjectId(t2.Id.ToString()));

            var p2 = collectionPacijenti.Find((i => i.BrojKartona == 2)).FirstOrDefault();
            s2.Pacijenti.Add(new ObjectId(p2.Id.ToString()));


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
            var collectionstom = database.GetCollection<Stomatolog>("stomatolozi");


            Tehnicar t1 = new Tehnicar
            {
                Ime = "Andjela",
                Prezime = "Milovanovic",
                Stomatolozi = new List<ObjectId>()
   
            };
            //collectionstom.Find()
            var query1 = from stomatolog in collectionstom.AsQueryable<Stomatolog>()
                         where stomatolog.Ime == "Slavica"
                         select stomatolog;
            foreach(Stomatolog s in query1)
            {
                t1.Stomatolozi.Add(new ObjectId(s.Id.ToString()));
                
            }


            Tehnicar t2 = new Tehnicar
            {
                Ime = "Aleksandar",
                Prezime = "Petrovic",
                Stomatolozi=new List<ObjectId>()
            };
            //t2.Stomatolozi.Add(new ObjectId("6025bed6b40d411c47819c28"));
            var query2 = from stomatolog in collectionstom.AsQueryable<Stomatolog>()
                         where stomatolog.Ime == "Emilija"
                         select stomatolog;
            foreach (Stomatolog s in query2)
            {
                t2.Stomatolozi.Add(new ObjectId(s.Id.ToString()));
               
            }

            Tehnicar t3 = new Tehnicar
            {
                Ime = "Milos",
                Prezime = "Milosevic",
                Stomatolozi = new List<ObjectId>()
            };
            //t3.Stomatolozi.Add(new ObjectId("6025bed6b40d411c47819c28"));
            // t3.Stomatolozi.Add(new ObjectId("6025bb1baa45380a97b7a9d2"));
            foreach (Stomatolog s in query2)
            {
                t2.Stomatolozi.Add(new ObjectId(s.Id.ToString()));
               
            }
            foreach (Stomatolog s in query1)
            {
                t1.Stomatolozi.Add(new ObjectId(s.Id.ToString()));
                
            }
            collection.InsertOne(t1);
            collection.InsertOne(t2);
            collection.InsertOne(t3);
        }

        
        private void SviTehnicari_Click(object sender, EventArgs e)
        {
            SviTehnicari formatehnicari = new SviTehnicari();
            formatehnicari.Show();
        }

        
    }
    
}
