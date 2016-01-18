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
    /// Interaction logic for SendEvent.xaml
    /// </summary>
    public partial class SendEvent : Window
    {
        //Dictionary<string, string> param;
        public Controller m_controller;

        public SendEvent(Controller c)
        {
            InitializeComponent();
            this.m_controller = c;
        }

        private bool m_cancel = false;
        public bool Cancel { get { return m_cancel; } set { m_cancel = value; } }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if (txtbx_EventName.Text != "")
            {
                if (m_controller.checkValue("Events", txtbx_EventName.Text))
                {
                    MessageBox.Show("The Event does not exist in the system");
                    return;
                }
                m_controller.SendEvent(txtbx_EventName.Text);
            }
            this.Close();

        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            Cancel = true;
            this.Close();
        }
    }
}
