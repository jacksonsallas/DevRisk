using CategorizeConsole.Domain;
using System;
using System.Collections.Generic;

namespace DevRiskConsole
{
    public class NegotiationTrade
    {
        public DateTime ReferenceDate { get; set; }
        public IList<Trade> Trades { get; private set; }

        public NegotiationTrade()
        {
            Trades = new List<Trade>();
        }

        public void AddTrade(Trade trade)
        {
            Trades.Add(trade);
        }
    }
}
