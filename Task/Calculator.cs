using System;

namespace Task01
{
    class Calculator
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;


                Console.WriteLine("Calculator Program");

                Console.Write("Enter number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number: ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter a Operation");
                Console.WriteLine("\t + : Addition");
                Console.WriteLine("\t - : Substraction");
                Console.WriteLine("\t * : Multiplication");
                Console.WriteLine("\t / : Division");

                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;

                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;

                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;

                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            }

            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }

}
