using System;

namespace Miles_Per_Gallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================");
            Console.WriteLine("--0--Vehicle--0--");
            Console.WriteLine("==================");

            int miles;
            float gallon;

            Console.WriteLine("Enter miles driven : ");
            miles = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter how amount of gallon: ");
            gallon = float.Parse(Console.ReadLine());

            float milesAGallon = (miles / gallon);
            Console.WriteLine("==================");
            Console.WriteLine("Your vehicle's miles-per-gallon is {0}", milesAGallon);

        }
    }
}
