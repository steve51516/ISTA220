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
            Console.WriteLine($"This is the average of Array A:\n {avg}");
            Console.WriteLine("============================================");

            Console.WriteLine("This is Array B printed normally: ");
            foreach (var num in arrayB)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("This is Array B printed backwards: ");
            int[] backwardsB = sums.Reverse(arrayB);

            for (int i = 0; i < backwardsB.Length; i++)
            {
                Console.Write(backwardsB[i] + " ");
            }
            Console.WriteLine("\n============================================");
            Console.WriteLine("This is Array A printed normally: ");
            foreach (var num in arrayA)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("This is Array A printed backwards: ");
            int[] backwardsA = sums.Reverse(arrayA);

            for (int i = 0; i < backwardsA.Length; i++)
            {
                Console.Write(backwardsA[i] + " ");
            }
            Console.WriteLine("\n============================================");
            Console.WriteLine("This is Array C printed normally: ");
            foreach (var num in arrayC)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("This is Array C printed backwards: ");
            int[] backwardsC = sums.Reverse(arrayC);

            for (int i = 0; i < backwardsC.Length; i++)
            {
                Console.Write(backwardsC[i] + " ");
            }
            Console.WriteLine("\n============================================");

            Console.WriteLine("ArrayA in normal order: ");
            foreach (var num in arrayA)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n------------------------------");

            sums.Rotate("left", 2, arrayA);
            Console.WriteLine();

            Console.WriteLine("ArrayB in normal order: ");
            foreach (var num in arrayB)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n------------------------------");

            sums.Rotate("right", 2, arrayB);
            Console.WriteLine();

            Console.WriteLine("ArrayC in normal order: ");
            foreach (var num in arrayC)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n------------------------------");

            sums.Rotate("left", 4, arrayC);
            Console.WriteLine();

            foreach (var num in arrayC)
            {
                Console.Write(num + " ");
            }

            sums.BubbleSort(arrayC);

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
            for (int i = array.Length - 1, a = 0; i >= 0 ; i--, a++)
            {
                backwards[a] = array[i];
            }

            return backwards;
        }
        public void Rotate(string direction, int places, int[] array)
        {
            Console.WriteLine($"Moving {places} to the {direction}");


            if (direction == "left")
            {
                int[] tempCopy = new int[array.Length];
                //int j = places;
                for (int i = 0, j = places; i <= array.Length - 1; i++)
                {

                    tempCopy[i] = array[j];
                    if (j >= array.Length - 1)
                        j = 0;
                    else
                        j++;

                }
                foreach (var num in tempCopy)
                {
                     Console.Write(num + " ");
                }
                
            }
            if (direction == "right")
            {
                int[] tempCopy = new int[array.Length];
                //int j = (array.Length - 1) - places;
                for (int i = array.Length - 1, j = (array.Length - 1) - places; i >= 0; i--)
                {

                    tempCopy[i] = array[j];
                    if (j == 0)
                        j = array.Length - 1;
                    else
                        j--;

                }
                foreach (var num in tempCopy)
                {
                    Console.Write(num + " ");
                }
            }

        }
        public void BubbleSort(int[] array)
        {
            int temp;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
            Console.WriteLine("\nArray after sorting: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine("\n");
        }
    }
}
