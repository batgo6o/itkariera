using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_homework
{
    class Program
    {
        public static decimal[] inputArray()//getting input
        {
            decimal[] array = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            return array;
        }
        public static void exit(decimal[] array)//printing the array
        {
            Console.WriteLine(string.Join(" ", array));//the printing itself
        }
        public static void sumArray(decimal[] array)//sum of the array
        {
            decimal sum = 0;//counter
            for (int i = 0; i < array.Length; i++)//walking through the array
            {
                sum += array[i];//the addition itself
            }
            Console.WriteLine(sum);//print the sum
        }
        public static void multiplyArray(decimal[] array)
        {
            decimal multiplication = 1;
            for (int i = 0; i < array.Length; i++)
            {
                multiplication *= array[i];
            }
            Console.WriteLine(multiplication);
        }
        static void Main(string[] args)
        {
            Console.Write("Write an array: ");//just to let me know what tf i have to type
            decimal[] input = inputArray();//input
            Console.Write("You just typed the array: ");
            exit(input);//calling the print function
            Console.WriteLine("The sum of the array is: ");
            sumArray(input);//calling the addition function
            Console.Write("The whole array multiplied equals: ");
            multiplyArray(input);//calling the multiplication function
        }
    }
}
