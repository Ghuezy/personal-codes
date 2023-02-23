using System;
using ZarOyunu;

namespace dice
{
    class DiceGame
    {
        static void Main(string[] args)
        {
            Console.Write("Enter max value: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            Dice dice1 = new Dice(maxValue);
            Dice dice2 = new Dice(maxValue);

            int dice_1 = dice1.throwDice();
            int dice_2 = dice2.throwDice();

            Console.WriteLine("Dice 1 : " + dice1.throwDice());
            Console.WriteLine("Dice 2 : " + dice2.throwDice());
            Console.WriteLine();

            if (dice_1 > dice_2)
            {
                Console.WriteLine("Dice 1 is bigger than dice 2.");
            }
            else if (dice_1 < dice_2)
            {
                Console.WriteLine("Dice 2 is bigger than dice 1.");
            }
            else
            {
                Console.WriteLine("Dices are equal.");
            }


        }
    }
}