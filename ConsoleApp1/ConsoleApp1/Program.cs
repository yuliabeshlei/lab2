using System;

namespace ConsoleApp1
{
    class Program
    { 
private int a;

        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");

            var name1 = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);


		//yulia comment

//mariana coment

                


 
        }
    }
}
