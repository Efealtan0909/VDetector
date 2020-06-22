using System;

namespace VDedector
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Press A Character That Is Not V");
            string Key = Convert.ToString(Console.ReadKey())    ;
            if(Key == "V" || Key == "v")
            {
                Console.WriteLine("You Are Dumb");
            } else
            {
                Console.WriteLine("Thx For Understanding This Rule");
            }
        }
    }
}
