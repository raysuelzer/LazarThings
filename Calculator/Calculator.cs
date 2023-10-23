using System;
using System.Diagnostics;


namespace LazarCalculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            LightShow();

            static void LightShow()
            {
                foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                {
                    Console.BackgroundColor = color;
                    Console.Clear();
                    Thread.Sleep(1);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                Thread.Sleep(500);

                Console.WriteLine("***********************************************************************************************************");
                Console.WriteLine("*** ** *                       __                        _____            _                        * ** ***");
                Console.WriteLine("*** ** *                      / /   __ _ ______ _ _ __  /__   \\___   ___ | |___                    * ** ***");
                Console.WriteLine("*** ** *                     / /   / _` | _ / _' | '__|   / /\\/ _ \\ / _ \\| / __|                   * ** ***");
                Console.WriteLine("*** ** *                    / /___| (_| |/ / (_| | |     / / | (_) | (_) | \\__ \\                   * ** ***");
                Console.WriteLine("*** ** *                    \\_____/\\__,_/___\\__,_|_|     \\/   \\___/ \\___/|_|___/                   * ** ***");
                Console.WriteLine("*** ** *                                                                                           * ** ***");
                Console.WriteLine("***********************************************************************************************************");
 
                TitleTune();
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
                int menuNum = Convert.ToInt32(Console.ReadLine());

                if (menuNum == 1)
                {
                    NoobCalc();
                }
                else if (menuNum == 2)
                {
                    HexCalc();
                }
                else if (menuNum == 3)
                {
                    TitleTune();
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

            static void NoobCalc()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.WriteLine("Enter your first number to begin calculations...");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Enter operation type: +, -, *, /, ^, or % ...");
                string op = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Enter your second nubmer...");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                if (op == "+")
                {
                    Console.WriteLine($"{num1} + {num2} = " + (num1 + num2));
                }
                else if (op == "-")
                {
                    Console.WriteLine($"{num1} - {num2} = " + (num1 - num2));
                }
                else if (op == "*")
                {
                    Console.WriteLine($"{num1} * {num2} = " + (num1 * num2));
                }
                else if (op == "/")
                {
                    Console.WriteLine($"{num1} / {num2} = " + (num1 / num2));
                }
                else if (op == "^")
                {
                    double exponentAnswer = Math.Pow(num1, num2);
                    Console.WriteLine($"{num1} to the power of {num2} = " + exponentAnswer);
                }
                else if (op == "%")
                {
                    double percentAnswer = ((double)num2 / 100) * num1;
                    Console.WriteLine($"{num1}% of {num2} is " + percentAnswer);
                }
                else
                {
                    Console.WriteLine("Woah, Bro. Slow down. This isn't fuckin' NASA...");
                }
                NewCalculation();
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

            static void NewCalculation()
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
                    NoobCalc();
                }
                if (input.Key == ConsoleKey.Escape)
                {
                    LazarMenu();
                }
                else NewCalculation();
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

            static void TitleTune()
            {
                Console.Beep(784, 225);
                Console.Beep(392, 225);
                Console.Beep(784, 225);
                Console.Beep(330, 225);
                Console.Beep(784, 225);
                Console.Beep(659, 225);
                Console.Beep(1047, 675);

                Thread.Sleep(2000);
                Console.Clear();
                LazarMenu();
            }

            static void ToeJam()
            {
                Console.WriteLine("Ha Ha! JK, you're a weiner...");
                Thread.Sleep(2250);
                LazarMenu();
            }
            
        }
    }
}