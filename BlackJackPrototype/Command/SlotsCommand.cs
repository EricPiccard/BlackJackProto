using System;
using System.Collections.Generic;
using System.Text;
using BlackJackPrototype.Model;
using BlackJackPrototype.ViewModel;

namespace BlackJackPrototype.Command
{
    public class SlotsCommand : ButtonCommand
    {
        Navigation nav;
        MenuViewModel menu;
        public SlotsCommand(Navigation navigation, MenuViewModel Menu)
        {
            nav = navigation;
            menu = Menu;
        }

        public override void Execute(object parameter)
        {
            nav.CurrentViewModel = new SlotViewModel(nav, menu);
        }
    }
}
