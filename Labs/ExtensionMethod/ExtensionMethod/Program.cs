using Extensions;
using System;

namespace ExtensionMethod
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is lab extension methods");
            Console.WriteLine("Enter an interger to convert from: ");
            string input = Console.ReadLine();
            int x = int.Parse(input);
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine($"{x} in base {i} is {x.ConvertToBase(i)}");
            }
        }

        static void Main()
        {
                doWork();
        }
    }
}
