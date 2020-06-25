using System;

namespace VDedector
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type A Thing That Doesnt Contain V");
            string Typed_Word = Console.ReadLine();
            int start = 0;
            int length = Typed_Word.Length;
            string h = Typed_Word.Substring(start, length);
            if(h.Contains("V") == true || h.Contains("v") == true)
            {
                Console.WriteLine("You Are Dumb");
            } else
            {
                Console.WriteLine("Thx For Understanding This Rule");
            }
            Console.ReadKey();
        }
    }
}
