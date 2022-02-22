using BlackJackPrototype.Command;
using BlackJackPrototype.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlackJackPrototype.ViewModel
{
    public class SlotViewModel : ViewModelBase
    {
        public ICommand MenuCommand { get; }
        public SlotViewModel(Navigation nav, MenuViewModel menu)
        {
            MenuCommand = new MenuCommand(nav, menu.Cash);
        }
    }
}
