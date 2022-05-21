using static System.Console;

namespace Operations
{
    class Program
    {
        public static bool Do()
        {
            WriteLine("Do");
            return true;
        }
        static void Main(string[] args)
        {
            int e = 11, f = 3;
            double d = 11.0;

            WriteLine($"e = {e}, f = {f}, d = {d:N1}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");
            WriteLine($"d / f = {d / f}");
            WriteLine($"d % f = {d % f}");

            int p = 6;
            p += f;
            WriteLine($"p = {p}");

            bool a = false, b = false;

            WriteLine($"a && b = {a && b}");
            WriteLine($"a || b = {a || b}");
            WriteLine($"a ^ b = {a ^ b}");

            WriteLine($"a && b = {a && Do()}");
            WriteLine($"a & b = {a & Do()}");
            WriteLine($"a || b = {a || Do()}");
            WriteLine($"a | b = {a | Do()}");
            WriteLine($"a ^ b = {a ^ b}");

            ReadKey();
        }
    }
}
