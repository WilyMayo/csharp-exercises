using System;

namespace Rectangle_Dimensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Find the surface area of a rectangle");
            Console.WriteLine("--------------------------------------");
            float length;
            float width;
            float height;

            Console.WriteLine("_____________________________________");
            Console.WriteLine("Type the lenght of the rectangle : ");
            string first = Console.ReadLine();
            length = float.Parse(first);

            Console.WriteLine("Type the width of the rectangle : ");
            string secondInput = Console.ReadLine();
            width = float.Parse(secondInput);

            Console.WriteLine("Type the height of the rectangle : ");
            string thirdInput = Console.ReadLine();
            height = float.Parse(thirdInput);

            float surfaceArea = (length * width * height);

            Console.WriteLine("Calulating....\n");

            Console.WriteLine("Your rectangle has the surface area: {0} ", surfaceArea);

            Console.ReadKey();

        }
    }
}
