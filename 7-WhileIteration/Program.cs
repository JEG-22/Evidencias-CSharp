namespace _7_WhileIteration;

class Program
{
    static void Main(string[] args)
    {
        bool displayMenu = true;

        while (displayMenu)
        {
            displayMenu = MainMenu();
        }
    }
    private static bool MainMenu()
    {
        Console.Clear()
        Console.WriteLine("Choose an option: i");
        Console.WriteLine("1) Option 1");
        Console.WriteLine("2) Option 2");
        Console.WriteLine("3) Exit");

        string result = Console.ReadLine();
        if (result == "1")
        {
            PrintNumbers();
            return true;
        }
        else if (result == "2")
        {
            GuessingGame();
            return true;
        }
        else if (result == "3")
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private static void PrintNumbers()
    {
        Console.WriteLine("Print numbers!");
        Console.Write("Type a number: ");
        int result = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter < result + 1)
        {
            Console.Write(counter);
            Console. Write(" - ");
            counter++;
        }
        Console.ReadLine();
    }
    private static void GuessingGame()
    {
        Console.Clear();
        Console.WriteLine("Guessing game!");

        Random myRand = new Random();
        int randomNumber = myRand.Next(1,11);

        int guesses = 0;
        bool incorrect = true;

        do{
            Console.WriteLine("Guess number between 1 to 10: ");
            string result = Console. ReadLine();
            if (result == randomNumber.ToString())
                incorrect = false;
            else
                Console. WriteLine("Wrong!") ;
        }while (incorrect);
        Console.WriteLine("Correct!");

        Console.ReadLine();
    }
}
