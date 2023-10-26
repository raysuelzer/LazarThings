using System;
using LazarCalculator.Helpers;

namespace LazarCalculator.Tools
{
    class BoltCircleCalc
    {
         internal static void Start()
         {
            double diameter;
            int numberOfHoles;
            double startingAngle;
            double centerX;
            double centerY;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Here we can plot the coordinates of holes in a bolt hole circle,");
            Console.WriteLine("or the vertices of any polygon...");
            Console.WriteLine();
            Console.WriteLine("Enter the diameter of the circle:");
            diameter = GetUserNumber();

            Console.WriteLine();
            Console.WriteLine("Enter the number of holes:");
            numberOfHoles = GetUserInt();

            Console.WriteLine();
            Console.WriteLine("Enter the starting angle of the first hole:");
            startingAngle = GetUserNumber();

            Console.WriteLine();
            Console.WriteLine("Enter the X coordinate of the center of the circle:");
            centerX = GetUserNumber();

            Console.WriteLine();
            Console.WriteLine("Enter the Y coordinate of the center of the circle:");
            centerY = GetUserNumber();
            Console.WriteLine();

            double radius = diameter / 2;
            double angleBetweenHoles = 360.0 / numberOfHoles;

            for (int i = 0; i < numberOfHoles; i++)
            {
                double angleInDegrees = startingAngle + i * angleBetweenHoles;
                double x = centerX + radius * Math.Cos(angleInDegrees * Math.PI / 180);
                double y = centerY + radius * Math.Sin(angleInDegrees * Math.PI / 180);

                Console.WriteLine($"Hole {i + 1}: ({Math.Round(x, 4)}, {Math.Round(y, 4)})");
            }

            PromptUserToContinueOrReturn();
         }

        //trying to get user numbers with one method
        private static double GetUserNumber()
        {
            double numNums;
            //checking if parse is successful
            //Returns as a boolean
            bool parseCheck = double.TryParse(Console.ReadLine(), out numNums);

            //As long as boolean is false, it keeps looping input
            while (!parseCheck)
            {
                Console.WriteLine("laaaaazzzzaaaarrrrr... Try Again...");
                parseCheck = double.TryParse(Console.ReadLine(), out numNums);
            }

            return numNums;
        }

        private static int GetUserInt()
        {
            int wholeNums;
            //checking if parse is successful
            //Returns as a boolean
            bool parseCheck = int.TryParse(Console.ReadLine(), out wholeNums);

            //As long as boolean is false, it keeps looping input
            while (!parseCheck)
            {
                Console.WriteLine("laaaaazzzzaaaarrrrr... Try Again...");
                parseCheck = int.TryParse(Console.ReadLine(), out wholeNums);
            }

            return wholeNums;
        }

        private static void PromptUserToContinueOrReturn()
        {
            // Write 5 Empty Lines, Using the helper
            LazarHelpers.WriteEmptyLines(5);
            Console.WriteLine("press Enter to Begin a new calculation or Escape to exit...");
            ConsoleKeyInfo input = Console.ReadKey(true);
            if (input.Key == ConsoleKey.Enter)
            {
                // Restart the calculator
                Start();
            }
            if (input.Key == ConsoleKey.Escape)
            {
                // End the calculator, returns control back to the caller
                return;
            }
            // Invalid choice, so make them choose again
            PromptUserToContinueOrReturn();
        }
    }
}