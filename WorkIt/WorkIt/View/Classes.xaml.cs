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
    /// Interaction logic for Classes.xaml
    /// </summary>
    public partial class Classes : Window
    {
        public Controller m_controller;
        public Classes(Controller controller)
        {
            m_controller = controller;
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            EditClass ed = new EditClass(m_controller);
            ed.ShowDialog();
            
        }
    }
}
