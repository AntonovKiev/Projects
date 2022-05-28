using static System.Console;
using System;

namespace Mat
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ds = { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach (var item in ds)
            {
                WriteLine($"item = {item}, mathRoundValue = {Math.Round(item, 0, MidpointRounding.AwayFromZero)}");
            }

            ReadKey();
        }
    }
}
