using System.Collections.Generic;

namespace DataArtEntryTask.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<int> Grades { get; set; }
        public Student(string firstName, string lastName)
            => (FirstName, LastName) = (firstName, lastName);
    
        public Student(string firstName, string lastName, IEnumerable<int> grades)
            : this(firstName, lastName)
            => (Grades) = (grades);
    }
}