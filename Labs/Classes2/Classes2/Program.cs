using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Square jennifer = new Square(33);
            int area = jennifer.area(33);
            Console.WriteLine($"Area is {area}");
            string hi = jennifer.Hello();
            Console.WriteLine(hi);

            Circle johnny = new Circle();
            double area1 = johnny.area(66);
            Console.WriteLine($"Area is {area}");
            string howdy = johnny.Greeting();
            Console.WriteLine(howdy);
        }
    }
}
