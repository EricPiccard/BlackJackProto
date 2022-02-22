using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Model
{
    public class Hand
    {
        public Stack<Card> Cards { get; }
        public int HandValue { get; set; }
        public handState State { get; set; }
        private bool HasAce { get; set; }
        public Hand()
        {
            Cards = new Stack<Card>();
            HandValue = 0;
            State = handState.Unresolved;
            HasAce = false;
        }
        public void ReceiveCard(Card c)
        {
            Cards.Push(c);
            CalculateHandValue();
        }
        public void CalculateHandValue()
        {
            HandValue = 0;
            foreach(Card c in Cards)
            {
                if(c.Rank == cardRank.Ace)
                {
                    HasAce = true;
                }
                HandValue += c.CardValue;
            }
            if(HandValue <= 11 && HasAce)
            {
                HandValue += 10;
            }
            if(HandValue == 21 && Cards.Count == 2)
            {
                State = handState.BlackJack;
            }
            if(HandValue > 21)
            {
                State = handState.Bust;
            }
        }
    }
}
