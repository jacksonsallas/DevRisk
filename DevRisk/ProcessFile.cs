using CategorizeConsole.Domain;
using System;
using System.Globalization;
using System.IO;

namespace DevRiskConsole
{
    public class ProcessFile
    {
        public NegotiationTrade GetDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {   
                var negotiationTrade = new NegotiationTrade();
                negotiationTrade.ReferenceDate = Convert.ToDateTime(sr.ReadLine());
                var numberTrades = Convert.ToInt32(sr.ReadLine());
                var englishCulture = CultureInfo.CreateSpecificCulture("en-US");
                var row = string.Empty;
                
                for(var i = 0; i < numberTrades; i++)
                {
                    row = sr.ReadLine();
                    var data = row.Split(' ');

                    negotiationTrade.AddTrade(new Trade
                    {
                        Value = Convert.ToDouble(data[0]),
                        ClientSector = data[1],
                        NextPaymentDate = DateTime.ParseExact(data[2], "MM/dd/yyyy", englishCulture)
                    });
                }

                return negotiationTrade;
            }
        }
    }
}
