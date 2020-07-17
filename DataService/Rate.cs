using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public class Rate
    {
        public int OID { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public DateTime EffectiveDate { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        public double Mid { get; set; }
    }
}
