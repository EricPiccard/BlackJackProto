using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Model
{
    public class Deck
    {
        public List<Card> Cards { get; }
        public int Top { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card NewCard = new Card((cardRank)j, (cardSuit)i);
                    Cards.Add(NewCard);
                }
            }
            Shuffle();
            Top = Cards.Count - 1;
        }
        public void Shuffle()
        {
            Random r = new Random();
            for(int i = 51; i > 0; i--)
            {
                int RandomIndex = r.Next(i);
                Card TempCard = Cards[i];
                Cards[i] = Cards[RandomIndex];
                Cards[RandomIndex] = TempCard;
            }
            Top = Cards.Count - 1;
        }
        public Card DealTopCard()
        {
            return Cards[Top--];
        }
    }
}
