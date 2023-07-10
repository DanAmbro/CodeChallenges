using System;

namespace Multiples3sAnd5s
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello there, are you looking for the sum of all the multiples of 3 and 5?");
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("You're in Luck! The answer is :" + sum);
        } 
    }
}