using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorView = basicCalculator.Form1;
namespace basicCalculator
{
    public class CalculatorController
    {
        private CalculatorModel model;
        private CalculatorView view;

        public CalculatorController(CalculatorModel model, CalculatorView view)
        {
            this.model = model;
            this.view = view;

            view.OnDigitPressed += DigitPressed;
            view.OnOperatorPressed += OperatorPressed;
            view.OnEqualsPressed += EqualsPressed;
            view.OnClearPressed += ClearPressed;
        }

        private void DigitPressed(int digit)
        {
            model.Operand = model.Operand * 10 + digit;
            view.UpdateDisplay(model.Operand.ToString());
        }

        private void OperatorPressed(string op)
        {
            model.Operator = op;
            model.CurrentValue = model.Operand;
            model.Operand = 0;
            view.UpdateDisplay(op);
        }

        private void EqualsPressed()
        {
            model.PerformOperation();
            view.UpdateDisplay(model.CurrentValue.ToString());
            model.Operand = 0;
        }

        private void ClearPressed()
        {
            model.Clear();
            view.UpdateDisplay("0");
        }
    }

}
