using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WindowHeight = Console.BufferHeight = 50;
        Console.WindowWidth = Console.BufferWidth = 200;

        Random rand = new Random();

        while (true)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(i, rand.Next(Console.WindowHeight));
                Console.Write((char)('!' + rand.Next(94)));
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(i, rand.Next(Console.WindowHeight));
                Console.Write((char)('!' + rand.Next(94)));
            }

            Thread.Sleep(100);
        }
    }
}
