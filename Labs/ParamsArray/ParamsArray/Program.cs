using System;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is lab 11.");
            Console.WriteLine(Util.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
            //Console.WriteLine("Using parameter list");
            Console.WriteLine(Util.Sum(1));
            Console.WriteLine(Util.Sum(1, 3));
            Console.WriteLine(Util.Sum(1, 3, 5));
            Console.WriteLine(Util.Sum(1, 3, 5, 7, 9));
            Console.WriteLine("==========================================");
            Util util = new Util();
            Console.WriteLine(util.Total(5, 8));


        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
