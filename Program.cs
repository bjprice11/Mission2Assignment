using Mission2Assignment;

internal class Program
{
    // Main Method
    public static void Main(string[] args)
    {
        // Calls Constructor
        DiceRoll dr =  new DiceRoll();
        // Welcomes user
        Console.WriteLine("Welcome to the dice throwing simulator!");
        //Allows for input of number
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");
        //Reads the input and assigns that to an integer
        int numRolls = int.Parse(Console.ReadLine());
        // Creates an array of integers, calling the constructor and passing in the inputted number
        int[] rollResults = dr.PrintRoll(numRolls);
        // Runs the PrintHist Method, passing in the integer array and the inputted number of rolls
        PrintHist(rollResults, numRolls);
        //Prints to end simulation
        Console.WriteLine("Thank you for using this Simulation!");
    }

    // New method to calculate percentages, receives an integer array and an integer
    public static void PrintHist(int[] rollResults, int numRolls)
    {
        //Prints beginning messages
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.\n");

        //For the integers 2-12 (13 is exclusive) it loops through the process.
        for (int i = 2; i < 13; i++)
        {
            // Creates integer for the percentage. Takes the integer that is in the array for each number and divides that by the number of rolls
            int percentage = (int)((rollResults[i] / (double)numRolls)*100);
            
            //Creates a new string that is an "*" that repeates the same number of times as the percentage
            string ast = new string('*',  percentage);
            
            // Prints out the numbers (i) and the astrisks however many times they appear
            Console.WriteLine($"{i}: {ast}");
        }
        
    }
}