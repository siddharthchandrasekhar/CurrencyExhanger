using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataService
{
    public class ExchangeRatesSeries
    {
        [XmlIgnore]
        public int OID { get; set; }
        public string Table { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public List<Rate> Rates { get; set; }
    }
}
