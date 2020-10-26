using System;
namespace Orion.Calculator.BusinessLogic
{
    public class OperandValidator : IOperandValidator
    {
        public bool IsOperandValid(double operand)
        {
            var rawOperand = operand.ToString().Replace(".", string.Empty);

            return rawOperand.Length <= 5;
        }

        public bool AreOperandsValidForDivision(double firstOperand, double secondOperand)
        {
            return firstOperand != 0 && secondOperand != 0;
        }
    }
}
