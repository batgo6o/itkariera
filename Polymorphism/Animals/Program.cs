using System;
using Animals.Entities;
namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            System.Console.WriteLine(cat.ExplainYourself());
        }
    }
}
