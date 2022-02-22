using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Model
{
    public class HumanHand : Hand
    {
        public int Bet { get; set; }
        public HumanHand(int Bet) : base()
        {
            this.Bet = Bet;
        }
        public Card TakeCard()
        {
            return Cards.Pop();
        }
    }
}
