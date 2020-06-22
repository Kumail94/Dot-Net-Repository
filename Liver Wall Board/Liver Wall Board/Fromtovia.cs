using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liver_Wall_Board
{
    [Serializable]
    public class Fromtovia
    {
        public String info { get; set; }
        public String address { get; set; }
        public Double lat { get; set; }
        public Double lon { get; set; }
        public String postcode { get; set; }
    }
}
