using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazarCalculator.Helpers
{
    public class LazarHelpers
    {
        /** Resets the console to a blank state with the default colors */
        public static void ResetConsole()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
        }

        /**
         * Writes N number of empty lines to the console
         */
        public static void WriteEmptyLines(int numberOfLines =  0)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine();
            }            
        }
    }
}
