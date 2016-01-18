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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkIt;
using WorkIt.Model;
using WorkIt.View;

namespace WorkIt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IView
    {
        public Controller m_controller;
        public MainWindow()
        {
            m_controller = new Controller() ;
            DBModel model= new DBModel(m_controller);
            m_controller.SetModel(model);
            m_controller.SetView(this);
            InitializeComponent();
        }

        private void btn_employees_Click(object sender, RoutedEventArgs e)
        {
            Employees emp = new Employees();
            emp.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Customers cust = new Customers();
            cust.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Classes lass = new Classes(m_controller);
            lass.ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Stock stk = new Stock();
            stk.ShowDialog();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Purchases prch = new Purchases();
            prch.ShowDialog();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            PotentialCustomers pc = new PotentialCustomers();
            pc.ShowDialog();
        }

        public void ShowMessage(string msg)
        {
            throw new NotImplementedException();
        }

        public void ShowCustomers(System.Data.DataTable customers)
        {
            throw new NotImplementedException();
        }
    }
}
