using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class OrderService
    {
        private OrderDao orderDB;

        public OrderService()
        {
            orderDB = new OrderDao();
        }
        public void Insert(string student, string drankje, decimal prijs, DateTime datum)
        {
            orderDB.Insert(student, drankje, prijs, datum);
        }
    }
}
