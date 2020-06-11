using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Exercise
    {
        // conversions using float, i can use double too, because the double data types use more bytes than float.
        static void Main()
        {
            float temperatureOne = 0;
            float celsiusOne = ((temperatureOne - 32) / 9) * 5;
            Console.WriteLine(celsiusOne + " Celsius");

            float fahrenheitOne = ((celsiusOne * 9) / 5) + 32;
            Console.WriteLine(fahrenheitOne + " Fahrenheit");
            Console.WriteLine();


            float temperatureTwo = 32;
            float celsiusTwo = ((temperatureTwo - 32) / 9) * 5;
            Console.WriteLine(celsiusTwo + " Celsius");

            float fahrenheitTwo = ((celsiusTwo * 9) / 5) + 32;
            Console.WriteLine(fahrenheitTwo + " Fahrenheit");
            Console.WriteLine();


            float temperatureThree = 212;
            float celsiusThree = ((temperatureThree - 32) / 9) * 5;
            Console.WriteLine(celsiusThree + " Celsius");

            float fahrenheitThree = ((celsiusThree * 9) / 5) + 32;
            Console.WriteLine(fahrenheitThree + " Fahrenheit");
            Console.WriteLine();
        }
        // exercise 7: Temperature Conversions
        // class Exercise
        // {
        //     // conversions using integer
        //     static void Main()
        //     {
        //         int temperatureOne = 0;
        //         int celsiusOne = ((temperatureOne - 32) / 9) * 5;
        //         Console.WriteLine(celsiusOne + " Celsius");

        //         int fahrenheitOne = ((celsiusOne * 9) / 5) + 32;
        //         Console.WriteLine(fahrenheitOne + " Fahrenheit");
        //         Console.WriteLine();


        //         int temperatureTwo = 32;
        //         int celsiusTwo = ((temperatureTwo - 32) / 9) * 5;
        //         Console.WriteLine(celsiusTwo + " Celsius");

        //         int fahrenheitTwo = ((celsiusTwo * 9) / 5) + 32;
        //         Console.WriteLine(fahrenheitTwo + " Fahrenheit");
        //         Console.WriteLine();


        //         int temperatureThree = 212;
        //         int celsiusThree = ((temperatureThree - 32) / 9) * 5;
        //         Console.WriteLine(celsiusThree + " Celsius");

        //         int fahrenheitThree = ((celsiusThree * 9) / 5) + 32;
        //         Console.WriteLine(fahrenheitThree + " Fahrenheit");
        //         Console.WriteLine();
        //     }

    }




    // exercise 6: trigonometry whit floats

    // class Exercise
    // {
    //     static void Main()
    //     {
    //         Console.Write("What the angle in degress? -> ");
    //         float angle = float.Parse(Console.ReadLine());

    //         angle *= (float)Math.PI / 180;

    //         Console.WriteLine("Cosine: " + Math.Cos(angle));
    //         Console.WriteLine("Sino: " + Math.Sin(angle));

    //         Console.WriteLine();

    //     }

    // }


    // Exercise 5: calc the percent
    // void Start()
    // {
    //     const int maxScore = 100;
    //     int score = 30;
    //     float percent = ((float)score / maxScore) * 100;
    //     print("The percent is: " + percent + "%");
    // }
}
