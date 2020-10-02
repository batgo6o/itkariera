using System;
using System.Collections.Generic;
namespace yield
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            students.Add("Sirenhead");
            students.Add("Kondio");
            students.Add("Paco");
            CustomCollection customStudents = new CustomCollection(students);
            foreach (var item in customStudents)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
