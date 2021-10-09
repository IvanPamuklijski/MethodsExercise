using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(SearchCharVolwels(text));
            
        }

        private static int SearchCharVolwels(string text)
        {
            int vowelsCount = 0;
            foreach (char vowels in text)
            {
                if ("aeiou".Contains(vowels))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }

}

