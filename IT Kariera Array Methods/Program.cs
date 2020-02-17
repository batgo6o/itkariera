using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQextension;

namespace LINQextension
{
    public static class LINQextension
    {
        public static string[] Replace(this string[] array, int index, string replace)
        {
            array[index] = replace;
            return array;
        }
        public static string[] Distinction(this string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int p = 1; p < array.Length; p++)
                {
                    if (array[i] == array[p])
                    {
                        array = array.Except(new string[] { array[p] }).ToArray();
                    }
                }
            }
            return array;
        }
    }
}
namespace IT_Kariera_Array_Methods
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Distinct
            //Reverse
            //Replace

            string[] array = Console.ReadLine().Split(' ').ToArray();
            string[] array1 = { };
            sbyte count = sbyte.Parse(Console.ReadLine());
            string[] selection = new string[count];
            for (int i = 0; i < count; i++)
            {
                selection[i] = Console.ReadLine();
            }
            for (int i = 0; i < selection.Length; i++)
            {
                switch (selection[i])
                {
                    case "Distinct":
                        array = array.Distinct().ToArray();
                        break;
                    case "Reverse":
                        Array.Reverse(array);
                        break;
                    case "Replace":
                        sbyte sel = sbyte.Parse(Console.ReadLine());
                        string replace = Console.ReadLine();
                        array.Replace(sel, replace);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
//