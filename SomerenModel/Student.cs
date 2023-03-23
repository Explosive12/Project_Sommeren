using System;

namespace SomerenModel
{
    public class Student
    { // moet altijd overeen komen met de database.
        public int Id { get; set; }     // student id
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }


        public string DisplayMember { get { return $"{Id}. {Name} "; } }
    }
}