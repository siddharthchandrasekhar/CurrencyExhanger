using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace DataService
{
    public class Rate
    {
        [XmlIgnore]
        [Browsable(false)]
        public int OID { get; set; }
        [XmlIgnore]
        public string Code { get; set; }
        [XmlIgnore]
        public string Currency { get; set; }
        public DateTime EffectiveDate { get; set; }
        public double Mid { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        [XmlIgnore]
        [Browsable(false)]
        public string Table { get; set; }
        [DisplayName("Table No.")]
        public string No { get; set; }
                       
    }
}
