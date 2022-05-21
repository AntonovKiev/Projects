using static System.Console;

namespace TypeTable
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("{0, -10} {1, 5} {2, -20} {3, -20}", "Type", "Byte(s) of memory", "Min".PadLeft(19), "Max".PadLeft(19));
            WriteLine($"sbyte:-10 {sizeof(sbyte), 5} {sbyte.MinValue, -20} {sbyte.MaxValue, -20}");
        //todo: доразобраться с форматированием, example page 119 price
            ReadKey();
        }
    }
}
