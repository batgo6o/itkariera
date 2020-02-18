using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    int reserve = numbers[i];
                    numbers[i] = numbers[i - 1];
                    numbers[i - 1] = reserve;
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
                    
    }
}
