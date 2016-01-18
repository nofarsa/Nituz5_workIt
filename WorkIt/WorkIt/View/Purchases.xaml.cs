using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WorkIt.View
{
    /// <summary>
    /// Interaction logic for Purchases.xaml
    /// </summary>
    public partial class Purchases : Window
    {
        public Controller m_controller;
        public Purchases(Controller c)
        {
            InitializeComponent();
            m_controller = c;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NewOrder no = new NewOrder(m_controller);
            no.ShowDialog();
        }
    }
}
