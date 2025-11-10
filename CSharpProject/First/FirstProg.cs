using System;

namespace First
{
    class FirstProg
    {
        static void Main(string[] args)
        {
            PrintNumbers();
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}