using System;

namespace ProgrammingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, the application will calculate the distance between two points and the angle a game character.");
            Console.WriteLine();

            // data entry for distance calculation

            Console.Write("Enter first x value: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("Enter first y value: ");
            float point1Y = float.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter second x value: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Enter second y value: ");
            float point2Y = float.Parse(Console.ReadLine());
            Console.WriteLine();

            // calculating the distance between one point and another

            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // calculating the distance for hypotenuse

            double hypotenuse = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            Console.WriteLine("The distance between the first point to second point is: " + hypotenuse);

            // calculating the angle

            double radians = Math.Atan2(deltaY, deltaX);
            double angle = radians * (180 / Math.PI);
            Console.WriteLine("The angle between the first point to second point is: " + angle);

        }
    }
}
