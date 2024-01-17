using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDice
    {
        //Import Random class
        Random rnd = new Random();
        
        //Method that will simulate the rolling of two dice, and putting the results in an array
        public int[] RollResults(int num)
        {          
            //Create an array for the rolls, that is the length of the number of rolls the user requested
            int[] rolls = new int[num]; 
            
            //Loop through and roll two dice, then add them together and put the result in an array
            for (int i = 0; i<num; i++)
            {
                int Dice1 = rnd.Next(1, 7);
                int Dice2 = rnd.Next(1, 7);
                rolls[i] = Dice1 + Dice2;
            }

            //Return an array of the roll results
            return rolls;
            
        }
    }
}
