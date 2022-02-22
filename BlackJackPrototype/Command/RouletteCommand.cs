using BlackJackPrototype.Model;
using BlackJackPrototype.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Command
{
    public class RouletteCommand : ButtonCommand
    {
        Navigation nav;
        MenuViewModel menu;
        public RouletteCommand(Navigation navigation, MenuViewModel Menu)
        {
            nav = navigation;
            menu = Menu;
        }

        public override void Execute(object parameter)
        {
            nav.CurrentViewModel = new RouletteViewModel(nav, menu);
        }
    }
}
