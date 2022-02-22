using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Model
{
    public class Dealer : IPlayer
    {
        public Hand CurrentHand { get; set; }
        public bool Resolved { get; set; }
        public Dealer()
        {
            CurrentHand = null;
            Resolved = false;
        }

        public void DealIn()
        {
            Resolved = false;
            CurrentHand = new Hand();
        }
        public void Hit(Card c)
        {
            CurrentHand.ReceiveCard(c);
        }
        public void Stand()
        {
            Resolved = true;
        }
    }
}
