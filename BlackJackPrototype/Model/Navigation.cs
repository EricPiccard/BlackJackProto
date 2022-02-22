using BlackJackPrototype.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackPrototype.Model
{
    public class Navigation
    {
        public ViewModelBase currentViewModel;
        public Navigation()
        {

        }
        public ViewModelBase CurrentViewModel
        {
            get
            {
                return currentViewModel;
            }

            set
            {
                currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action CurrentViewModelChanged;

    }
}

