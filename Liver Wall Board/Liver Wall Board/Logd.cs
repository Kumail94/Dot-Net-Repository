using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liver_Wall_Board
{
    [Serializable]
    class Logd
    {
        public Double timestamp { get; set; }
        public String state { get; set; }
        public String uniqueid { get; set; }
        public Double longitude { get; set; }
        public Double latitude { get; set; }
        public Double speed { get; set; }
        public Double accuracy { get; set; }
    }
}
