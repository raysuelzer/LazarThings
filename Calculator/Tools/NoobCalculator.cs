using LazarCalculator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazarCalculator.Tools
{
    internal class NoobCalculator
    {

        //  Needs to be public (or internal) so other classes can call this method
        //  Internal means that only classes in the same assembly can call this method
        //  Public means that any class can call this method
        //  Since your entire program is in the same assesmbly, it's not a big deal
        internal static void Start()
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
            // TODO: Use TryParse instead of Convert.ToDouble
            //       Add a check for 0 if division
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (op == "+")
            {
                // Note here: I made this am add method on the class called Add
                // that returns the result
                // you would want to do this for all the operations
                Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
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

            PromptUserToContinueOrReturn();
        }

        // Calculation Methods, private means that only this class knows these methods exist
        // this is called "Implemenation details". The users of this class don't care how the 
        // magic happens. 

        private static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Only methods within NoobClaculator.cs can call this
        // because it is private
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
