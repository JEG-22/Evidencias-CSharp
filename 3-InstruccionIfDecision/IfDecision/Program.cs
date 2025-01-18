using System;

namespace IfDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Bob's Big Giveaway");
            // Console.Write("Choose a door: 1, 2 or 3:");
            // string? userValue = Console.ReadLine();
            // string message  ="";
            // if (userValue == "1")
            //     message = "You won a new car!";
            // else if (userValue == "2")
            //     message = "You won a new boat!";
            // else if (userValue == "1")
            //     message = "You won a new cat!";
            // else{
            //     message = "Sorry we didn't understand";
            //     message += ", You Lose";
            // }

            // Console.WriteLine(message) ;
            // Console.ReadLine();


            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1 or 2:");
            string? userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "stramd of lint";

            Console.Write($"You Won a {message}.");
            Console.ReadLine();
        }
    }
}