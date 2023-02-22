using System;

namespace Factorial
{
    class  Factorial
    {
        static void Main(string[] args)
        {
            int factorial = 1, number;

            Console.Write("Enter a number for factorial: ");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial is : " + factorial);
        }
    }
}