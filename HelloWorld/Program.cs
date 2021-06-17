using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello friend what is your name?: ");
            string input  = Console.ReadLine();
            Console.WriteLine("Wow, that is a great name. It's nice to meet you " + input);


            Console.ReadKey();
        }
    }
}
