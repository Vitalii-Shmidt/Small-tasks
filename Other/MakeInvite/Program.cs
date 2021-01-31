using System;
using System.Collections.Generic;
using System.Linq;
using DataArtEntryTask.Models;

namespace DataArtEntryTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var students = new Student[] 
            {
                new Student("V.", "Shmidy", new int[] {int.MinValue, int.MinValue, int.MinValue, int.MinValue}),
                new Student("P.", "Sidorov", new int[] {int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue}),
                new Student("I.", "Ivanov", new int[] {5, 5, 4})
            };
        
            var invite = MakeInvite(students);

            System.Console.WriteLine(invite);
        }


        private static string MakeInvite(IEnumerable<Student> students)
        {
            if(students is null)
            {
                throw new NullReferenceException($"Students-list is non-initialized! Crushed here: {nameof(MakeInvite)}");
            }

            if(students.Count() == 0)
            {
                return "Bad students! Any invites!";
            }
            
            var goodStudents = GetGoodStudents(students);
            
            if(goodStudents.Count() == 1)
            {
                return "Well done, son[of SUN]. Welcome to the club!";
            }

            var goodStudentsToDisplay = goodStudents
                .Select(student => student.LastName + " " + student.FirstName);
        
            return "Nice results sweeties! " 
            +  string.Join(", ", goodStudentsToDisplay)
            + ". Waiting for you on interview!";
        }

        private static IEnumerable<Student> GetGoodStudents(IEnumerable<Student> students)
            => students.Where(student => student.Grades.Average() >= 4);
    }
}
