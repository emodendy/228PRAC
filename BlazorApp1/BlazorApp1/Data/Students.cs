using System;
using System.Data;

namespace BlazorApp1.Data
{
    public class Students
    {
        public Students(int iD, string surname, string name, string lastName, string group, string photo, DateTime dateOfBirth)
        {
            ID = iD;
            Surname = surname;
            Name = name;
            LastName = lastName;
            Group = group;
            Photo = photo;
            DateOfBirth = dateOfBirth;
        }

        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public string Photo { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
    
}
