using System;

namespace Structs_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.Number number = new Class1.Number();

            number.Amount = 5;

            Console.WriteLine("Amount is: {0}", number.Amount);
            Console.ReadLine();
        }
    }
}
