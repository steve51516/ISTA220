using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            double start = 0;
            double end = 10;
            double sum = 0;

            Console.Write($"Enter 10 Numbers: ");

            sum = get_sum(start, end, sum);
            Console.WriteLine($"The sum is {sum}");
            double average = Avg(sum, end);
            char grade = Grade(average);
            Console.WriteLine($"Letter Grade is: {grade}");
            Console.WriteLine($"The average is {average}");
            
            Console.WriteLine("Enter the number of scores you want to calculate: ");
            double end2 = double.Parse(Console.ReadLine());
            start = 0;
            sum = 0;
            sum = get_sum(start, end2, sum);
            Console.WriteLine($"The sum is {sum}");
            double average2 = Avg(sum, end2);
            char grade2 = Grade(average2);
            Console.WriteLine($"Letter Grade is: {grade2}");
            Console.WriteLine($"The average is {average2}");

            Console.WriteLine("Enter the numbers you want generated into scores, enter \"-1\" when you are finished.");
            double end3 = double.Parse(Console.ReadLine());
            sum = 0;
            sum = get_sum(start, end3, sum);
            Console.WriteLine($"The sum is {sum}");
            double average3 = Avg(sum, end3);
            char grade3 = Grade(average3);
            Console.WriteLine($"The average is {average3}");
            Console.WriteLine($"Letter Grade is: {grade3}");

        }

        private static double get_sum(double start, double end, double sum)
        {
            if (start == end || start == -1)
                return sum;
            else
                Console.Write("Enter a number: ");
                double input = double.Parse(Console.ReadLine());
            if (input == -1)
            {
                start = end;
                return sum;
            } 
                sum = sum + input;
                return get_sum(++start, end, sum);
        }
        private static double Avg(double x, double y)
        {
            double average = x / y;
            return average;
        }
        private static char Grade(double y)
        {
            if (y < 60)
            {
                char grade = 'F';
                return grade;
            }
            else if (y >= 70 && y < 80)
            {
                char grade = 'C';
                return grade;
            }
            else if (y >= 80 && y < 90)
            {
                char grade = 'B';
                return grade;
            }
            else if (y >=90 && y <= 100)
            {
                char grade = 'A';
                return grade;
            }
            else
            {
                char grade = 'U';
                return grade;
            }

        }
    }
}
