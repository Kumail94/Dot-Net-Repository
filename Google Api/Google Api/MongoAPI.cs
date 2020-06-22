using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Google_Api
{
    public class MongoAPI
    {

        [BsonElement("Payment Category")]
        public String Payment { get; set; }
        [BsonElement("Car Category")]
        public String Car { get; set; }
        [BsonElement("Current Date")]
        public DateTime Date { get; set; }
        [BsonElement("Timings")]
        public TimeSpan timings { get; set; }
        public MongoAPI(string payment , string category , DateTime date ,TimeSpan time )
        {
            Payment = payment;
            Car = category;
            Date = date;
            timings = time;
        }
    }
}
