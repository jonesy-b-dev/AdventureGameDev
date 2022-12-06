using System;

namespace AdventureGameV2
{
    internal class InputHandler
    {
        static string[] inputArr;

        internal static string FormatInput()
        {
            string input = Console.ReadLine().ToLower();
            
            //makeArray(input);


            return input;
            
        }

        private static void makeArray(string input)
        {
            inputArr = input.Split(' ');

            int arrIndex = 0;
            foreach (string word in inputArr)
            {
                if (word.Contains(" "))
                {
                    Console.WriteLine("space found");
                }
                Console.WriteLine(word);

                arrIndex++;
            }
        }
    }
}