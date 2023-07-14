using System;

namespace Task
{
class GuessNumber
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess the Lucky Number \nCondition: Between 1 to 10");
            Console.WriteLine("Let's Try Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 7)
            {
                Console.WriteLine("Correct! Have Good Day!");
            }
            else if (num == 6)
            {
                Console.WriteLine("Too Close Little Bit");
            }
            else if (num ==  5)
            {
                Console.WriteLine("Little Bit Close");
            }
            else if (num ==  4)
            {
                Console.WriteLine("Little Bit Close");
            }
            else if (num ==  3)
            {
                Console.WriteLine("You r Left behind the 3 numbers");
            }
            else if (num ==  2)
            {
                Console.WriteLine("You are going too Reverse");
            }
            else if (num ==  8)
            {
                Console.WriteLine("Little Far");
            }
            else if (num ==  9)
            {
                Console.WriteLine("Far try next");
            }
            else if (num ==  10)
            {
                Console.WriteLine("Nope");
            }
            else
            {
                Console.WriteLine("Better Chance See You Later!");
            }
            Console.ReadKey();
        }
    }

}
