using static System.Console;

namespace SelectConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = 3;
            int j = 3;

            if (o is int i)
            {
                WriteLine($"i * j = {i * j}");
            }
            else
            {
                WriteLine("o is not int so it cannot multiply");
            }

            ReadKey();
        }
    }
}
