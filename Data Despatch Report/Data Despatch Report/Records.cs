using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Despatch_Report
{
    class Records
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Date")]
        public DateTime Date { get; set; }
        [BsonElement("Time")]
        public TimeSpan Time { get; set; }
        [BsonElement("Booking No")]
        public String BookingNo { get; set; }
        [BsonElement("Account")]
        public String Account { get; set; }
        [BsonElement("Car")]
        public String Car { get; set; }
        [BsonElement("Customer Name")]
        public String CustomerName { get; set; }
        [BsonElement("From")]
        public String From { get; set; }
        [BsonElement("To")]
        public String To { get; set; }
        [BsonElement("Flight No")]
        public String FlightNo { get; set; }
        [BsonElement("Driver Call Sign")]
        public String DriverCallSign { get; set; }
        [BsonElement("Driver Request Name")]
        public String DriverRequestName { get; set; }


        public Records(DateTime date, TimeSpan time, String booking, String account, String car, String custName, String from, String to, String flightNo, String drvcallSign, String drvReqName)
        {
            //Id = id;
            Date = date;
            Time = time;
            BookingNo = booking;
            Account = account;
            Car = car;
            CustomerName = custName;
            From = from;
            To = to;
            FlightNo = flightNo;
            DriverCallSign = drvcallSign;
            DriverRequestName = drvReqName;
        }
    
    }
}
