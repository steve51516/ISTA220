using System;

namespace Vehicles
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is the vehicles lab.");
            Console.WriteLine("Journey by airplane:");
            Airplane myPlane = new Airplane();
            myPlane.StartEngine("Contact");
            myPlane.TakeOff();
            myPlane.Drive();
            myPlane.Land();
            myPlane.StopEngine("Whirr");
            Console.WriteLine();
            Console.WriteLine("=======================================");
            Console.WriteLine("Journey by car:");
            Car myCar = new Car();
            myCar.StartEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Brake();
            myCar.StopEngine("Phut phut");
            Console.WriteLine("=======================================");
            Console.WriteLine("Journey by truck:");
            Truck steven = new Truck();
            steven.StartEngine("Diesel Clatter");
            steven.Accelerate();
            steven.Drive();
            steven.Brake();
            steven.StopEngine("Clunk Clunk");
            Console.WriteLine("=======================================");
            Console.WriteLine("Journey by boat:");
            Boat titanic = new Boat();
            titanic.StartEngine("Vroom Vroom");
            titanic.Accelerate();
            titanic.Drive();
            titanic.Brake();
            titanic.StopEngine("Glug Glug");
            Console.WriteLine("=======================================");
            Console.WriteLine("\nTesting polymorphism");
            Vehicle v = myCar;
            v.Drive();
            v = myPlane;
            v.Drive();
            v = steven;
            steven.Drive();
            Console.WriteLine("=======================================");


        }

        static void Main()
        {
                doWork();
        }
    }
}