// A simple reply your name
using System;
namespace HelloWorld
{
    class Hello 
    {
        static void Main() 
        {

            // Keep the console window open in debug mode.
            Console.Write("Please Enter Your Name and Press Enter: ");
            String name = Console.ReadLine();
            Console.WriteLine("Your Name is " + name);
        }
    }
}
