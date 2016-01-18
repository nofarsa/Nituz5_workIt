using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkIt
{
    public interface IView
    {
        void ShowMessage(string msg);
        void ShowCustomers(DataTable customers);
    }
}
