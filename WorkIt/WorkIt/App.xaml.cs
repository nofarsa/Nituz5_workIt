using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WorkIt.Model;

namespace WorkIt
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        
            public App()
            { }
        /*
            public void OnStartup(object sender, StartupEventArgs e)
            {
                Controller contro = new Controller();
                DBModel model = new DBModel(contro);
                IView view = new MainWindow(contro);
                contro.SetModel(model);
                contro.SetView(view);
                ((MainWindow)view).Show();
            }
            */
    }
}
