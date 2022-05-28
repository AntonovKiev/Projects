using System;
using static System.Console;

namespace ToStr
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            WriteLine(a.ToString());

            bool b = true;
            WriteLine(b.ToString());

            DateTime d = DateTime.Now;
            WriteLine(d.ToString());

            object me = new object();
            WriteLine(me.ToString());

            ReadKey();
        }
    }
}
