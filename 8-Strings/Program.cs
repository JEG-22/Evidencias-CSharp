using System;
using System.Text;

namespace _8_Strings;

class Program
{
    static void Main(string[] args)
    {
        //string myString = "My \ "so-called\" life" ;
        // string myString = "What if I need a\nnew line";
        // Console. WriteLine(myString);
        // Console.ReadLine();

        // string myString = @"Go to your c: \ drive" ;
        // string myString = "Go to your c: \\ drive" ;
        // string myString = String. Format("{l} = {0}", "First", "Second") 
        // string myString = string.Format("{0:C}", 123.45);
        // string myString = string.Format("{0:N}", 1231234214);
        // string myString = string.Format("{0:P}", .45);
        // string myString = string.Format("{0:(###) ###-####}", 1234512230);

        // string mystring = " That sumer we took threes across the board  ";
        // mystring = mystring.Substring(6,14);
        // mystring = mystring.ToUpper();
        // mystring = mystring.Replace(" ". "--");
        // mystring = mystring.Remove(6,14);
        // mystring = mystring.Trim();

        // for (int i = 0; i < 100; i++)
        // {
        //     mystring += "--" + i.ToString();
        // }

        StringBuilder mystring = new StringBuilder();
        
        for (int i = 0; i < 100; i++)
        {
            mystring.Append("--");
            mystring.Append(i.ToString());
        }


        Console.WriteLine(mystring);
    }
}
