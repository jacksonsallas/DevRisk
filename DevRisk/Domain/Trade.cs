using System;

namespace CategorizeConsole.Domain
{
    public class Trade
    {
        public double Value { get; set; } 
        public string ClientSector { get; set; } 
        public DateTime NextPaymentDate { get; set; }
    }
}
