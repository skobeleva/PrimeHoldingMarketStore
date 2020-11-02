using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingMarketStore
{
    public class GoldCard : Card
    {
        public GoldCard(string cardHolder) : base(CardType.Gold, cardHolder, 2)
        {

        }
        public override double CurrentRate()
        {
            if (Turnover < 100)
            {
                return InitialRate;
            }
            double rateOfGrowth = 1;
            double amountOfGrowth = 100;
            int maxRate = 10;
            double additionalRate = rateOfGrowth * (int)(Turnover / amountOfGrowth);
            double currentRate = InitialRate + additionalRate;
            if (currentRate > maxRate)
            {
                return maxRate;
            }

            return currentRate;
        }
    }
}
