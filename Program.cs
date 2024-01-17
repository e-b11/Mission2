using Mission2;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //Create new instance of RollDice class
        RollDice rd = new RollDice();
        
        //Intro
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        
        //Get the number of rolls from user and assign it to an integer variable
        int numRolls = int.Parse(System.Console.ReadLine());

        // Get the result of the RollResults method, should be an array of results
        int[] rolls = rd.RollResults(numRolls);

        //Result messages
        System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");        System.Console.WriteLine("Total number of rolls = " + numRolls.ToString() + ".\n");

        //Loop through the possible number results of rolling two dice
        for (int num = 2; num < 13;  num++)
        {
            // Initialize variables
            int numberOccurences = 0;
            string output = "";

            // Loop through the roll results in the array and keep track if the result matches the current number
            for (int iCount = 0; iCount < rolls.Length; iCount++)
            {
                if (rolls[iCount] == num)
                {
                    numberOccurences += 1;
                }
            }

            //Turn the number of occurences for the number into a percentage of the number of rolls, then round/convert it to an integer
            double rollPercent = (double)numberOccurences / numRolls;
            rollPercent *= 100;
            int roundedPercent = (int)Math.Round(rollPercent);
            
            //Concatenate an output of the current number, and an asteric for each 1 percent of the number of rolls the current number was. Should look like a histogram at the end. 
            output += ((num.ToString() + ": ") + new string('*', roundedPercent));
            
            //Show the output
            System.Console.WriteLine(output);
        }

        //End message
        System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

    }
}