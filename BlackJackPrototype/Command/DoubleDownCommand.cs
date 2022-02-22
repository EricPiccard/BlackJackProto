using System;
using BlackJackPrototype.Model;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using BlackJackPrototype.ViewModel;

namespace BlackJackPrototype.Command
{   
    public class DoubleDownCommand : ButtonCommand
    {
        Table _model;
        BlackJackViewModel _vm;
        public DoubleDownCommand(Table _model, BlackJackViewModel _vm) 
        {
            this._model = _model;
            this._vm = _vm;
        }
        public override void Execute(object parameter)
        {
            _model.DoubleDownPlayer(_model.Creator);
            _vm.RefreshData();
        }
    }
}