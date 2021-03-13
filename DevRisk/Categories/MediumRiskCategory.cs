using CategorizeConsole.Categories.Base;
using CategorizeConsole.Domain;

namespace DevRiskConsole.Categories
{
    public class MediumRiskCategory : ICategory
    {
        public ICategory Next { get; set; }

        public string CategorizeTrade(Trade trade)
        {
            if (trade.Value > 1000000 && "Public".Equals(trade.ClientSector))
                return "MEDIUMRISK";
            else
                return Next.CategorizeTrade(trade);
        }
    }
}
