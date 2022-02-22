using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using BlackJackPrototype.Model;
using BlackJackPrototype.Command;

namespace BlackJackPrototype.ViewModel
{
    public class BlackJackViewModel : ViewModelBase
    {
        private Table BlackJackModel;

        public ICommand Deal { get; set; }
        public ICommand Stand { get; set; }
        public ICommand Hit { get; set; }
        public ICommand DoubleDown { get; set; }
        public ICommand Split { get; set; }

        public ICommand MenuCommand { get; }
        MenuViewModel Menu;
        private HandDisplay _dealerCards { get; set; }
        private HandDisplay _creatorCards { get; set; }
        private IList<Card> _dealerHandDisplay { get; set; }
        private IList<Card> _creatorHandDisplay { get; set; }
        private long _betDisplay { get; set; }
        private long _chipStackDisplay { get; set; }
        private string _handStateDisplay { get; set; }
        private int _dealerHandValue { get; set; }
        private int _creatorHandValue { get; set; }
        
        public IList<Card> DealerHandDisplay
        {
            get
            {
                return _dealerHandDisplay;
            }
            set
            {
                _dealerHandDisplay = value;
                OnPropertyChanged("DealerHandDisplay");
            }
        }
        public IList<Card> CreatorHandDisplay
        {
            get
            {
                return _creatorHandDisplay;
            }
            set
            {
                _creatorHandDisplay = value;
                OnPropertyChanged("CreatorHandDisplay");
            }
        }
        public long BetDisplay
        {
            get
            {
                return _betDisplay;
            }
            set
            {
                _betDisplay = value;
                OnPropertyChanged("BetDisplay");
            }
        }
        public long ChipStackDisplay
        {
            get
            {
                return _chipStackDisplay;
            }
            set
            {
                _chipStackDisplay = value;
                OnPropertyChanged("ChipStackDisplay");
            }
        }
        public string HandStateDisplay
        {
            get
            {
                return _handStateDisplay;
            }
            set
            {
                _handStateDisplay = value;
                OnPropertyChanged("HandStateDisplay");
            }
        }
        public int DealerHandValue
        {
            get
            {
                return _dealerHandValue;
            }
            set
            {
                _dealerHandValue = value;
                OnPropertyChanged("DealerHandValue");
            }
        }
        public int CreatorHandValue
        {
            get
            {
                return _creatorHandValue;
            }
            set
            {
                _creatorHandValue = value;
                OnPropertyChanged("CreatorHandValue");
            }
        }

        public int BetValue{ get; set; }

        public BlackJackViewModel(Navigation nav, MenuViewModel menu)
        {
            BlackJackModel = new Table(menu.Cash);
            
            Deal = new DealCommand(BlackJackModel, this);
            Stand = new StandCommand(BlackJackModel, this);
            Hit = new HitCommand(BlackJackModel, this);
            DoubleDown = new DoubleDownCommand(BlackJackModel, this);
            Split = new SplitCommand(BlackJackModel, this);
            ChipStackDisplay = menu.Cash;
            MenuCommand = new MenuCommand(nav, menu.Cash);
        }
        public void RefreshData()
        {
            _dealerCards = new HandDisplay(BlackJackModel.Jack);
            _creatorCards = new HandDisplay(BlackJackModel.Creator);
            DealerHandDisplay = _dealerCards.Cards;
            CreatorHandDisplay = _creatorCards.Cards;
            BetDisplay = BlackJackModel.Creator.UnresolvedHands.Count > 0 ? BetDisplay = ((HumanHand)BlackJackModel.Creator.CurrentHand).Bet : 0;
            ChipStackDisplay = BlackJackModel.Creator.ChipStack;
            HandStateDisplay = BlackJackModel.Creator.CurrentHand.State.ToString();
            DealerHandValue = BlackJackModel.Jack.CurrentHand.HandValue;
            CreatorHandValue = BlackJackModel.Creator.CurrentHand.HandValue;
            
        }       
        

    }
}
