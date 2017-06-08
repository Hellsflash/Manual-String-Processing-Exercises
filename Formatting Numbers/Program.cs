using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().ToArray();

            var a = int.Parse(input[0]);
            var b = float.Parse(input[1]);
            var c = float.Parse(input[2]);

            string aHex = a.ToString("X");
            string aBinary = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("|{0,-10}|{1,-10}|{2,10:0.00}|{3,-10:0.000}|", aHex, aBinary, b, c);



        }
    }
}
