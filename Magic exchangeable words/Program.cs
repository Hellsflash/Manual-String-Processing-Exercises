using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split();
            List<char> firstWord = new List<char>(inputArray[0]);
            List<char> secondWord = new List<char>(inputArray[1]);
            Console.WriteLine((firstWord.Count == secondWord.Count) ? "true" : "false");
        }
    }
}
