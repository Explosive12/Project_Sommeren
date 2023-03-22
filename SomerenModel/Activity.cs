using System;

namespace SomerenModel
{
    public class Activity
    { // moet altijd overeen komen met de database.
        public int ActiviteitId { get; set; }     // database id
        public string Omschrijving { get; set; }
        public DateTime StartTijd { get; set; } // Tijd, e.g. 23-03-2021
        public DateTime EindTijd { get; set; } // Tijd, e.g. 23-03-2021
        
    }
}