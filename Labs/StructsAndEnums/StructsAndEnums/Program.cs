#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Console.WriteLine("This is structs and enums");
            Month first = Month.January;
            Console.WriteLine(first);
            Console.WriteLine((int)first);
            first++;
            Console.WriteLine(first);
            Console.WriteLine((int)first);
            Month last = Month.December;
            Console.WriteLine(last);
            Console.WriteLine((int)last);
            last++;
            Console.WriteLine(last);
            Console.WriteLine((int)last);
            last++;
            Console.WriteLine(last);
            Console.WriteLine((int)last);
            Console.WriteLine((Month)7);

            Console.WriteLine("----------------------------------------------------------------");

            //Date defaultDate = new Date();
            //Console.WriteLine(defaultDate);
            //String johnny = defaultDate.ToString();
            //Console.WriteLine(johnny);

            Date weddingAnniversary = new Date(2019, Month.May, 1);
            Console.WriteLine(weddingAnniversary);
            Console.WriteLine((int)Month.May);
            Console.WriteLine((Month)4);
            Console.WriteLine("-------------------------------------------------------------------");
            Date weddingAnniversaryCopy = weddingAnniversary;
            Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");
            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");

        }

        static void Main()
        {

                doWork();
        }

    }
}
