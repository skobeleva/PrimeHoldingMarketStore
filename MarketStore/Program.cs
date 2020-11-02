using PrimeHoldingMarketStore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    class Program
    {
        public static void PrintRequiredInformation(int purchaseValue, Card card)
        {

            try
            {
                Console.WriteLine(card.CardType + ":\n"
                           + "Purchase value: $" + purchaseValue.ToString("0.00", CultureInfo.InvariantCulture) + "\n"
                           + "Discount rate: " + Operations.DiscountRate(card).ToString("0.0", CultureInfo.InvariantCulture) + " %" + "\n"
                           + "Discount: $" + Operations.Discount(purchaseValue, card).ToString("0.00", CultureInfo.InvariantCulture) + "\n"
                           + "Total: $" + Operations.TotalPurchaseValue(purchaseValue, card).ToString("0.00", CultureInfo.InvariantCulture) + "\n");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main(string[] args)
        {

            string cardHolder = "Andjelija Skobelev";
            Card card = new BronzeCard(cardHolder);
            PrintRequiredInformation(150, card);

            cardHolder = "Dimitar Skobelev";
            card = new SilverCard(cardHolder);
            card.Turnover = 600;
            PrintRequiredInformation(850, card);

            cardHolder = "Emanuil Popov";
            card = new GoldCard(cardHolder);
            card.Turnover = 1500;
            PrintRequiredInformation(1300, card);

            Console.ReadLine();
        }
    }
}
