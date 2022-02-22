using System;
using BlackJackPrototype.Model;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using BlackJackPrototype.ViewModel;

namespace BlackJackPrototype.Command
{
    public class BlackJackCommand : ButtonCommand
    {
        Navigation nav;
        MenuViewModel menu;
        public BlackJackCommand(Navigation navigation, MenuViewModel Menu)
        {
            nav = navigation;
            menu = Menu;
        }

        public override void Execute(object parameter)
        {
           nav.CurrentViewModel = new BlackJackViewModel(nav, menu);
        }
    }
}
