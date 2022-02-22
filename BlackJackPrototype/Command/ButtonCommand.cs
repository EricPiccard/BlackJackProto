using System;
using BlackJackPrototype.Model;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BlackJackPrototype.Command
{
    public abstract class ButtonCommand : ICommand
    {
        
        public event EventHandler CanExecuteChanged;
   
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public abstract void Execute(object parameter);
        public void OnCanExecutedChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, new EventArgs());
            }
        }
    }
}
