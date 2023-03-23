using Microsoft.VisualBasic;
using SomerenModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    
    public class RevenueDAO : BaseDao
    {
        private SqlConnection dbConnection;
        string DateFormat2 = "yyyy-MM-dd";
        public Revenue Select(DateTime startDate, DateTime endDate, Revenue revenue)
        {
            string query = $"select count(ordernr) as sales, sum(prijs) as turnover, count(distinct student) as nCustomers from [order] where datum between '{startDate.ToString(DateFormat2)}' and '{endDate.AddDays(1).ToString(DateFormat2)}'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Revenue> revenues= new List<Revenue>();
            revenues = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            return revenues[0];
        }

        private List<Revenue> ReadTables(DataTable dataTable)
        {
            List<Revenue> revenues = new List<Revenue>();
                foreach (DataRow dr in dataTable.Rows)
                {
                    Revenue revenue = new Revenue()
                    {
                        Sales = (int)dr["sales"],
                        Turnover = (decimal)dr["turnover"],
                        NumberOfStudents = (int)dr["nCustomers"],
                    };

                    revenues.Add(revenue);
                }

            return revenues;
        }
    }
}
