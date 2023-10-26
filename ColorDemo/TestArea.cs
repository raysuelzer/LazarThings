using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFun.Calc
{
    public class Calculator
    {
        public void RunCalculation()
        {
            //delcare variables
            string[] allowedOper = new string[4] { "+", "-", "*", "/" };
            string type;
            int num1;
            int num2;
            int answer;
            string restartCheck;

            //operator type
            Console.WriteLine("What kind of calculation is this? (+, -, *, or /) ?");
            type = GetCalcType(allowedOper);

            //first number
            Console.WriteLine("Type the first number.");
            num1 = GetCalcNum();

            //second number
            Console.WriteLine("Type the second number.");
            num2 = GetCalcNum();

            //running the calculation
            answer = Calculate(num1, num2, type);

            //showing the answer
            Console.WriteLine("The answer is " + answer + "\r\n Write 'y' to restart application.");
            //checking if the user wants to restart the app
            restartCheck = Console.ReadLine();
            if (restartCheck == "y")
            {
                RunCalculation();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private string GetCalcType(string[] allowerdOper)
        {
            //getting the operator
            string type = Console.ReadLine();

            //Check if valid operator is slected
            while (!allowerdOper.Contains(type))
            {
                Console.WriteLine("You can only choose +, -, *, or /...");
                type = Console.ReadLine();
            }

            return type;
        }

        private int GetCalcNum()
        {
            int num;
            //checking if parse is successful
            //Returns as a boolean
            bool parseCheck = int.TryParse(Console.ReadLine(), out num);

            //As long as boolean is false, it keeps looping input
            while (!parseCheck)
            {
                Console.WriteLine("laaaaazzzzaaaarrrrr");
                parseCheck = int.TryParse(Console.ReadLine(), out num);
            }

            return num;
        }

        public int Calculate(int num1, int num2, string type)
        {
            //declaring variables
            int result;

            //Check operator type
            if (type == "+")
            {
                result = num1 + num2;
                return result;
            }
            else if (type == "-")
            {
                result = num1 - num2;
                return result;
            }
            else if (type == "*")
            {
                result = num1 * num2;
                return result;
            }
            else
            {
                result = num1 / num2;
                return result;
            }
        }
    }
}

