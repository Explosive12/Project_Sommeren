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
        public void Insert(string student, string drankje, decimal prijs, DateTime datum)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]{ 
                new SqlParameter("@student", student), 
                new SqlParameter( "@drankje", drankje),
                new SqlParameter( "@prijs", prijs),
                new SqlParameter( "@datum", datum),
            };

            ExecuteEditQuery("INSERT INTO [Order] (student, drankje, prijs, datum) VALUES (@student, @drankje, @prijs, @datum)", sqlParameters);
        }
    }
}
