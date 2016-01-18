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
    /// Interaction logic for EditClass.xaml
    /// </summary>
    public partial class EditClass : Window
    {
        Dictionary<string, string> param;
        public Controller m_controller;

        public EditClass(Controller controller)
        {
            InitializeComponent();
            Cancel = true;
            m_controller = controller;

        }
        private string m_Name;
        public string M_Name { get { return m_Name; } set { m_Name = value; } }

        private string m_days;
        public string Days { get { return m_days; } set { m_days = value; } }

        private string m_h;
        public string Hours { get { return m_h; } set { m_h = value; } }

        private string m_EID;
        public string Eid { get { return m_EID; } set { m_EID = value; } }

        private string m_room;
        public string Room { get { return m_room; } set { m_room = value; } }

        private bool m_cancel = false;
        public bool Cancel { get { return m_cancel; } set { m_cancel = value; } }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {

            if (txtbx_days.ToString() != null && txtbx_H.ToString() != null && txtbx_em.ToString() != null && txtbx_numroom.ToString() != null)
            {

                if (txtbx_Name.Text != "")
                {
                    Cancel = false;
                    param = new Dictionary<string, string>();
                    
                    if (txtbx_days.Text != "")
                        param["Days"] = txtbx_days.Text;
                    if (txtbx_H.Text != "")
                        param["Hours"] = txtbx_H.Text;
                    if (txtbx_em.Text != "")
                        param["Guide_ID"] = txtbx_em.Text;
                    if (txtbx_numroom.Text != "")
                        param["Room_num"] = txtbx_numroom.Text;
                    m_controller.UpdateClass(txtbx_Name.Text, param);
                    MessageBox.Show("Emails were sent to the following customers:");
                }
                else
                {
                    Cancel = true;
                    MessageBox.Show("Error: Please enter valide fields");
                }

            }
            else
            {
                Cancel = true;
                MessageBox.Show("Error: Error input. Please validate class parameters");
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
