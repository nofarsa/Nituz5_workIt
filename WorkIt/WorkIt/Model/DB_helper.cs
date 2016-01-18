using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkIt.Model
{
    class DB_helper
    {
        public  string connectionString = WorkIt.Properties.Settings.Default.connectionString;


        /// <summary>
        /// To Execute queries which returns result set (table / relation)
        /// </summary>
        /// <param name="query">the query string</param>
        /// <returns></returns>

        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
            }

            
         
        }
        public DataTable ExecuteDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        
                        dataAdapter.Fill(dt);

                    }
                }
            }
            return dt;
                
        }
        public object ExecuteScalar(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    conn.Open();

                    command.CommandType = CommandType.Text;
                    Object o= command.ExecuteScalar();
                    conn.Close();
                    return o;
                }
            }
        }



        
    }
}
