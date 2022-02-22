using System;
using System.Collections.Generic;
using System.Text;
using BlackJackPrototype.Model;

namespace BlackJackPrototype.Model
{
    public class HandDisplay
    {
        public List<Card> Cards;

        public HandDisplay(IPlayer p)
        {
            Cards = new List<Card>();
            
            if(p.CurrentHand != null)
            {
                foreach (Card c in p.CurrentHand.Cards)
                {
                    Cards.Add(c);
                }
            }
        }
    }
}
