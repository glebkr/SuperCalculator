using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SuperCalculator
{
    public static class OperatorHelper
    {
       public static double Calculate(double value1, double value2, string myOperator)
        {
            double result = 0;
            switch(myOperator)
            {
                case "÷":
                    result = value1 / value2;
                    break;
                case "*":
                    result = value1 * value2;
                    break;
                case "+":
                    result = value1 + value2;
                    break;
                case "-":
                    result = value1 - value2;
                    break;
            }
            return result;
        }
    }
}