using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija
{
    public class Stomatolog
    {
        public ObjectId Id { get; set; }
        public string Specijalizacija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int GodineIskustva { get; set; }
        public List<string> Sertifikati { get; set; }
        public List<ObjectId> Pacijenti { get; set; }
        public List<ObjectId> Tehnicari { get; set; }
        public List<BsonDateTime> ZakazaniTermini { get; set; }

        public Stomatolog()
        {
            Pacijenti = new List<ObjectId>();

            Tehnicari = new List<ObjectId>();
        }

    }
}
