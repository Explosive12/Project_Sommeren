using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SomerenDAL
{

    public class RevenueDAO : BaseDao
    {
        private SqlConnection dbConnection;
        string DateFormat2 = "yyyy-MM-dd";
        public Revenue Select(DateTime startDate, DateTime endDate, Revenue revenue)
        {
            string query = $"select count(orderid) as sales, sum(price) as turnover, count(distinct studentid) as nCustomers from [orders] where date between '{startDate.ToString(DateFormat2)}' and '{endDate.AddDays(1).ToString(DateFormat2)}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Revenue> revenues = new List<Revenue>();
            revenues = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return revenues[0];
        }

        private List<Revenue> ReadTables(DataTable dataTable)
        {
            List<Revenue> revenues = new List<Revenue>();
            foreach (DataRow dr in dataTable.Rows)
            {
                {
                    Revenue revenue = new Revenue();

                    if (Convert.IsDBNull(dr["turnover"]))
                    {
                        revenue.Turnover = 0;
                    }
                    else
                    {
                        revenue.Turnover = (decimal)dr["turnover"];
                    }
                    revenue.Sales = (int)dr["sales"];

                    revenue.NumberOfStudents = (int)dr["nCustomers"];

                    revenues.Add(revenue);
                }
            }
            return revenues;
        }
    }
}
