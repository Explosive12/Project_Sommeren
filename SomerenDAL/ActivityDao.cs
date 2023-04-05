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

        public void AddActivity(Activity activity)
        {
            string query = "INSERT INTO Activiteit (Omschrijving, StartTijd, EindTijd) VALUES (@Omschrijving, @StartTijd, @EindTijd)";
            SqlCommand command = new(query);
            command.Parameters.AddWithValue("@Omschrijving", activity.Omschrijving);
            command.Parameters.AddWithValue("@StartTijd", activity.StartTijd);
            command.Parameters.AddWithValue("@EindTijd", activity.EindTijd);
            command.Connection = OpenConnection();
            command.ExecuteNonQuery();
        }

        public void UpdateActivity(Activity activity)
        {
            string query = "UPDATE Activiteit SET Omschrijving = @Omschrijving, StartTijd = @StartTijd, EindTijd = @EindTijd WHERE ActiviteitId = @ActiviteitId";
            SqlCommand command = new(query);
            command.Parameters.AddWithValue("@ActiviteitId", activity.ActiviteitId);
            command.Parameters.AddWithValue("@Omschrijving", activity.Omschrijving);
            command.Parameters.AddWithValue("@StartTijd", activity.StartTijd);
            command.Parameters.AddWithValue("@EindTijd", activity.EindTijd);
            command.Connection = OpenConnection();
            command.ExecuteNonQuery();
        }

        public void DeleteActivity(Activity activity)
        {
            string query = "DELETE FROM Activiteit WHERE ActiviteitId = @ActiviteitId";
            SqlCommand command = new(query);
            command.Parameters.AddWithValue("@ActiviteitId", activity.ActiviteitId);
            command.Connection = OpenConnection();
            command.ExecuteNonQuery();

        }

        public void DeleteSupervisor(Activity activity, Lecturer lecturer)
        {
            string query = "DELETE FROM ActiviteitSupervisor WHERE ActiviteitId = @ActiviteitId AND DocentId = @DocentId"; 
            SqlCommand command = new(query);
            command.Parameters.AddWithValue("@ActiviteitId", activity.ActiviteitId);
            command.Parameters.AddWithValue("@DocentId", lecturer.Id);
            command.Connection = OpenConnection();
            command.ExecuteNonQuery();
        }

        

        public void AddSuperVisorActivity(Activity activity, Lecturer lecturer)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]{
                new SqlParameter("@DocentID", lecturer.Id),
                new SqlParameter( "@ActiviteitId", activity.ActiviteitId),
            };

            ExecuteEditQuery("INSERT INTO [ActiviteitSupervisor] (DocentID, ActiviteitID) VALUES (@DocentID, @ActiviteitId)", sqlParameters);
        }

        public List<Lecturer> GetAllSupervisorsActivity(int activityId)
        {
            string query = $"SELECT [Name] FROM docent JOIN ActiviteitSupervisor ON docent.DocentId = ActiviteitSupervisor.DocentID WHERE ActiviteitSupervisor.ActiviteitID = {activityId}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesForLecturers(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Lecturer> ReadTablesForLecturers(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    Id = 0,
                    Name = dr["Name"].ToString()
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }

    }
}