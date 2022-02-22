using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Model
{
    public struct Card
    {        
        public readonly cardRank Rank;
        public readonly cardSuit Suit;
        public string Display { get; set; }
        public readonly int CardValue;
        public Card(cardRank Rank, cardSuit Suit)
        {
            this.Rank = Rank;
            this.Suit = Suit;
            Display = Rank + " of " + Suit;
            
            switch (Rank)
            {
                case cardRank.Jack:
                case cardRank.Queen:
                case cardRank.King: CardValue = 10; break;
                default: CardValue = (int)Rank + 1; break;
            }
        }
    }
}
