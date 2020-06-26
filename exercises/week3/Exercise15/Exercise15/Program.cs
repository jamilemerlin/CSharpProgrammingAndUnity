using System;

namespace Exercise15
{
    /// <summary>
    /// Exercise 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********************");
            Console.WriteLine("\n1 - New Game\n");
            Console.WriteLine("\n2 - Load Game\n");
            Console.WriteLine("\n3 - Options\n");
            Console.WriteLine("\n4 - Quit\n");
            Console.WriteLine("*********************");
            Console.WriteLine("Your Choice: ");
            int answer = int.Parse(Console.ReadLine());

            //Create and use a menu using an if statement
            if (answer == 1)
            {
                Console.WriteLine("Loading New Game...");
            }
            else if (answer == 2)
            {
                Console.WriteLine("Loading Game...");
            }
            else if (answer == 3)
            {
                Console.WriteLine("\nOptions\n");
                Console.WriteLine("we are building this solution");
                Console.WriteLine();
            }
            else if (answer == 4)
            {
                Console.WriteLine("\nSee you soon! Bye!\n");
            }
            else
            {
                Console.WriteLine("This option don't exist!");
            }


            //Create and use a menu using a switch statement
            switch (answer)
            {
                case 1:
                    Console.WriteLine("Loading New Game...");
                    break;
                case 2:
                    Console.WriteLine("Loading Game...");
                    break;
                case 3:
                    Console.WriteLine("\nOptions\n");
                    Console.WriteLine("we are building this solution");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("\nSee you soon! Bye!\n");
                    break;
                default:
                    Console.WriteLine("This option don't exist!");
                    break;
            }

        }
    }
}
