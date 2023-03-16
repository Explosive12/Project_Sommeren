using System;

namespace SomerenModel
{
    public class Student
    { // moet altijd overeen komen met de database.
        public int Id { get; set; }     // database id
        public string Name { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
        public DateTime BirthDate { get; set; }
    }
}