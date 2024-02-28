using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Work1();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n========================================\n");
            Console.ForegroundColor = ConsoleColor.White;

            Work2();
        }

        public static void Work1()
        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Work2()
        {
            int a = 50;
            int b = 150;
            int c = 5;

            for (int i = a; i <= b; i++)
            {
                if (i % c == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
