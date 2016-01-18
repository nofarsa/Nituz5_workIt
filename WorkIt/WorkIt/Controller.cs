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
        public void ShowCustomers(DataTable customers) 
        {
            m_view.ShowCustomers(customers);
        }
        //mod
        public void CreateOrder(Dictionary<string, string> parameters, Dictionary<string, string> items) 
        {
            //m_model.CreateOrder(parameters);
           // m_model.InsertItemsToOrder(items,parameters["Order_ID"]);
        }

        //view
        public void ShowMessage(string msg) 
        {
            m_view.ShowMessage(msg);
        }
        //mod
        public void SendEvent(string eventName) 
        {
            //m_model.SendEvent(eventName);
        }

       
    }

    

}
