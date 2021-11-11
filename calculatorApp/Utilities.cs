using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorApp
{
    class Utilities
    {
        public static double Calculate(string operationType, double firstNum, double secondNum)
        {
            if (operationType == "addition") return firstNum + secondNum;
            else if (operationType == "substract") return firstNum - secondNum;
            else if (operationType == "multiply") return firstNum * secondNum;
            else if (operationType == "divide" && secondNum != '0') return firstNum / secondNum;
            else return 0;
        }
    }
}
