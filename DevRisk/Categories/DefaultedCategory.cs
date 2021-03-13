using CategorizeConsole.Domain;
using CategorizeConsole.Categories.Base;
using System;

namespace DevRiskConsole.Categories
{
    class DefaultedCategory : ICategory
    {
        public ICategory Next { get; set; }

        private DateTime ReferenceDate { get; set; }

        public DefaultedCategory(DateTime _refereceDate)
        {
            this.ReferenceDate = _refereceDate;
        }

        public string CategorizeTrade(Trade trade)
        {
            if ((ReferenceDate.Date.Subtract(trade.NextPaymentDate).TotalDays > 30))
                return "DEFAULTED";
            else
                return Next.CategorizeTrade(trade);
        }
    }
}
