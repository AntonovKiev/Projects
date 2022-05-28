using System;
using static System.Console;

namespace Pars
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse("28");
            WriteLine($"My age = {age}");

            DateTime date = DateTime.Parse("5 April 1994");
            WriteLine($"birthday = {date:d}");

            int tr = int.Parse("abc");

            ReadKey();
        }
    }
}
