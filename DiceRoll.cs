using System.Diagnostics.SymbolStore;

namespace Mission2Assignment;

//DiceRoll Class
public class DiceRoll
{
    //Method that recieves the number of rolls from the console
    public int [] PrintRoll(int nr)
    {
        // Creates an integer array with 13 places, 0-12
        int[] results = new int[13];
        Random rnd = new Random();
        //Repeats the number of times that the dice is rolled
        for (int i = 0; i < nr; i++)
        {
            // The First dice is rolled, then the second and the sum in put together
            int die1 = rnd.Next(1, 7);
            int die2 = rnd.Next(1, 7);
            int sum = die1 + die2;
            
            //Appends the sum to the results array
            results[sum]++;
        }
        // Returns the results to the Method where is was callec
        return results;
    }
}