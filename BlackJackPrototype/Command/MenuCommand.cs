using BlackJackPrototype.Model;
using BlackJackPrototype.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Command
{
    public class MenuCommand : ButtonCommand
    {
        Navigation nav;
        long cash;
        public MenuCommand(Navigation navigation, long Cash)
        {
            nav = navigation;
            cash = Cash;
        }

        public override void Execute(object parameter)
        {
            nav.CurrentViewModel = new MenuViewModel(nav, cash);
        }
    }
}
