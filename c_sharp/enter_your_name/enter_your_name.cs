// A simple reply your name
using System;
using System.Text.RegularExpressions;
namespace HelloWorld
{
    class Hello 
    {	

	static bool validateName(String s)
	{
	    /*
            * https://xkcd.com/327/ 
            */
            MatchCollection matches = Regex.Matches(s, "[;+=<>\\/]");
	    foreach (Match match in matches) return false; return true;
	}
        static void Main() 
        {

            // Keep the console window open in debug mode.
            Console.Write("Please Enter Your Name and Press Enter: ");
            String name = Console.ReadLine();
           /*
            * Validating names is not simple https://www.kalzumeus.com/2010/06/17/falsehoods-programmers-believe-about-names/
            */
            if( validateName(name ))
               Console.WriteLine("Your Name is " + name);
            else
               Console.WriteLine("Please provide legal evidence for your name " + name);
        }
    }
}
