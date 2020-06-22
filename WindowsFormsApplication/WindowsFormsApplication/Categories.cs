using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication
{
    class Categories
    {
        [BsonId]
        public ObjectId ID{ get; set; }
        [BsonElement]
        public DateTime Time { get; set; }
        [BsonElement]
        public TimeSpan Due { get; set; }
        [BsonElement]
        public String Office { get; set; }
        [BsonElement]
        public String Vechile { get; set; }
        [BsonElement]
        public String Origin { get; set; }
        [BsonElement]
        public String Destination { get; set; }
        [BsonElement]
        public String CustomerName { get; set; }
        [BsonElement]
        public String DriverRequest { get; set; }
        public Categories(DateTime dated , TimeSpan due , string office , string vechile , string origin , string destination ,string customerName , string driverReq)
        {
            Time = dated;
            Due = due;
            Office = office;
            Vechile = vechile;
            Origin = origin;
            Destination = destination;
            CustomerName = customerName;
            DriverRequest = driverReq;
        }
    }
}