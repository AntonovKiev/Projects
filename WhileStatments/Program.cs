using static System.Console;

namespace WhileStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                ++x;
            }

            WriteLine(x);

            ReadKey();
        }
    }
}
