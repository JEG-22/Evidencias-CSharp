using System;

namespace _9_DateTime;

class Program
{
    static void Main(string[] args)
    {
        DateTime myValue = DateTime.Now;
        // Console.WriteLine(myValue.ToString());
        // Console.WriteLine(myValue.ToShortDateString());
        // Console.WriteLine(myValue.ToShortTimeString());
        // Console.WriteLine(myValue.ToLongDateString());
        // Console.WriteLine(myValue.ToLongTimeString());

        // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
        // Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

        // Console.WriteLine(myValue.Month);

        // DateTime myBirthday = new DateTime(2005, 11, 22);
        // Console.WriteLine(myBirthday.ToLongDateString());

        DateTime myBirthday = DateTime.Parse("11/22/2005");
        TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

        Console.WriteLine(myAge.TotalDays);


    }
}
