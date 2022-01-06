using System;

namespace FillerConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();
            Console.WriteLine("-------------");
            Console.WriteLine(entry.PadLeft(15));
            Console.WriteLine(entry.Replace('b','*'));
        }
    }
}
