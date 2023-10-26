using System;
using LazarCalculator.AudioVisualEffects;
using LazarCalculator.Helpers;


namespace LazarCalculator
{
    internal class ProgramMenu
    {
        public static int MainMenuSelector()
        {
            int[] allowedMenu = new int[5] { 1, 2, 3, 4, 0 };
            int menuChoice;

            LazarHelpers.ResetConsole();
            Console.WriteLine("...Welcome, Lazar...");
            Console.WriteLine();
            Console.WriteLine("What do you need?");
            Console.WriteLine();
            Console.WriteLine("1: noob calc (+,-,*,/,^,%)");
            Console.WriteLine("2: bolt circle calc");
            Console.WriteLine("3: play that sound again!");
            Console.WriteLine("4: play some toejam & earl");
            Console.WriteLine("0: Exit Application");

            menuChoice = GetMenuNumber(allowedMenu);
            return menuChoice;
        }

        private static int GetMenuNumber(int[] allowedMenu)
        {
            int menuNum;
            bool parseCheck = int.TryParse(Console.ReadLine(), out menuNum);

            //As long as boolean is false, it keeps looping input
            while (!allowedMenu.Contains(menuNum))
            {
                Console.WriteLine();
                Console.WriteLine("laaaaazzzzaaaarrrrr.. Try Again...");
                parseCheck = int.TryParse(Console.ReadLine(), out menuNum);
            }
            return menuNum;
        }
    }
}


