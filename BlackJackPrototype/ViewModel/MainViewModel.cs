using BlackJackPrototype.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        Navigation nav = new Navigation();
        public ViewModelBase CurrentViewModel => nav.CurrentViewModel;

        public MainViewModel(Navigation navigationStore)
        {
            nav = navigationStore;

            nav.CurrentViewModelChanged += ViewModelChange;
        }

        private void ViewModelChange()
        {
            OnPropertyChanged("CurrentViewModel");
        }
    }
}
