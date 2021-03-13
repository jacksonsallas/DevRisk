using CategorizeConsole.Categories.Base;
using CategorizeConsole.Domain;

namespace CategorizeConsole.Categories
{
    public class HighRiskCategory : ICategory
    {
        public ICategory Next { get; set; }

        public string CategorizeTrade(Trade trade)
        {
            if (trade.Value > 1000000 && "Private".Equals(trade.ClientSector))
                return "HIGHRISK";
            else
                return Next.CategorizeTrade(trade);
        }
    }
}
