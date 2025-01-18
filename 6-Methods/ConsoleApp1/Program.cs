using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console .WriteLine("Name Game");
            Console .Write("What's your first name?");
            string firstName = Console.ReadLine();

            Console .Write("What's your first name?");
            string lastName = Console.ReadLine();

            Console .Write("ln what city were you born?");
            string city = Console.ReadLine();

            DisplayResults(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
        }
        private static string ReverseString(string message)
        {
            chart[] messageArray = message. ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);

        }

        private static void DisplayResults(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write($"{reversedFirstName}, {reversedLastName} {reversedCity}");
        }

        private static void DisplayResults(string message)
        {
            Console.Write("Results: ");
            Console.Write($"{message}");
        }
    }
}