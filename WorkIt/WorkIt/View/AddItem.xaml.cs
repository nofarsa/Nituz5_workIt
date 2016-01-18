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
        

        public AddItem()
        {
            InitializeComponent();
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
                    
                if (txtbx_ItemCode.Text != "")
                    param.Add("ItemCode", txtbx_ItemCode.Text);
                if (txtbx_Amount.Text != "")
                    param.Add("Amount", txtbx_Amount.Text);
                
                }
                
            
        }
    }
}
