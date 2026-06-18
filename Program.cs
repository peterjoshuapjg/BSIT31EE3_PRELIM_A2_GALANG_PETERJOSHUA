
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter first number (or 'exit' to quit): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }
        }
    }
}