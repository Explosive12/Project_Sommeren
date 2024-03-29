﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    { // hier komt alle sql queries in.
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentId, Name FROM Student";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Id = (int)dr["StudentId"],
                    Name = dr["Name"].ToString()
                };
                students.Add(student);
            }
            return students;
        }
    }
}