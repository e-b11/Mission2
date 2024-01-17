using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDice
    {
        Random rnd = new Random();
        public void RollResults(int num)
        {
            string output = "";
            int[] rolls = new int[num]; 
            
            for (int i = 0; i<num; i++)
            {
                int Dice1 = rnd.Next(1, 7);
                int Dice2 = rnd.Next(1, 7);
                rolls[i] = Dice1 + Dice2;
            }
            
            for (int i = 2; i < 13; i++)
            {
                output += (i.ToString() + ": ");
                for (int spn = 0; spn < rolls.Length; spn++)
                {
                    if (rolls[spn] == i)
                    {
                        output += "*";
                    }
                }
                System.Console.WriteLine(output);
                output = "";
            }
        }
    }
}
