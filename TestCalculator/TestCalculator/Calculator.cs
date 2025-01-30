using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProgram
{

    public class Calculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Sub(int a, int b)
        {
            int result = a - b;
            return result;
        }

        public static double Div(int a, int b)
        {
            if (b != 0)
            {
                int result = a / b;
                return result;
            }

            else
            {
                Console.WriteLine("Error: Cannot divide by 0");
            }
        }

        public int Mul(int a, int b)
        {
            int result = a * b;
            return result;
        }
    }
}


