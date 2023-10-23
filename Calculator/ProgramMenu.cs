using LazarCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazarCalculator
{
    internal class ProgramMenu
    {

        /**
         * Displays the main menu and returns the user's selection
         */
        public static int MainMenuSelector()
        {
            LazarHelpers.ResetConsole();

            Console.WriteLine("...Welcome, Lazar...");
            Console.WriteLine("Which Calculator do you need?");
            Console.WriteLine("1: noob calc (+,-,*,/,^,%)");
            Console.WriteLine("2: cartesian hex calc");
            Console.WriteLine("3: play that sound again!");
            Console.WriteLine("4: play some toejam & earl");
            Console.WriteLine("0: Exit Application");


            bool isValid = int.TryParse(Console.ReadLine(), out int menuNum);
            if (!isValid)
            {
                Console.WriteLine("you lazar!");
                Thread.Sleep(1000);
                MainMenuSelector();
            }

            // Ideally we would also check that the number is one of the valid menu items
            // We would also ideally store all the menu items in a list and loop through them
            // we could use that list to check if the number is valid. I'll leave this for a later
            // exercise.
            return menuNum;
        }
    }
}
