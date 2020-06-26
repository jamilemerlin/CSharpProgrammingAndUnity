using System;

namespace IfStatements
{
    /// <summary>
    /// If Statements Lecture code
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates various forms of if statemented
        /// </summary>
        /// <param name="args">comand-line arguments</param>
        public static void Main(string[] args)
        {
            // prompt for and get user input
            Console.Write("Pick up the shine thing? 1 for yes, 2 for no: ");
            int answer = int.Parse(Console.ReadLine());

            // print appropriate message

            switch (answer)
            {
                case 1:
                    Console.WriteLine("You have the shine thing");
                    break;
                case 2:
                    Console.WriteLine("You don't have the shine thing");
                    break;
                default:
                    Console.WriteLine("Invalid number!");
                    break;

            }

            /*if (answer == 1)
            {
                Console.WriteLine("You have the shine thing");
            }
            else if (answer == 2)
            {
                Console.WriteLine("You don't have the shine thing");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }*/
            Console.WriteLine();
        }
    }
}
