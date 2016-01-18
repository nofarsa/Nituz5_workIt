using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkIt.Model
{
    public class DBModel
    {

        private Controller m_controller;
        private DB_helper helper;
        public DBModel(Controller controller)
        {
            m_controller = controller;
            helper = new DB_helper();
        }
        public void UpdateClass(string className, Dictionary<string, string> parameters)
        {
            string query = "Update master..Classes Set";
            foreach (string paramName in parameters.Keys)
            {
                if (paramName=="Guide_ID"||paramName=="Room_num")
                    query += "[" + paramName + "]" + "=" + parameters[paramName] + ",";
                else
                    query += "[" + paramName + "]" + "='" + parameters[paramName] + "',";
                

            }
            query = query.Substring(0, query.Length - 1);
            query += " where Name='" + className + "'";
            helper.ExecuteNonQuery(query);
            string query2 = "select C.Name,C.Mail from master..Customers C inner join master..Customres_In_Classes CIC on C.ID=CIC.Customer_ID where CIC.Class_Name='" + className+"'";
            DataTable res = helper.ExecuteDataTable(query2);
           // m_controller.ShowMessage("The Class " + className + " was updated successfuly, Mail was s);
            m_controller.ShowCustomers(res);

        }
        
        
        public void CreateOrder(Dictionary<string, string> parameters) 
        {
            string query = "Insert Into master..Orders select";
            foreach (string paramName in parameters.Keys)
            {
                if (paramName=="ID")
                    query += "[" + paramName + "]" + "=" + parameters[paramName] + ",";
                else
                    query += "[" + paramName + "]" + "='" + parameters[paramName] + "',";
            }
            query += "[Order_Date]=CURDATE(), [IsArrived]=0";
            helper.ExecuteNonQuery(query);
            
        }

        public void InsertItemsToOrder(Dictionary<string,string> items,string Order_ID)
        { 
            string query="";
            foreach (string item in items.Keys)
            {
                query = "INSERT INTO master..Items_In_Orders VALUES("+Order_ID+","+item+","+items[item]+")";
                helper.ExecuteNonQuery(query);
            }
            m_controller.ShowMessage("The Order was added successfuly");

        }
        
        
        public void SendEvent(string eventName)
        {
            string query = "select C.Name,C.Mail from master..Customers C inner join master..Customres_In_Events CIE on C.ID=CIE.Customer_ID where CIE.Name=" + eventName;
            DataTable res = helper.ExecuteDataTable(query);
            m_controller.ShowMessage("The Event " + eventName + " was send successfuly to the relvant customers");
            m_controller.ShowCustomers(res);
        }
        

        public bool checkValue(string query)
        {
            int ans = Convert.ToInt32(helper.ExecuteScalar(query));
            if (ans == 0)
                return true;
            else
                return false;
        }

    }
}
