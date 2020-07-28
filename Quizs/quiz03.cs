using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                try
                {
                    Console.Write("Enter a number to find it's reciprocal: ");
                    int input = int.Parse(Console.ReadLine());
                    double result = (1.0 / input);

                    if (input == 0)
                    {
                        throw new System.DivideByZeroException("Cannot devide by zero");
                    }
                    if (input < 0)
                    {
                        throw new System.Exception("Negative number detected. Enter positive number.");
                    }
                    Console.WriteLine(result);
                    again = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex2)
                {
                    Console.WriteLine(ex2.Message);
                }
                catch (Exception ex3)
                {
                    Console.WriteLine(ex3.Message);
                }

            }
        }
    }
}
