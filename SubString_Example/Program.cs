// See https://aka.ms/new-console-template for more information
using SubString_Example;
using System.Text.RegularExpressions;
Substringg sub;
try
{
    Console.WriteLine("Enter input here");
    string input = Console.ReadLine();
    if(input != "")
    {
        Console.WriteLine("Enter first index to substring  input");
        string f = Console.ReadLine();
       if(Regex.IsMatch(f, "^[0-9]"))
        {
            Console.WriteLine("Enter last index to substring input");
            string l=Console.ReadLine();
            if (Regex.IsMatch(f, "^[0-9]"))
            {
                int first = Convert.ToInt32(f);
                int last = Convert.ToInt32(l);
                sub = new Substringg(input, first, last);

            }
        }
       else
        {
            Console.WriteLine("Invalid Input");
        }

    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}