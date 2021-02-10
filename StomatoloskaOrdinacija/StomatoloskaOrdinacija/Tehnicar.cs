using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace StomatoloskaOrdinacija
{
    public class Tehnicar
    {
        public ObjectId Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<ObjectId> Stomatolozi { get; set; }

        public Tehnicar()
        {
            Stomatolozi = new List<ObjectId>();
        }
    }
}
