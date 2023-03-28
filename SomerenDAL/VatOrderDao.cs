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
    public class VatOrderDao : BaseDao
    {
        public List<VatOrder> GetAllVatOrders()
        {
        // SQL Querry right below!!
            string query = "SELECT O.price, O.date, D.IsAlcohol FROM Orders O JOIN drank D ON O.drinkId = D.Dranknr";
                return ReadTables(ExecuteSelectQuery(query));
        }
        
        private List<VatOrder> ReadTables(DataTable dataTable)
        {
            List<VatOrder> vatOrders = new();

            foreach (DataRow dr in dataTable.Rows)
            {
                VatOrder vatOrder = new()
                {
                    Price = (decimal)dr["price"],
                    Date = (DateTime)dr["Date"],
                    IsAlcohol = (bool)dr["IsAlcohol"]
                };
                vatOrders.Add(vatOrder);
            }
            return vatOrders;
        }

    }
}
