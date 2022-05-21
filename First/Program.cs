using System;
using static System.Console;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Press any key: ");
            ConsoleKeyInfo key = ReadKey();

            WriteLine();

            WriteLine($"key: {key.Key} char: {key.KeyChar} modifires: {key.Modifiers}");

            ReadKey();
        }
    }
}
