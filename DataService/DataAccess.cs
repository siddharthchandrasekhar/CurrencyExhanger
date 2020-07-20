using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DataService
{
    public class DataAccess
    {
        private static readonly HttpClient _client = new HttpClient();        

        public static IEnumerable<Rate> GetRatesAsync(string code,
            DateTime fromDate, DateTime toDate)
        {
            try
            {
                var path = LoadUri(code, fromDate, toDate);
                Task<ExchangeRatesSeries> exchangeRates = GetExchangeRatesAsync(path);
                var result = exchangeRates.Result;
                if (result == null)
                    return Enumerable.Empty<Rate>();
                List<Rate> rates = result.Rates;
                
                foreach (var rate in rates)
                {
                    rate.Currency = result.Currency;
                    rate.Code = result.Code;
                    rate.Table = result.Table;
                }

                return rates;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }            
        }

        public static async Task<ExchangeRatesSeries> GetExchangeRatesAsync(string url)
        {
            try
            {
                Task<HttpResponseMessage> response = _client.GetAsync(url);
                response.Wait();
                if (!response.Result.IsSuccessStatusCode)
                    return null;

                var exchangeRates = await response.Result.Content.ReadAsAsync<ExchangeRatesSeries>();
                
                return exchangeRates;
            }
            catch (HttpException ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }            
        }

        private static string LoadUri(string code, DateTime fromDate, DateTime toDate)
        {
            string table = fromDate.Date == toDate.Date ? "c" : "a";
            StringBuilder uri = new StringBuilder();
            uri.Append("http://api.nbp.pl/api/exchangerates/rates/");
            uri.Append(table);
            uri.Append("/");
            uri.Append(code.ToLower());
            uri.Append("/");
            uri.Append(fromDate.ToString("yyyy-MM-dd"));
            uri.Append("/");
            if (fromDate != toDate)
            {
                uri.Append(toDate.ToString("yyyy-MM-dd"));
                uri.Append("/");
            }

            return uri.ToString();
        }        
    }
}
