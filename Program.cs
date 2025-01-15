
/* Write a .NET console application using C# that simulates the rolling of two 6-sided dice (NOTE: NOT a one 12-sided die.) Use an array to keep track of the number of times that each combination is thrown. In other words, keep track of how many times the combination of the two simulated dice is 2, how many times the combination is 3, and so on, all the way up through 12. Allow the user to choose how many times the “dice” will be thrown. Then, once you have that number of rolls, pass that number to a second class that has a method that simulates the roll of the dice for the number of times that the user specified.  Store the results in an array. The method in the second class should return that array containing the roll results to the first class.  In the first class, use that array to print a histogram (using the * character) that shows the total percentage each number was rolled.  Each * will represent 1% of the total rolls. 
 */
namespace CSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Roll Simulator");

            // Ask for number of rolls
            Console.Write("Enter the number of times you want to roll the dice: ");
            int numberOfRolls = int.Parse(Console.ReadLine() ?? "0");

            if (numberOfRolls <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number");
                return;
            }

            // Creates a new instance of the diceRoller
            DiceRoller diceRoller = new DiceRoller();

            int[] rollResults = diceRoller.RollDice(numberOfRolls);

            //Histogram
            Console.WriteLine("\nDice Roll Histogram");
            for (int i = 2; i <= 12; i++)
            {
                double percentage = (rollResults[i] / (double)numberOfRolls * 100);
                Console.Write($"{i}: ");
                Console.WriteLine(new string('*', (int)Math.Round(percentage)));
            }
        }
    }
}
