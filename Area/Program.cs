using System;

namespace Area
{
    class Program
    {
        static float pI = 3.14f;

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a radius: ");
            string userInput = Console.ReadLine();

            float radius;
            bool isANum = float.TryParse(userInput, out radius);
            double area = pI * radius * radius;

            if (isANum)
            {
                Console.WriteLine("The area of a circle with the radius {0} is : {1}", radius, area);
            }
            else
            {
                Console.WriteLine("(ERROR)  The number you enter is not valid");
            }

            

            
            Console.ReadKey();

        }
    }
}
