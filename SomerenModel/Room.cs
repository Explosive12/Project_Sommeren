namespace SomerenModel
{
    public class Room
    {
        public int Id { get; set; }         // database id

        public int BuildingID { get; set; } // building id (1 / 2)
        public int RoomNumber { get; set; }     // RoomNumber, e.g. 206
        public int Capacity { get; set; }   // number of beds, either 4, 6, 8, 12 or 16

        public string KamerType { get; set; }

        public bool Type
        {
            get
            {
                if (Capacity == 8)
                    return false;
                return true;
            } // docent = true, student = false
            set { }
        }
    }
}