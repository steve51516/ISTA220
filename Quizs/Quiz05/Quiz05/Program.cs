using System;

namespace Quiz05
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragram = "The quick brown fox jumps over the lazy dog";

            string[] words = paragram.Split(' ');

            Array.Reverse(words);

            for (int i = 0; i < words.Length; i++)
                Console.WriteLine($"{i} {words[i]}");
        }
    }
}
