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
            
            int[] numbers = { 5, 4, 3, 9, 2 };
            int min = numbers[0];
            for (int i = 1; i < numbers.Length ; i++)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    int reserve = numbers[i + 1];
                    numbers[i + 1] = numbers[i];
                    numbers[i] = reserve;
                }
                if (numbers[i] < numbers[i - 1])
                {
                    int reserve = numbers[i - 1];
                    numbers[i - 1] = numbers[i];
                    numbers[i] = reserve;
                }
                if (numbers[i] < min)
                {
                    int reserve = numbers[0];
                    numbers[0] = numbers[i];
                    numbers[i] = reserve;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
