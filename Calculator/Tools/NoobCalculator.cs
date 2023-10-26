using System;
using LazarCalculator.Helpers;


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
            double num1;
            double num2;
            string[] allowedOper = new string[6] { "+", "-", "*", "/", "^", "%" };
            string op;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Enter your first number to begin calculations...");
            num1 = GetUserNumber();
            Console.WriteLine();

            Console.WriteLine("Enter operation type: +, -, *, /, ^, or % ...");
            op = GetUserOp(allowedOper);

            Console.WriteLine();
            Console.WriteLine("Enter your second nubmer...");
            num2 = GetUserNumber();
            Console.WriteLine();

            Console.WriteLine();

            if (op == "+")
            {
                Console.WriteLine($"{num1} + {num2} = {Add(num1, num2)}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{num1} - {num2} = {Subtract(num1,num2)}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"{num1} * {num2} = {Multiply(num1,num2)}");
            }
            else if (op == "/")
            {
                Console.WriteLine($"{num1} / {num2} = {Divide(num1,num2)}");
            }
            else if (op == "^")
            {
                Console.WriteLine($"{num1} to the power of {num2} = {Exponent(num1,num2)}");
            }
            else if (op == "%")
            {
                Console.WriteLine($"{num1}% of {num2} is {Percentage(num1,num2)}");
            }
            else
            {
                Console.WriteLine("Woah, Bro. Slow down. This isn't fuckin' NASA...");
            }

            PromptUserToContinueOrReturn();
        }

        //trying to get user numbers with one method
        private static double GetUserNumber()
        {
            double num;
            //checking if parse is successful
            //Returns as a boolean
            bool parseCheck = double.TryParse(Console.ReadLine(), out num);

            //As long as boolean is false, it keeps looping input
            while (!parseCheck)
            {
                Console.WriteLine();
                Console.WriteLine("laaaaazzzzaaaarrrrr... Try Again...");
                parseCheck = double.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }
        
        private static string GetUserOp(string[] allowedOper)
        {
            //getting the operator
            string op = Console.ReadLine();

            //Check if valid operator is selected
            //I don't really get this part. I tried using a combo of this and the
            //GetUserNumber method above to get the main menu working better but im stumped.
            
            while (!allowedOper.Contains(op))
            {
                Console.WriteLine();
                Console.WriteLine("This isn't NASA. You can only choose +, -, *, /, ^, or %...");
                op = Console.ReadLine();
            }
            return op;
        }

        // Calculation Methods, private means that only this class knows these methods exist
        // this is called "Implemenation details". The users of this class don't care how the 
        // magic happens. 

        private static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        private static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        private static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        private static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        private static double Exponent(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
        private static double Percentage(double num1, double num2)
        {
            return ((double)num2 / 100) * num1;
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
