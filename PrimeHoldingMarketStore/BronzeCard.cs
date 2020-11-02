using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingMarketStore
{
    public class BronzeCard : Card
    {
        public BronzeCard(string cardHolder):base(CardType.Bronze, cardHolder,0)
        {
                
        }
        
        public override double CurrentRate()
        {
            if (Turnover < 100)
            {
                return InitialRate;
            }

            if (Turnover <= 300)
            {
                return 1;
            }

            return 2.5;
        }
    }
}
