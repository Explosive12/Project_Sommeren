using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class RoomDAO : BaseDao
    {

        public List<Room> GetAllRooms()
        {
            string sqlQuery = "SELECT KamerID, Kamernummer, Aantal_Bedden, Kamertype FROM Kamer";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(sqlQuery, sqlParameters));
        }

        
        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Room room = new()
                {
                    Id = (int)datarow["KamerID"],
                    RoomNumber = (int)datarow["Kamernummer"],

                    Capacity = (int)datarow["Aantal_Bedden"],
                    Type = (int)datarow["Aantal_Bedden"] == 8 ? false : true

                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
