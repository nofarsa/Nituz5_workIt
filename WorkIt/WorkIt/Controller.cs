using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkIt.Model;

namespace WorkIt
{
    public class Controller
    {
        private DBModel m_model;
        private IView m_view;

        public Controller()
        {

        }
        public void SetModel(DBModel model)
        {
            m_model = model;
        }

        public void SetView(IView view)
        {
            m_view = view;
        }
        //mod
        public void UpdateClass(string className, Dictionary<string,string> parameters)
        {
            m_model.UpdateClass(className, parameters);
        }
        //view
        public void ShowCustomers(DataTable customers,string msg) 
        {
            m_view.ShowCustomers(customers,msg);
        }
        //mod
        public void CreateOrder(Dictionary<string, string> parameters, Dictionary<string, string> items) 
        {
            m_model.CreateOrder(parameters);
            m_model.InsertItemsToOrder(items,parameters["Order_ID"]);
        }

        //view
        public void ShowMessage(string msg) 
        {
            m_view.ShowMessage(msg);
        }
        //mod
        public void SendEvent(string eventName) 
        {
            m_model.SendEvent(eventName);
        }

        public bool checkValue(string class_Name,string value)
        {

            string query = "";
            if (class_Name == "Classes")    
                query = "select count(*) from master..Classes where Name='" + value + "'";
            else if (class_Name == "Suppliers")
                query = "select count(*) from master..Supppliers where Name='" + value + "'";
            else if (class_Name == "Order_ID")
                query = "select count(*) from master..Orders where Order_ID=" + value + "";
            else if (class_Name == "Items")
                query = "select count(*) from master..Items where Item_Code=" + value + "";
            else if (class_Name == "Events")
                query = "select count(*) from master..Eventes where Name='" + value + "'";
            else if (class_Name == "Classes2")
                query = "select count(*) from master..Classes where Guide_ID=" + value + "";
            return m_model.checkValue(query);
        }
       
    }

    

}
