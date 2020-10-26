using System;

namespace Orion.Calculator.BusinessLogic
{
    public interface ICalculatorManager
    {
        public double Add(double firstOperand, double secondOperand);

        public double Subtract(double firstOperand, double secondOperand);

        public double Multiply(double firstOperand, double secondOperand);

        public double Divide(double firstOperand, double secondOperand);
    }
}
