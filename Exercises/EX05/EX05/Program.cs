using System;

namespace EX05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 0, 2, 4, 6, 8, 10 };

            int[] arrayB = { 1, 3, 5, 7, 9 };

            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Sums sums  = new Sums();

            double avg = sums.GetAvg(arrayA);
            Console.WriteLine($"This is the average of Array A: {avg}");
            Console.WriteLine("============================================");


            Console.WriteLine("This is Array B printed backwards: ");
            int[] backwardsB = sums.Reverse(arrayB);

            for (int i = 0; i < backwardsB.Length; i++)
            {
                Console.WriteLine(backwardsB[i]);
            }
            Console.WriteLine("============================================");
            Console.WriteLine("This is Array A printed backwards: ");
            int[] backwardsA = sums.Reverse(arrayA);

            for (int i = 0; i < backwardsA.Length; i++)
            {
                Console.WriteLine(backwardsA[i]);
            }
            Console.WriteLine("============================================");
            Console.WriteLine("This is Array C printed backwards: ");
            int[] backwardsC = sums.Reverse(arrayC);

            for (int i = 0; i < backwardsC.Length; i++)
            {
                Console.WriteLine(backwardsC[i]);
            }
            Console.WriteLine("============================================");


        }
    }
    class Sums
    {


        public double GetAvg(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avg = sum / array.Length;
            return avg;
        }

        public int[] Reverse(int[] array)
        {
            int[] backwards = new int[array.Length];
            int a = 0;
            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                backwards[a] = array[i];
                a++;
            }

            return backwards;
        }
    }
}
