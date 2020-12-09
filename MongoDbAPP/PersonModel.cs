using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbAPP
{
    public class PersonModel
    {
        [BsonId]
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public AdressModel PrimaryAdress { get; set; }
    }

    public class AdressModel
    {
        public string StreetAdress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
}
