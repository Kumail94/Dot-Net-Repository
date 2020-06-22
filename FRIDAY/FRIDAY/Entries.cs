using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRIDAY
{
    public class Entries
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public String SName { get; set; }
        [BsonElement]
        public String Age { get; set; }
        [BsonElement]
        public String Department { get; set; }
        public Entries(string name, string age, string depat)
        {
            SName = name;
            Age = age;
            Department = depat;
        }
    }
}
