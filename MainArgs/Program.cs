using static System.Console;

namespace MainArgs
{
    class Program
    {
        string[] args = new string[] { "10", "12"};

        static void Main(string[] args)
        {
            WriteLine($"Theare arg length {args.Length}");
            ReadKey();
        }
    }
}
