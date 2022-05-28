using static System.Console;
using static System.Convert;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double d = 9.8;

            int a = ToInt32(d);

            WriteLine($"a = {a}");*/

            double[] ds = {9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            foreach (var item in ds)
            {
                WriteLine($"item = {item}, convert value = {ToInt32(item)}");
            }

            ReadKey();


        }
    }
}
