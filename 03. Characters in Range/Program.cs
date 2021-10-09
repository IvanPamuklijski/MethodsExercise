using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            CharInRange(one, two);
        }
        static void CharInRange(char one, char two)
        {
            int startChar = Math.Min(one, two);
            int endChar = Math.Max(one, two);
            for (int i = startChar +1 ; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
