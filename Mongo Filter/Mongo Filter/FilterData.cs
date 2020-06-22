using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Mongo_Filter
{
    class FilterData
    {
        [BsonId]
        public ObjectId id { get; set; }
        [BsonElement("Student Name")]
        public String Name { get; set; }
        [BsonElement("Age")]
        public Int32 Age { get; set; }
        [BsonElement("Registration")]
        public DateTime Registration { get; set; }
    }
}
