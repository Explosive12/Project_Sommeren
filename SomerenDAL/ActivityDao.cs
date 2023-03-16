using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    { // hier komt alle sql queries in.
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT ActiviteitId, Omschrijving, StartTijd, EindTijd FROM Activiteit";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activiteiten = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activiteit = new Activity()
                {
                    ActiviteitId = (int)dr["ActiviteitId"],
                    Omschrijving = dr["Omschrijving"].ToString(),
                    StartTijd = (DateTime)dr["StartTijd"],
                    EindTijd = (DateTime)dr["EindTijd"]
                   
                };
                activiteiten.Add(activiteit);
            }
            return activiteiten;
        }
    }
}