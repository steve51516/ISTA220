using System;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("Running class program");
            Point origin = new Point();
            Point bottom = new Point();
            Point proof = new Point();
            Point bottomRight = new Point(1366, 768);
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            Point jennifer = new Point(0, 0);
            Point johnny = new Point(3, 4);
            distance = jennifer.DistanceTo(johnny);
            Console.WriteLine($"Distance between Jennifer and Johnny is: {distance}");
            Point peter = new Point(63, 180);
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
        }

        static void Main(string[] args)
        {
                doWork();
        }
    }
}
