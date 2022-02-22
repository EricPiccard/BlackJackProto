using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BlackJackPrototype.Model
{
    public class Table
    {
        public Dealer Jack { get; set; }
        public Human Creator { get; set; }
        public List<IPlayer> Players { get; set; }
        public Deck Shoe { get; set; }
        public bool Resolved { get; set; }

        public Table(long ChipStack)
        {
            Jack = new Dealer();
            Creator = new Human(ChipStack);
            Players = new List<IPlayer>();
            Shoe = new Deck();
            Resolved = false;
            Players.Add(Creator);
            Players.Add(Jack);
        }

        public void Deal(int Bet)
        {
            Jack.DealIn();
            Creator.DealIn(Bet);
            foreach(IPlayer p in Players)
            {
                p.Hit(Shoe.DealTopCard());
            }
            foreach (IPlayer p in Players)
            {
                p.Hit(Shoe.DealTopCard());
            }
            CheckTable();
        }
        public void StandPlayer(IPlayer p)
        {
            p.Stand();
            CheckTable();
        }
        public void HitPlayer(IPlayer p)
        {
            p.Hit(Shoe.DealTopCard());
            CheckTable();
        }
        public void DoubleDownPlayer(Human h)
        {
            h.DoubleDown(Shoe.DealTopCard());
            CheckTable();
        }
        public void SplitPlayer(Human h)
        {
            h.Split(Shoe.DealTopCard(), Shoe.DealTopCard());
            CheckTable();
        }
        public void CheckTable()
        {
            if (Creator.UnresolvedHands.Count == 0)
            {
                ResolveTable();
            }
        }
        public void ResolveTable()
        {
            ResolveDealer();
            ResolvePlayer(Creator);
            if (Shoe.Top < 13)
            {
                Shoe.Shuffle();
            }
        }
        public void ResolveDealer()
        {
            while(Jack.CurrentHand.HandValue < 17)
            {
                Jack.Hit(Shoe.DealTopCard());
            }

        }
        public void ResolvePlayer(Human c)
        {
            Hand d = Jack.CurrentHand;
            foreach (HumanHand h in c.ResolvedHands)
            {
                if (h.State == handState.BlackJack)
                {
                    if (d.State == handState.BlackJack)
                    {
                        h.State = handState.Push;
                    }
                }
                else if (d.State == handState.BlackJack)
                {
                    h.State = handState.Lose;
                }
                else if (h.State != handState.Bust)
                {
                    if (d.State == handState.Bust)
                    {
                        h.State = handState.Win;
                    }
                    else if (h.HandValue == d.HandValue)
                    {
                        h.State = handState.Push;
                    }
                    else if (h.HandValue < d.HandValue)
                    {
                        h.State = handState.Lose;
                    }
                    else
                    {
                        h.State = handState.Win;
                    }
                }
            }
            PayPlayer(Creator);
        }
        public void PayPlayer(Human c)
        {
            foreach (HumanHand h in c.ResolvedHands)
            {
                switch (h.State)
                {
                    case handState.BlackJack: c.ChipStack += h.Bet * 3; break;
                    case handState.Win: c.ChipStack += h.Bet * 2; break;
                    case handState.Push: c.ChipStack += h.Bet; break;
                    default: break;
                }
            }
        }
    }
}
