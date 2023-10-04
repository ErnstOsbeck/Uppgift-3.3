using System;

namespace uppgift_3._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int svar = int.Parse(Console.ReadLine());
            int pris = (svar * 80);
            if (pris >= 950)
            {
                Console.WriteLine("Det kommer kosta 950 kronor att hyra bilen");
            }
            else
            {
                Console.WriteLine("Det kommer kosta " + pris + " kronor att hyra bilen");
            }
            Console.Read();
        }
    }
}
