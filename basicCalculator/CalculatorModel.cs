using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    public class CalculatorModel
    {
        public double CurrentValue { get;  set; }
        public double Operand { get; set; }
        public string Operator { get; set; }

        public void PerformOperation()
        {
            switch (Operator)
            {
                case "+":
                    CurrentValue += Operand;
                    break;
                case "-":
                    CurrentValue -= Operand;
                    break;
                case "*":
                    CurrentValue *= Operand;
                    break;
                case "/":
                    if (Operand != 0)
                        CurrentValue /= Operand;
                    else
                        throw new DivideByZeroException();
                    break;
            }
        }

        public void Clear()
        {
            CurrentValue = 0;
            Operand = 0;
            Operator = string.Empty;
        }
    }

}
