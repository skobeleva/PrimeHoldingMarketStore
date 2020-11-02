using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHoldingMarketStore
{
    public enum CardType
    {
        Bronze, Gold, Silver
    }
    public abstract class Card
    {
        private CardType cardType;
        private double initialRate;
        private double turnover;
        private string cardholder;

        public Card(CardType cardType, string cardHolder, double initialRate)
        {
            this.CardType = cardType;
            this.Cardholder = cardHolder;
            this.InitialRate = initialRate;
        }

        public string Cardholder { get => cardholder; set => cardholder = value; }
        public double InitialRate { get => initialRate; set => initialRate = value; }
        public double Turnover { get => turnover; set => turnover = value; }
        public CardType CardType { get => cardType; set => cardType = value; }

        public abstract double CurrentRate();

        

    }
}
