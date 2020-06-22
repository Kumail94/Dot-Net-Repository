using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liver_Wall_Board
{

    [Serializable]
    class Booking
    {
        public ObjectId _id { get; set; }
        public String account { get; set; }
        public String accuser { get; set; }
        public String bookedby { get; set; }
        public Boolean changed { get; set; }
        public String comment { get; set; }
        public String creditcard { get; set; }
        public String cstate { get; set; }
        public String custname { get; set; }
        public String date { get; set; }
        public Double datentime { get; set; }
        public Double despatchtime { get; set; }
        public String driverrate { get; set; }
        public Double drvfare { get; set; }
        public String drvrcallsign { get; set; }
        public String drvreqdname { get; set; }
        public String drvrname { get; set; }
        public String drvrreqcallsign { get; set; }
        public String dstate { get; set; }
        public Double fare { get; set; }
        public Int32 flag { get; set; }
        public String flightno { get; set; }
        public String from { get; set; }
        public String from_info { get; set; }
        public String from_outcode { get; set; }
        public List<Fromtovia> fromtovia { get; set; }
        public Boolean hold { get; set; }
        public Boolean isdirty { get; set; }
        public Double jobmileage { get; set; }
        public String jobref { get; set; }
        public String jobtype { get; set; }
        public String jstate { get; set; }
        public Double leadtime { get; set; }
        public List<List<object>> logc { get; set; }
        public List<Logd> logd { get; set; }
        public String mstate { get; set; }
        public Int32 numofvia { get; set; }
        public String office { get; set; }
        public Double oldfare { get; set; }
        public Double olddrvfare { get; set; }
        public String orderno { get; set; }
        public String tag { get; set; }
        public String telephone { get; set; }
        public String time { get; set; }
        public Double timetodespatch { get; set; }
        public String to { get; set; }
        public String to_info { get; set; }
        public String to_outcode { get; set; }
        public String userid { get; set; }
        public String vehicletype { get; set; }
        public String pin { get; set; }
        public String callerid { get; set; }
    }
}