using System;
using System.Linq;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var revesed = new string (input.Reverse().ToArray());

            Console.WriteLine(revesed);

        }
    }
}
