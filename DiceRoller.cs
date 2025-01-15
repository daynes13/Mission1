using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    internal class DiceRoller
    {
        public int[] RollDice(int rolls)
        {
            Random random = new Random();
            int[] rollResults = new int[13]; // This array stores results for sums 2-12 (array of size 13, 0 and 1 unused)

            for (int i = 0; i < rolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7); // Rolls die
                int sum = die1 + die2; //calculate sum of rolls
                rollResults[sum]++; //increment the count for this sum
            }

            return rollResults;

        }
    }
}
