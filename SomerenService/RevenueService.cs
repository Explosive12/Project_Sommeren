using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class RevenueService
    {
        private RevenueDAO revenueDB;

        public RevenueService()
        {
            revenueDB = new RevenueDAO();
        }

        public Revenue Select(DateTime startDate, DateTime endDate, Revenue revenue)
        {
            revenue = revenueDB.Select(startDate, endDate, revenue);
            return revenue;
        }
    }
}
