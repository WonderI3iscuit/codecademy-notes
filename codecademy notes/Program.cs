using System;
using System;

namespace GettingInput
{
    class Program
    {
        static void Main()
        {
            //this jargen asks the user how old they are
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");
        }
    }
}
