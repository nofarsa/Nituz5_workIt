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
    /// Interaction logic for AddItem.xaml
    /// </summary>
    public partial class AddItem : Window
    {
        public Dictionary<string, string> param;
        public Controller m_controller;

        public AddItem(Controller controller)
        {
            InitializeComponent();
            m_controller = controller;
            param = new Dictionary<string, string>();
        }

        private bool m_cancel = false;
        public bool Cancel { get { return m_cancel; } set { m_cancel = value; } }


        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            Cancel = true;
            this.Close();
        }

        public Dictionary<string, string> GetDic() {

            return param;
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            
                if (txtbx_ItemCode.Text != "")
                {
                    Cancel = false;
                    
                if (txtbx_ItemCode.Text != "") {
                    if (m_controller.checkValue("Items", txtbx_ItemCode.Text))
                    {
                        MessageBox.Show("The Item does not exist in the system");
                        return;
                    }
                   
                }
                if (txtbx_Amount.Text != "") {
                    int i = 0;
                    if (!int.TryParse(txtbx_Amount.Text, out i))
                    {
                        MessageBox.Show("Please enter a valid number");
                        return;
                    }
                   
                }
                param.Add(txtbx_ItemCode.Text, txtbx_Amount.Text);
                txtbx_Amount.Text = "";
                txtbx_ItemCode.Text = "";

            }
                
            
        }
    }
}
