using Dapper;
using DataService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExchangeUI.ExchangeRatesService;

namespace ExchangeUI
{
    public class DataHanlder
    {
        public static async Task<IEnumerable<Rate>> GetRatesAsync(string code,
            DateTime fromDate, DateTime toDate)
        {
            try
            {
                // connect to database
                using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
                {
                    var rates = new List<Rate>();

                    // Check if DB has the record or not.
                    List<Rate> ratesFromDb = conn.Query<Rate>($"select * from Rates where code = '{code}'").ToList();

                    // Check if records in the date range exists.
                    if(ratesFromDb.Any(t => t.EffectiveDate.Date == fromDate && 
                        t.EffectiveDate.Date == toDate))
                    {
                        rates = ratesFromDb.Where(
                            t => t.EffectiveDate.Date >= fromDate &&
                            t.EffectiveDate.Date <= toDate).ToList();
                        return rates;
                    }
                    
                    // Get records from API and store it in DB and then return the list.
                    var serviceClient = new ExhangeServiceClient();
                    var exchangeRates = await serviceClient.GetRatesAsync(code, fromDate, toDate);
                    rates = exchangeRates.ToList();

                    foreach (var rate in rates)
                    {
                        if (ratesFromDb.Any(t => t.No == rate.No))
                            continue;

                        string insertQuery = $"INSERT INTO Rates([Currency], [Code], [EffectiveDate], " +
                                $"[Ask], [Bid], [Mid], [No], [Table]) VALUES (" +
                                $"'{rate.Currency}', '{rate.Code}', '{rate.EffectiveDate}', {rate.Ask}," +
                                $"{rate.Bid}, {rate.Mid}, '{rate.No}', '{rate.Table}')";

                        await conn.ExecuteAsync(insertQuery, rate);
                    }

                    return rates;
                }
            }
            catch (SQLiteException ex)
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

        private static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ExchangeDB"].ConnectionString;
        }
    }
}
