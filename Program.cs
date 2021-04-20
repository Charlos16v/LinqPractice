using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1, StudentName = "John", Age = 18, StandardID = 1},
                new Student() {StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1},
                new Student() {StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2},
                new Student() {StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2},
                new Student() {StudentID = 5, StudentName = "Ron", Age = 21}
            };

            IList<Standard> standardList = new List<Standard>()
            {
                new Standard() {StandardID = 1, StandardName = "Standard 1"},
                new Standard() {StandardID = 2, StandardName = "Standard 2"},
                new Standard() {StandardID = 3, StandardName = "Standard 3"}
            };

            // SELECT EXAMPLE
            var studentNames = studentList.Select(x => x.StudentName).ToList();

            Console.Write(string.Join(", ", studentNames));
            PrintLines();

            // FIRST/LAST EXAMPLE
            var firstStudent = studentList.First();
            Console.Write(firstStudent);
            PrintLines();

            var lastStudent = studentList.Last();
            Console.Write(lastStudent);
            PrintLines();

            // FIRST/LAST OR DEFAULT EXAMPLE
            var firstOrDefaultStudent = studentList.FirstOrDefault();
            Console.Write(firstOrDefaultStudent);
            PrintLines();

            var lastOrDefaultStudent = studentList.LastOrDefault();
            Console.Write(lastOrDefaultStudent);
            PrintLines();


            // PAGINATE
            // EXAMPLE JUMPING 1 AND TAKING THE NEXT 3
            // TAKE/SKIP
            var skipTakeStudents = studentList.Skip(1).Take(3);
            Console.Write(string.Join(", \n", skipTakeStudents));
            PrintLines();


            // OrderBy/OrderByDescending
            var orderByStudentsId = studentList.OrderBy(x => x.StudentID).ToList();
            Console.Write(string.Join(", \n", orderByStudentsId));
            PrintLines();

            var orderByDescendingStudentsId = studentList.OrderByDescending(x => x.StudentID).ToList();
            Console.Write(string.Join(", \n", orderByDescendingStudentsId));
            PrintLines();
        }

        static void PrintLines()
        {
            Console.Write("\n" + "\n" + "==========" + "\n" + "\n");
        }
    }
}