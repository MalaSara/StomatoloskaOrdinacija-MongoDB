using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace StomatoloskaOrdinacija
{
    public class Pacijent
    {
        public ObjectId Id { get; set; }
        public int BrojKartona { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public BsonDateTime DatumRodjenja { get; set; }
        public List<string> Intervencije { get; set; }
        public List<string> BolestiIzAnamneze { get; set; }
        public ObjectId Stomatolog { get; set; }
    }
}
