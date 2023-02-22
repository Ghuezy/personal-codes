using System;
using System.Numerics;

namespace Calcutor
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            int opt;

            Console.Write("Enter the number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition > 1: ");
            Console.WriteLine("Subtraction > 2");
            Console.WriteLine("Multiplation > 3");
            Console.WriteLine("Division > 4");
            Console.Write("Enter the operator : ");
            opt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opt)
            {

                case 1:
                    result = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " is : " + result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " is : " + result);
                    break;

                case 3:
                    result = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " is : " + result);
                    break;

                case 4:
                    result = num1 / num2;
                    Console.WriteLine(num1 + " / " + num2 + " is : " + result);
                    break;

                default:
                    Console.WriteLine("You entered a wrong operator");
                    break;

            }
            Console.ReadKey();
        }
    }
}
