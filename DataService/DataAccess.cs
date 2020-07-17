using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;

namespace DataService
{
    public class DataAccess
    {
        private static HttpClient client = new HttpClient();

        public static List<Rate> GetRatesAsync(string code, DateTime fromDate, DateTime toDate)
        {
            try
            {
                var fromDateValue = fromDate.ToString("yyyy-MM-dd");
                var toDateValue = toDate.ToString("yyyy-MM-dd");
                // connect to database
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    // Check if DB has the record or not.
                    var output = conn.Query<Rate>($"select * from Rates where code = '{code}'").ToList();

                    var records = output.Where(
                        t => t.EffectiveDate.Date >= fromDate &&
                        t.EffectiveDate.Date <= toDate).ToList();

                    if (records.Any())
                    {
                        return records;
                    }

                    // Get records from API and store it in DB and then return the list.
                    StringBuilder str = new StringBuilder();
                    str.Append("http://api.nbp.pl/api/exchangerates/rates/a/");
                    str.Append(code.ToLower());
                    str.Append("/");
                    str.Append(fromDate.ToString("yyyy-MM-dd"));
                    str.Append("/");
                    str.Append(toDate.ToString("yyyy-MM-dd"));
                    str.Append("/");

                    Task<List<Rate>> rates = GetProductAsync(str.ToString());
                    rates.Wait();
                    foreach (var rate in rates.Result)
                    {
                        string insertQuery = @"INSERT INTO Rates([Currency], [Code], [EffectiveDate], [Ask], [Bid]) VALUES (@Currency, @Code, @EffectiveDate, @Ask, @Bid)";

                        var result = conn.Execute(insertQuery, rate);
                    }
                    return rates.Result;
                }
            }
            catch(SQLiteException ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
        
        public static async Task<List<Rate>> GetProductAsync(string path)
        {
            List<Rate> rates = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                rates = (List<Rate>)await response.Content.ReadAsAsync<IEnumerable<Rate>>();
            }
            return rates;
        }

        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ExchangeDB"].ConnectionString;
        }
    }
}
