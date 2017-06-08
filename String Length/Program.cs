using System;
using System.Linq;

namespace String_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var twenty = input.Length > 20 ? new string(input.Take(20).ToArray()) : input;

            Console.WriteLine(twenty.PadRight(20,'*'));
        }
    }
}
