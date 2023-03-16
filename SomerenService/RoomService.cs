using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDAO roomdatabase;

        public RoomService()
        {
            roomdatabase = new RoomDAO();
        }

        public List<Room> GetRooms()
        {
            List<Room> rooms = roomdatabase.GetAllRooms();
            return rooms;
        }
    }
}
