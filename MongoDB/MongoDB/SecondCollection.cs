using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    class SecondCollection
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public String FirstEmployee { get; set; }
        [BsonElement]
        public String SecondEmployee { get; set; }
        [BsonElement]
        public String ThirdEmployee { get; set; }
        public SecondCollection(string f , string s , string t )
        {
            FirstEmployee = f;
            SecondEmployee = s;
            ThirdEmployee = t;
           
        }
    }
}
