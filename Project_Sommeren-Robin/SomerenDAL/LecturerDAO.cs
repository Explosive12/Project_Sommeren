using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class LecturerDAO : BaseDao
    { // hier komt alle sql queries in.
        public List<Lecturer> GetAllLecturers()
        {
            string query = "SELECT DocentId, Name FROM docent";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    Id = (int)dr["DocentId"],
                    Name = dr["Name"].ToString()
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}
