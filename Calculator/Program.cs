using LazarCalculator.AudioVisualEffects; // Note I add using here so I can access the classes
using LazarCalculator.Tools;
using System;
using System.Diagnostics;


namespace LazarCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here is an example of creating a class and not using a static class
            // 98% of the time you will do this. You can imagine that you could reuse this class
            // but pass in a different ascii art or color
            var lightShow = new LightShow(ConsoleColor.Green, ConsoleColor.Black);
            lightShow.Play();

            // This is an example of using a static class becuase I am lazy            
            TitleTune.PlayTitleTune();

            LazarMenu();
        }

        static void LazarMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

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
                Console.WriteLine("you fool!");
                LazarMenu();
            }

            if (menuNum == 1)
            {
                NoobCalculator.Start();
                // Once noob calc ends, we go back to this menu
                LazarMenu();
            }
            else if (menuNum == 2)
            {
                HexCalc();
            }
            else if (menuNum == 3)
            {
                TitleTune.PlayTitleTune();
            }
            else if (menuNum == 4)
            {
                ToeJam();
            }
            else if (menuNum == 0)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You FOOL!");
                Thread.Sleep(1000);
                LazarMenu();
            }
        }       


        static void HexCalc()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Title = "Calculate Cartesian Coordinates of an Equilateral Hexagon";
            Console.WriteLine("Enter your known measurement for the hexagon:");
            Console.WriteLine("1. Length of one of the sides");
            Console.WriteLine("2. Diameter between opposite sides");
            Console.WriteLine("3. Diameter between opposite vertices");
            int option = int.Parse(Console.ReadLine());

            double knownMeasurement = 0;
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the length of one of the sides in inches:");
                    knownMeasurement = double.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Enter the diameter between opposite sides in inches:");
                    knownMeasurement = double.Parse(Console.ReadLine()) / Math.Sqrt(3);
                    break;
                case 3:
                    Console.WriteLine("Enter the diameter between opposite vertices in inches:");
                    knownMeasurement = double.Parse(Console.ReadLine()) / 2;
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    return;
            }

            Console.WriteLine("Enter the x-coordinate of the center point:");
            double centerX = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the y-coordinate of the center point:");
            double centerY = double.Parse(Console.ReadLine());

            double radius = knownMeasurement * Math.Sqrt(3);

            double[] xCoordinates = new double[6];
            double[] yCoordinates = new double[6];

            for (int i = 0; i < 6; i++)
            {
                xCoordinates[i] = centerX + radius * Math.Cos(Math.PI / 3 * i);
                yCoordinates[i] = centerY + radius * Math.Sin(Math.PI / 3 * i);
                Console.WriteLine($"Vertex {i + 1}: ({xCoordinates[i]}, {yCoordinates[i]})");
            }
            NewHexCalculation();
        }       

        static void NewHexCalculation()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("press Enter to Begin a new calculation or Escape to exit...");
            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.Enter)
            {
                HexCalc();
            }
            if (input.Key == ConsoleKey.Escape)
            {
                LazarMenu();
            }
            else NewHexCalculation();
        }

        static void ToeJam()
        {
            Console.WriteLine("Ha Ha! JK, you're a weiner...");
            Thread.Sleep(2250);
            LazarMenu();
        }

    }
}