using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C sharp quiz 2.");
            Console.Write("Please enter the number of integers to add: ");
            string strNumber = Console.ReadLine();
            int end = Int32.Parse(strNumber);
            int start = 0;
            int sum = 0;
            int newsum = GetSums(start, end, sum);
            Console.WriteLine($"The sum is {newsum}");
        }
        static int GetSums(int start, int end, int sum)
        {
            if (end == 0)
            {
                Console.WriteLine($"{sum} {start} {sum + start}");
                return sum + start;
            }
            else
            {
                Console.WriteLine($"{sum} {start} {sum + start}");
                return GetSums(start + sum, --end, ++sum);
            }
        }
    }
}
