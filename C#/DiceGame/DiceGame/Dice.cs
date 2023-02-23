using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class Dice
    {

        int maxValue;

        Random random = new Random();

        public Dice(int maxValue)
        {
            this.maxValue = maxValue;
        }

        public int throwDice()
        {
            return random.Next(1, maxValue + 1);
        }
    }
}
