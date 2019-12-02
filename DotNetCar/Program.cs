using System;

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
            //bool exited = false;

            //while (!exited)
            //{
            //    Console.WriteLine("Do you like this cource so far? Please type yes or no.");
            //    Console.WriteLine("Type exit to exit the program.");
            //    string answer = Console.ReadLine();

            //    if (answer == "yes")
            //        Console.WriteLine("I'm glad to have you on my course!");
            //    else if (answer == "no")
            //        Console.WriteLine("Wrong answer!");
            //    else if (answer == "exit")
            //        exited = true;
            //    else
            //        Console.WriteLine("I don't know what you mean by that!");
            //}

            //Fifth example
            //bool exited = false;
            //ICar myCar = null;

            //while (!exited)
            //{
            //    Console.WriteLine("Please type either race or family for the type of car you want");
            //    Console.WriteLine("Type exit to quit the program");

            //    string input = Console.ReadLine();

            //    if (input == "race")
            //        myCar = new RaceCar();
            //    else if (input == "family")
            //        myCar = new FamilyCar();
            //    else if (input == "exit")
            //        exited = true;
            //    else
            //        continue;

            //    if (!exited)
            //    {
            //        Console.WriteLine("The type of the car is " + myCar.GetType());
            //        Console.WriteLine("The model of my car is " + myCar.Model);
            //    }
            //}


            //--------------Sixth Example

            double? firstNumber = null;
            double? secondNumber = null;
            double? answer = null;
            string calcOperator = null;

            while (true)
            {
                try
                {
                    Console.Write("Type exit to quit the program at any time. ");

                    if (firstNumber == null)
                    {
                        Console.WriteLine("Please type your first number.");

                        string consoleInput = Console.ReadLine();

                        if (consoleInput == "exit")
                            break;

                        firstNumber = double.Parse(consoleInput);

                    }
                    else if (calcOperator == null)
                    {
                        Console.WriteLine("Please type one of the following operators:");
                        Console.WriteLine("+, -, *, /");

                        string consoleInput = Console.ReadLine();

                        if (consoleInput == "exit")
                            break;

                        switch (consoleInput)
                        {
                            case "+":
                            case "-":
                            case "*":
                            case "/":
                                calcOperator = consoleInput;
                                break;
                            default:
                                throw new Exception("Operator not recognised");
                        }
                    }
                    else if (secondNumber == null)
                    {
                        Console.WriteLine("Please type your second number");

                        string consoleInput = Console.ReadLine();

                        if (consoleInput == "exit")
                            break;

                        secondNumber = double.Parse(consoleInput);

                        switch (calcOperator)
                        {
                            case "+":
                                answer = firstNumber + secondNumber;
                                break;
                            case "-":
                                answer = firstNumber - secondNumber;
                                break;
                            case "*":
                                answer = firstNumber * secondNumber;
                                break;
                            case "/":
                                answer = firstNumber / secondNumber;
                                break;
                        }

                        Console.WriteLine("The answer is " + answer);
                        Console.WriteLine("Press ESC to exit the program. Press any other key to continue.");

                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
