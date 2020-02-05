using System;

namespace mad_lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Libby. A Console Madlib Game!");

            string color;
            Console.WriteLine("Enter a Color –");
            color = Console.ReadLine();

            string adjOne;
            Console.WriteLine("Enter a adjitive – ");
            adjOne = Console.ReadLine();

            string thing;
            Console.WriteLine("Enter a name something can go through – ");
            thing = Console.ReadLine();

            string nounOne;
            Console.WriteLine("Enter a noun – ");
            nounOne = Console.ReadLine();

            string verbOne;
            Console.WriteLine("Enter a verb – ");
            verbOne = Console.ReadLine();


            Console.WriteLine("Here's your MadLib...");
            Console.WriteLine($"The {color} cow was, {adjOne} through the, {thing}; {nounOne} while {verbOne}.");
        }
    }
}
