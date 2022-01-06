using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();
            int num = int.Parse(entry);
            //if (num < 0)
            //{
            //    num = 0;
            //}

            Console.WriteLine(num < 0 ? 0 : num);

                                     // if statement     else statement
            Console.WriteLine(num < 0 ? "Less than zero" : "Not less than zero");
        }
    }
}
