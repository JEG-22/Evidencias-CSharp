using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x;
            // int y;

            // x = 7;
            // y = x + 3;

            // Console.WriteLine(y);
            // Console.ReadLine();


            Console.WriteLine( "What is your name?" );
            Console.Write("First name:");
            string? myFirstName;
            myFirstName = Console.ReadLine();

            string? myLastName;
            Console.Write("Last Name:");
            myLastName = Console.ReadLine();
            
            Console.WriteLine($"Hello, {myFirstName} {myLastName}");
            Console.ReadLine();
        }
    }
}