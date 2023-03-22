using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System.Data.Common;
using System;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drinks> GetAllDrinkSupplies()
        {
            string query = "SELECT Dranknr, Naam, Prijs, Voorraad, Aantal_Verkocht FROM Drank";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            List<Drinks> drinks = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drinks drink = new Drinks()
                {
                    Dranknr = (int)dr["Dranknr"],
                    Naam = dr["Naam"].ToString(),
                    Prijs = (decimal)dr["Prijs"],
                    Voorraad = (int)dr["Voorraad"],
                    Aantal_Verkocht = (int)dr["Aantal_Verkocht"]

                };
                drinks.Add(drink);
            }
            return drinks;
        }

      

    }
}