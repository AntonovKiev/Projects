using static System.Console;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("How old are you?");
            string input = ReadLine();

            int age;

            if (int.TryParse(input, out age))
            {
                WriteLine($"You are {age} year old");
            }
            else
            {
                WriteLine("I couldn't parse input");
            }

            ReadKey();
        }
    }
}
