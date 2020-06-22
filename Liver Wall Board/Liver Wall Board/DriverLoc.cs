using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liver_Wall_Board
{
    [Serializable]
    class Driverloc
    {
        public ObjectId _id { get; set; }
        public String reg { get; set; }
        public String vcolour { get; set; }
        public String vmake { get; set; }
        public String vmodel { get; set; }
        public String vtype { get; set; }
        public Double lng { get; set; }
        public Double lat { get; set; }
        public Int32 accuracy { get; set; }
        public Boolean isvirtual { get; set; }
        public String callsign { get; set; }
        public String name { get; set; }
        public String office_id { get; set; }
        public String state { get; set; }
        public String lstate { get; set; }
        public List<object> loc { get; set; }
        public String battery { get; set; }
        public Int32 clrtimestamp { get; set; }
        public Int32 outcodetime { get; set; }
        public Int32 timestamp { get; set; }
        public String jobid { get; set; }
        public String from { get; set; }
        public String to { get; set; }
        public Int32 priority { get; set; }
        public String outcode { get; set; }
        public Int32 speed { get; set; }
        public String telephone { get; set; }
    }

    [Serializable]
    public class Loc<T>
    {
        public String  type { get; set; }
        public object coordinates { get; set; }
    }
}
