using CategorizeConsole.Categories;
using CategorizeConsole.Categories.Base;
using DevRiskConsole.Categories;
using System;

namespace DevRiskConsole
{
    public class TradeClassifier
    {
        public void Classifier(NegotiationTrade negotiationTrade)
        {
            ICategory t1 = new DefaultedCategory(negotiationTrade.ReferenceDate);
            ICategory t2 = new HighRiskCategory();
            ICategory t3 = new MediumRiskCategory();
            ICategory t4 = new WithoutCategory();

            t1.Next = t2;
            t2.Next = t3;
            t3.Next = t4;

            foreach (var trade in negotiationTrade.Trades)
                Console.WriteLine(t1.CategorizeTrade(trade));
        }
    }
}
