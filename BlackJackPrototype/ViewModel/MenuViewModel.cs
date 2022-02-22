using BlackJackPrototype.Command;
using BlackJackPrototype.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace BlackJackPrototype.ViewModel
{
    public class MenuViewModel : ViewModelBase
    {
        public ICommand BlackJackCommand { get; }
        public ICommand SlotsCommand { get; }
        public ICommand RouletteCommand { get; }

        //public int cash;
        // public int Cash { get; set; }
       
        public long Cash { get; set; }

        

        public MenuViewModel(Navigation nav, long cash)
        {
            Cash = cash;
            BlackJackCommand = new BlackJackCommand(nav, this);
            SlotsCommand = new SlotsCommand(nav, this);
            RouletteCommand = new RouletteCommand(nav, this);

        }
    }
}
