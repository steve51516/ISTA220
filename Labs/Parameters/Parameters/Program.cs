using System;

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine($"In part one i is {i}");
            Pass.Value(i);
            Console.WriteLine($"In part one i is {i}");
            Console.WriteLine("====================================");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine($"In part two wi.Number is {wi.Number}");
            Pass.Reference(wi);
            Console.WriteLine($"In part two wi.Number is now {wi.Number}");
            Console.WriteLine("====================================");


            Console.WriteLine($"In part three i is {i}");
            Pass.Value1(ref i);
            Console.WriteLine($"In part three i is {i}");
            Console.WriteLine("====================================");
        }

        static void Main(string[] args)
        {
                doWork();
        }
    }
}
