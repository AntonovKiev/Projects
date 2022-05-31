using static System.Console;

namespace HandlingExeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("How old are you?");
            string input = ReadLine();

            try
            {
                int age = int.Parse(input);
                WriteLine($"You age is {age}");
            }
            catch(System.FormatException)
            {
                WriteLine("Your age you entered not in correct format!");
            }
            catch(System.Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }

            WriteLine("After parsing!");

            ReadKey();
        }
    }
}
