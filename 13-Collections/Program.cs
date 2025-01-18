using System.Collections;

namespace _13_Collections;

class Program
{
    static void Main(string[] args)
    {
        Car carl = new Car()
        carl .Make = "Oldsmobile";
        carl.Model = "Cutlas Supreme";
        car1.VIN = "A1";
        
        Car car2 = new car()
        car2 .Make = "Geo";
        car2.Model = "Prism" ;
        car1.VIN = "B1";

        Book bl = new Book();
        bl.Author = "Robert Tabor";
        bl. Title = "Microsoft .NET XML web services";
        bl.ISBN = "0-000-00000-0";


        // ArrayList myArraList = new ArrayList();
        // myArraList.Add(car1);
        // myArraList.Add(car2);
        // myArraList.Add(b1)

        // foreach (Car car in myArraList)
        // {
        //     Console.WriteLine(car.Make);
        // }

        List<Car> myList = new List<Car>();
        myList.Add(car1);
        myList.Add(car2);
         foreach (Car car in myList)
        {
            Console.WriteLine(car.Make);
        }

        Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

        myDictionary.Add(car1.VIN, car1);
        myDictionary.Add(car2.VIN, car2);

    }
}

class Car
{
    public string VIN {get;set;}
    public string Make {get; set;}
    public string Model {get;set;}
}

class Book
{
    public string Title {get; set;}
    public string Author {get;set}
    public string ISBN {get;set;}
}
