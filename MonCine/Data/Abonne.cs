using MongoDB.Bson;
using System;

namespace MonCine.Data
{
    public class Abonne
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public DateTime DateAdhesion { get; set; }

        // A compléter
    }
}
