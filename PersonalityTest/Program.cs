using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string color;

            Console.WriteLine("you color");
            color = Console.ReadLine().ToLower();

            if (color == "red")
            {
                Console.WriteLine("romantic ");
            }
            if (color == "blue")
            {
                Console.WriteLine("reaibel ");
            }
            if (color == "yellow")
            {
                Console.WriteLine("cheerful ");
            }
            else
            {
                Console.WriteLine("unicorn ");
            }

        }
    }
}
