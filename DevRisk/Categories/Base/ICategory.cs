using CategorizeConsole.Domain;
using DevRiskConsole;

namespace CategorizeConsole.Categories.Base
{
    public interface ICategory
    {
        string CategorizeTrade(Trade trade);
        public ICategory Next { get; set; }
    }
}
