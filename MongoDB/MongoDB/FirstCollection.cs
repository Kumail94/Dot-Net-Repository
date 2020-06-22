using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB
{
    class FirstCollection
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement]
        public String Director { get; set; }
        [BsonElement]
        public String Manager { get; set; }
        [BsonElement]
        public String Supervisor { get; set; }
        [BsonElement]
        public String FirstEmployee { get; set; }
        [BsonElement]
        public String SecondEmployee { get; set; }
        [BsonElement]
        public String ThirdEmployee { get; set; }
        public FirstCollection(string d , string m , string s , string fi, string sec, string thd)
        {
            Director = d;
            Manager = m;
            Supervisor = s;
            FirstEmployee = fi;
            SecondEmployee = sec;
            ThirdEmployee = thd;
        }


    }
}
