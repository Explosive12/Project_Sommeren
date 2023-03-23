using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System.Data.Common;
using System;
using System.Configuration;
using System.Collections;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        private SqlConnection dbConnection;

        public void Insert(string student, string drankje, decimal prijs, DateTime datum)
        {
            SqlCommand command = new SqlCommand(
            "INSERT INTO [Order] (student, drankje, prijs, datum) VALUES (@student, @drankje, @prijs, @datum)");
            command.Parameters.AddWithValue("@student", student);
            command.Parameters.AddWithValue("@drankje", drankje);
            command.Parameters.AddWithValue("@prijs", prijs);
            command.Parameters.AddWithValue("@datum", datum);

            command.Connection = OpenConnection();
            command.ExecuteNonQuery();
        }
    }
}