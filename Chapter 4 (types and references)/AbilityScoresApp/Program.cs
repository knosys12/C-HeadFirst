using System.Runtime.InteropServices;
using static System.Console;
namespace AbilityScoresApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            AbilityScore caluculator = new AbilityScore();
            while (true)
            {
                caluculator.RollResult = ReadInt(caluculator.RollResult, "Starting 4d6 roll");
                caluculator.DivideBy = ReadDouble(caluculator.DivideBy, "Divide by");
                caluculator.AddAmount = ReadInt(caluculator.AddAmount, "Add amount");
                caluculator.Minimum = ReadInt(caluculator.Minimum, "Minimum");
                caluculator.CalculateAbilityScore();
                WriteLine("Calculated ability score: " + caluculator.Score);
                Write("Press Q to quit , any other key to continue");
                
                char keyChar = ReadKey(true).KeyChar;
                if ((keyChar == 'q') || (keyChar == 'Q')) return;
            }

            ReadKey();




        }
        /// <summary>
        /// Writes a prompt and read an int value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="Prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse</returns>
       
        private static double ReadDouble(double lastUsedValue, string Prompt)
        {

            WriteLine($"{Prompt,-10} [ {lastUsedValue,3} ]: ");
            string input;
            input = ReadLine();
            if(double.TryParse(input, out double value))
            {
                WriteLine($"Using value, {value,-10}");
                return value;
            }
            else
            {
                WriteLine($"Using default value, {lastUsedValue,3}");
                return lastUsedValue;
            }
        }

        /// <summary>
        /// Writes a prompt and read an int value from the console.
        /// </summary>
        /// <param name="lastUsedValue">The default value.</param>
        /// <param name="Prompt">Prompt to print to the console.</param>
        /// <returns>The int value read, or the default value if unable to parse</returns>
       

        private static int ReadInt(int lastUsedValue, string Prompt)
        {
            WriteLine($"{Prompt,-10} [ {lastUsedValue,3} ]: ");
            string input;
            input = ReadLine();
            if (int.TryParse(input, out int value))
            {
                WriteLine($" Using value {value,-10}");
                return value;
            }
            else
            {
                WriteLine($" Using default value,  {lastUsedValue,-10}");
                return lastUsedValue;
            }

        }
    }
}
