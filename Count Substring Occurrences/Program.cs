using System;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var word = Console.ReadLine();

            var count = 0;

            for (int i = 0; i <= text.Length-word.Length; i++)
            {
                if (string.Compare(text.Substring(i, word.Length), word, true) == 0)
                {
                    count++;
                }
            }





            Console.WriteLine(count);
        }
    }
}
