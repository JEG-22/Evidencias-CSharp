namespace _10_SimpleClasses;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Make = "Oldsmobile";
        myCar.Model = "Cutlas Supreme" ;
        myCar.Year = 1986;
        myCar.Color ="Silver" ;

        Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color}");

        Console.WriteLine("{0:C}", myCar.DetermineMarketValue());
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set;}
    public int Year { get; set; }
    public string Color { get; set;}

    public decimal DetermineMarketValue()
    {
        decimal carValue;
        if(Year > 1990)
        {
            carValue = 2000;
        }
        else
        {
            carValue = 1000;
        }

        return carValue;
    }
}
