using System.Data.SqlClient;
using System;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public void Insert(int studentId, int drinkId, decimal price, DateTime date)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]{
                new SqlParameter("@StudentId", studentId),
                new SqlParameter( "@DrinkId", drinkId),
                new SqlParameter( "@Price", price),
                new SqlParameter( "@Date", date),
            };

            ExecuteEditQuery("INSERT INTO [Orders] (studentId, drinkId, price, date) VALUES (@studentId, @drinkId, @price, @date)", sqlParameters);
        }
    }
}
