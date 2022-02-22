using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Model
{
    public interface IPlayer
    {
        public Hand CurrentHand { get; set; }

        public abstract void Stand();
        public abstract void Hit(Card c);
    }
}
