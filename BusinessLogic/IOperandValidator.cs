using System;
namespace Orion.Calculator.BusinessLogic
{
    public interface IOperandValidator
    {
        public bool IsOperandValid(double operand);

        public bool AreOperandsValidForDivision(double firstOperand, double secondOperand);
    }
}
