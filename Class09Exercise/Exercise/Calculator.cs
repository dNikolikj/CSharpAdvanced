using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public static  class Calculator
    {
        public static string SimpleCalculator(double number1, double number2)
        {
            string result = "";
            double calc = number1 + number2;

            result = calc.ToString();

            return $"{number1} + {number2} = {result}";
        }
    }
}
