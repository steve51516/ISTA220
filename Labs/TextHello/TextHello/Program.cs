using System;
namespace TextHello
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string appellation;
            Console.Write("Enter your name: ");
            appellation = Console.ReadLine();
            Console.WriteLine($"Hello, {appellation}");
        }
    }
}
