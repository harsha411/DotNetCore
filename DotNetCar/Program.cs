﻿using System;

namespace DotNetCar
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------First Example
            //Car myCar = new Car();

            //Console.WriteLine("The make of my car is " + myCar.GetMake());
            //Console.WriteLine("The top speed before modification was " + myCar.GetTopSpeed());
            //myCar.AdjustTopSpeed(200);
            //Console.WriteLine("The top speed after modification is " + myCar.GetTopSpeed());
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            //------------------------Second Example
            //Console.WriteLine("Do you like this course so far? Please type yes or no.");
            //string answer = Console.ReadLine();

            //if (answer == "yes")
            //    Console.WriteLine("I'm glad to have you on my course!");
            //else if (answer == "no")
            //    Console.WriteLine("Wrong answer!");
            //else
            //    Console.WriteLine("I don't know what you mean by that!");

            //Console.ReadKey();

            //------------------------Third Example
            //int counter = 10;

            //while (counter > 0)
            //{
            //    Console.WriteLine("The current counter value is " + counter);
            //    counter--;
            //}

            //Console.ReadKey();

            //------------------------Fourth Example
            bool exited = false;

            while (!exited)
            {
                Console.WriteLine("Do you like this cource so far? Please type yes or no.");
                Console.WriteLine("Type exit to exit the program.");
                string answer = Console.ReadLine();

                if (answer == "yes")
                    Console.WriteLine("I'm glad to have you on my course!");
                else if (answer == "no")
                    Console.WriteLine("Wrong answer!");
                else if (answer == "exit")
                    exited = true;
                else
                    Console.WriteLine("I don't know what you mean by that!");
            }
        }
    }
}