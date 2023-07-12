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
            else if (num > 7)
            {
                Console.WriteLine("Too Far");
            }
            else if (num < 7)
            {
                Console.WriteLine("Too Close");
            }
            else
            {
                Console.WriteLine("Better Chance See You Later!");
            }
            Console.ReadKey();
        }
    }

}
