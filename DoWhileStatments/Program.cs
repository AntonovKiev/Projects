using static System.Console;
using System;

namespace DoWhileStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = String.Empty;

            do
            {
                Write("Enter password: ");
                password = ReadLine();
            } while (password != "password");

            WriteLine("Correct!");

            ReadKey();
        }
    }
}
