using System;
using System.Collections.Generic;

namespace DataService
{
    public class ExchangeService : IExhangeService
    {
        public IEnumerable<Rate> GetRates(string code, DateTime fromDate, DateTime toDate)
        {
            return DataAccess.GetRatesAsync(code, fromDate, toDate);
        }
    }
}
