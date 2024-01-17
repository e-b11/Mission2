using Mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        RollDice rd = new RollDice();
        
        System.Console.WriteLine("Welcome to the dice throwing simulator!\n");
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        int numRolls = int.Parse(System.Console.ReadLine());

        rd.RollResults(numRolls);
    }
}