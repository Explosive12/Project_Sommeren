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

        public List<ActivitySupervisor> GetActivitySupervisor()
        {
            string query = "select d.[name] as 'supervisor', omschrijving as 'activity name', ac.starttijd from activiteitsupervisor a left join docent d on d.docentID = a.docentID join activiteit ac on ac.activiteitID = a.activiteitID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesSuperviser(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<ActivitySupervisor> ReadTablesSuperviser(DataTable dataTable)
        {
            List<ActivitySupervisor> activiteiten = new List<ActivitySupervisor>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ActivitySupervisor activiteit = new ActivitySupervisor();
                if (Convert.IsDBNull(dr["supervisor"]))
                {
                    activiteit.supervisor = "unsupervised";
                }
                else
                {
                    activiteit.supervisor = (string)dr["supervisor"];
                }; 
                activiteit.activityName = (string)dr["activity name"];
                activiteit.starttijd = (DateTime)dr["starttijd"];

                activiteiten.Add(activiteit);
            }
            return activiteiten;
        }

        public void AddStudentToActivity(Activity activity, Student student)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]{
                new SqlParameter("@StudentId", student.Id),
                new SqlParameter( "@ActiviteitId", activity.ActiviteitId),
            };

            ExecuteEditQuery("INSERT INTO [ActiviteitStudent] (StudentID, ActiviteitID) VALUES (@StudentId, @ActiviteitId)", sqlParameters);
        }

        public void RemoveStudentFromActivity(Activity activity, Student student)
        {
            SqlParameter[] sqlParameters = new SqlParameter[]{
                new SqlParameter("@StudentId", student.Id),
                new SqlParameter( "@ActiviteitId", activity.ActiviteitId),
            };

            ExecuteEditQuery("DELETE FROM [ActiviteitStudent] WHERE StudentID = @StudentId AND ActiviteitID = @ActiviteitId", sqlParameters);
        }

        public List<Student> GetAllStudentsFromActivity(int activityID)
        {
            string query = $"SELECT [Name] FROM Student JOIN ActiviteitStudent ON Student.StudentId = ActiviteitStudent.StudentID WHERE ActiviteitStudent.ActiviteitID = {activityID}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesForStudent(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTablesForStudent(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Id = 0,
                    Name = dr["Name"].ToString()
                };
                students.Add(student);
            }
            return students;
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