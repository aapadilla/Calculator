using System;

namespace Orion.Calculator.BusinessLogic
{
    public class CalculatorManager : ICalculatorManager
    {
        private readonly IOperandValidator _operandValidator;

        public CalculatorManager(IOperandValidator operandValidator)
        {
            _operandValidator = operandValidator;
        }

       public double Add(double firstOperand, double secondOperand)
        {
            if (_operandValidator.IsOperandValid(firstOperand) && _operandValidator.IsOperandValid(secondOperand))
            {
                return firstOperand + secondOperand;
            }

            throw new ApplicationException($"Operands cannot exceed more than 5 numbers {firstOperand}, {secondOperand}");
        }

        public double Subtract(double firstOperand, double secondOperand)
        {
            if (_operandValidator.IsOperandValid(firstOperand) && _operandValidator.IsOperandValid(secondOperand))
            {
                return firstOperand - secondOperand;
            }

            throw new ApplicationException($"Operands cannot exceed more than 5 numbers {firstOperand}, {secondOperand}");

        }

        public double Multiply(double firstOperand, double secondOperand)
        {
            if (_operandValidator.IsOperandValid(firstOperand) && _operandValidator.IsOperandValid(secondOperand))
            {
                return firstOperand * secondOperand;
            }

            throw new ApplicationException($"Operands cannot exceed more than 5 numbers {firstOperand}, {secondOperand}");
        }

        public double Divide(double firstOperand, double secondOperand)
        {
            if (!_operandValidator.AreOperandsValidForDivision(firstOperand, secondOperand))
            {
                throw new DivideByZeroException($"Division Operands must be non zero {firstOperand}, {secondOperand}");
            }

            if (_operandValidator.IsOperandValid(firstOperand) && _operandValidator.IsOperandValid(secondOperand))
            {
                return firstOperand / secondOperand;
            }

            throw new DivideByZeroException($"Operands cannot exceed more than 5 numbers {firstOperand}, {secondOperand}");
        }
    }
}
