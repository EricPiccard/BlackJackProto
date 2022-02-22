using BlackJackPrototype.ViewModel;
using BlackJackPrototype.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BlackJackPrototype.Model;

namespace BlackJackPrototype
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        Navigation nav;
        public App()
        {
            nav = new Navigation();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            nav.CurrentViewModel = new MenuViewModel(nav, 0);
            base.OnStartup(e);
            MainWindow = new MainWindow();
            MainWindow.DataContext = new MainViewModel(nav);
            MainWindow.Show();
        }
    }
}
