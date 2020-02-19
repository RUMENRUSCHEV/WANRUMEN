using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int r = 0;
            Console.WriteLine("Type some number:");
            input = Console.ReadLine();
            for (int i = 0; i <= int.Parse(input); i++)
            {
                r = r + i;
            }
            Console.WriteLine(r);
        }   
    }
}
