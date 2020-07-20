using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace DataService
{    
    [ServiceContract]
    public interface IExhangeService
    {
        [OperationContract]
        IEnumerable<Rate> GetRates(string code, DateTime fromDate, DateTime toDate);
    }
}
