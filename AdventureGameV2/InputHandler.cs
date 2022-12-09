using System;
using System.Linq;

namespace AdventureGameV2
{
    internal class InputHandler
    {
        static string[] inputArr;

        internal static string FormatInput()
        {
            string input = Console.ReadLine().ToLower();
            
            makeArray(input);


            return input;
            
        }

        private static void makeArray(string input)
        {

            input = string.Join(" ", input.Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries));
            inputArr = input.Split(' ');

            int arrIndex = 0;

            foreach (string word in inputArr)
            {
                Console.WriteLine(word);

                arrIndex++;
            }
        }
    }
}