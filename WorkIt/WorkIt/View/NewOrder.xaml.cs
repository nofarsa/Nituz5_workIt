﻿using System;
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
    /// Interaction logic for NewOrder.xaml
    /// </summary>
    public partial class NewOrder : Window
    {
        Dictionary<string, string> param;
        Dictionary<string, string> paramitem;
        public Controller m_controller;
        public NewOrder(Controller c)
        {
            InitializeComponent();
            this.m_controller = c;
            
        }

        private bool m_cancel = false;
        public bool Cancel { get { return m_cancel; } set { m_cancel = value; } }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            if (txtbx_OrderID.Text != "")
            {
                Cancel = false;
                param = new Dictionary<string, string>();
                paramitem = new Dictionary<string, string>();
                if (txtbx_OrderID.Text != "")
                { 
                    if (!m_controller.checkValue("Order_ID", txtbx_OrderID.Text))
                       {
                        MessageBox.Show("The Order ID already exists in the System. Please choose different Order ID");
                        return;
                       }
                    param["Order_ID"] = txtbx_OrderID.Text;
                }
                if (txtbx_Suppplier.Text != "") {
                    if (m_controller.checkValue("Suppliers", txtbx_Suppplier.Text))
                    {
                        MessageBox.Show("The supplier doesn't exists in the System. Please choose the correct suppliers");
                        return;
                    }
                    param["Suppplier"] = txtbx_Suppplier.Text;

                        }
                if (txtbx_Destination.Text != "")
                    param["Destination"] = txtbx_Destination.Text;
                if (param.Count != 3) { 
                    MessageBox.Show("Please enter all order fields");
                    return;
                }
                AddItem at = new AddItem(m_controller);
                at.ShowDialog();
                paramitem = at.GetDic();
                m_controller.CreateOrder(param, paramitem);
                
            }
            else
            {
                Cancel = true;
                MessageBox.Show("Error: Please enter valide fields");
            }
            

        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            Cancel = true;
            this.Close();
        }
    }
}
