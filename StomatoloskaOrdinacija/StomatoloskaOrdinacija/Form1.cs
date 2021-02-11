using MongoDB.Driver;
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

        }
    }
}
