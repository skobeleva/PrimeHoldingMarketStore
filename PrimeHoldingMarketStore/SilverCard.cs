using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingMarketStore
{
    public class SilverCard:Card
    {
        public SilverCard(string cardHolder) : base(CardType.Silver, cardHolder, 2)
        {

        }

        public override double CurrentRate()
        {
            if (Turnover <= 300)
            {
                return InitialRate;
            }

            return 3.5;
        }
    }
}
