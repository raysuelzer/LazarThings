using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazarCalculator.Helpers
{
    public class LazarHelpers
    {

        public static void WriteEmptyLines(int numberOfLines =  0)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine();
            }            
        }
    }
}
