using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using BlackJackPrototype.Command;
using BlackJackPrototype.Model;

namespace BlackJackPrototype.ViewModel
{
    public class RouletteViewModel : ViewModelBase
    {
        public ICommand MenuCommand { get; }
        public RouletteViewModel(Navigation nav, MenuViewModel _vm)
        {
            MenuCommand = new MenuCommand(nav, _vm.Cash);
        }
    }
}
