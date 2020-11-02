using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingMarketStore
{
    public class Operations
    {
        public static double DiscountRate(Card card)
        {
            if (card == null)
            {
                return 0;
            }
            
            return card.CurrentRate();
        }

        public static double Discount(double purchaseValue, Card card)
        {
            return DiscountRate(card) / 100 * purchaseValue;
        }

        public static double TotalPurchaseValue(double purchaseValue, Card card)
        {
            return purchaseValue - Discount(purchaseValue, card);
        }
    }
}
