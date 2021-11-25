using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu 'h', 'o' ja 'l' tähte on lauses "Hello World!"

            string HelloW = $"Hello World!".ToLower();
            Console.WriteLine(HelloW);
            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < HelloW.Length; i++)
            {
                if (HelloW[i] == 'h')
                {
                    hCounter++;
                }

                if (HelloW[i] == 'o')
                {
                    oCounter++;
                }

                if (HelloW[i] == 'l')
                {
                    lCounter++;
                }

            }

                if (hCounter != 1)
                {
                    Console.WriteLine($"Lauses Hello World! on {hCounter} 'h' tähte.");
                }
                else
                {
                    Console.WriteLine($"Lauses Hello World! on {hCounter} 'h' täht.");
                }

            if (oCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World! on {oCounter} 'o' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World! on {oCounter} 'o' täht.");
            }

            if (lCounter != 1)
            {
                Console.WriteLine($"Lauses Hello World! on {lCounter} 'l' tähte.");
            }
            else
            {
                Console.WriteLine($"Lauses Hello World! on {lCounter} 'l' täht.");
            }

            Console.WriteLine($"Kena päeva!");
        }
    }
}
