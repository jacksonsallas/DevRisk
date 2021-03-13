using CategorizeConsole.Categories.Base;
using CategorizeConsole.Domain;

namespace DevRiskConsole.Categories
{
    public class WithoutCategory : ICategory
    {
        public ICategory Next { get; set; }

        public string CategorizeTrade(Trade trade)
        {
            return string.Empty;
        }
    }
}
