using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;


namespace SomerenService
{
    public class OrderService
    {
        private OrderDao orderDB;

        public OrderService()
        {
            orderDB = new OrderDao();
        }
        public void Insert(int studentId, int drinkId, decimal price, DateTime date)
        {
            orderDB.Insert(studentId, drinkId, price, date);
        }
    }
}