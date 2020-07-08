using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is C Sharp quiz 1");
            Console.WriteLine("PART 1");
            Console.WriteLine("MM           MM SSSSSSSS SSSSSSSS        AAAAAA");
            Console.WriteLine("MMM         MMM SSSSSSSS SSSSSSSS        AA  AA");
            Console.WriteLine("MMMM       MMMM SS       SS             AA    AA");
            Console.WriteLine("MM  MM   MM  MM SS       SS             AA    AA");
            Console.WriteLine("MM   MM MM   MM SSSSSSSS SSSSSSSS       AAAAAAAAA");
            Console.WriteLine("MM     MM    MM SSSSSSSS SSSSSSSS      AAAAAAAAAA");
            Console.WriteLine("MM           MM       SS       SS     AA        AA");
            Console.WriteLine("MM           MM       SS       SS     AA        AA");
            Console.WriteLine("MM           MM SSSSSSSS SSSSSSSS     AA        AA");
            Console.WriteLine("MM           MM SSSSSSSS SSSSSSSS     AA        AA");

            double phi = Math.Sqrt(5) + 1;
            double answer = phi / 2;
            //phi + 1 / 2;
            
            Console.WriteLine($"The value of phi is: { answer}");
        }
    }
}
