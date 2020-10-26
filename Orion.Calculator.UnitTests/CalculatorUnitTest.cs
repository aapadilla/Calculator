using System;
using NUnit.Framework;
using FakeItEasy;
using Orion.Calculator.BusinessLogic;

namespace Orion.Calculator.UnitTests
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private ICalculatorManager _calculatorManager;

        [SetUp]
        public void Setup()
        {
            _calculatorManager = new CalculatorManager(new OperandValidator());            
        }

        [TestCase(99,99,198)]
        [TestCase(16988, 16, 17004)]
        public void GivenAdd_WhenOperandsAreValid_ThenReturnResult(double firstOperand, double secondOperand, double expectedResult)
        {
            var result = _calculatorManager.Add(firstOperand, secondOperand);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(189, 19, 170)]
        [TestCase(6787, 598, 6189)]
        public void GivenSubtract_WhenOperandsAreValid_ThenReturnResult(double firstOperand, double secondOperand, double expectedResult)
        {
            var result = _calculatorManager.Subtract(firstOperand, secondOperand);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(476, 15, 7140)]
        [TestCase(1389, 4, 5556)]
        public void GivenMultiply_WhenOperandsAreValid_ThenReturnResult(double firstOperand, double secondOperand, double expectedResult)
        {
            var result = _calculatorManager.Multiply(firstOperand, secondOperand);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(369, 3, 123)]
        [TestCase(4482, 9, 498)]
        public void GivenDivide_WhenOperandsAreValid_ThenReturnResult(double firstOperand, double secondOperand, double expectedResult)
        {
            var result = _calculatorManager.Divide(firstOperand, secondOperand);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(192999, 234)]
        [TestCase(1299, 1255.54)]
        public void GivenAdd_WhenOperandsAreInValid_ThenReturnResult(double firstOperand, double secondOperand)
        {
            var exception = Assert.Throws<ApplicationException>(() =>
            {
                _calculatorManager.Add(firstOperand, secondOperand);
            });

            Assert.IsTrue(exception.Message.Contains($"Operands cannot exceed more than 5 numbers {firstOperand}, {secondOperand}"));
        }

        [TestCase(7898.98, 234)]
        [TestCase(443, 88543.1)]
        public void GivenSubtract_WhenOperandsAreInValid_ThenReturnResult(double firstOperand, double secondOperand)
        {
            var exception = Assert.Throws<ApplicationException>(() =>
            {
                _calculatorManager.Add(firstOperand, secondOperand);
            });

            Assert.IsTrue(exception.Message.Contains($"Operands cannot exceed more than 5 numbers {firstOperand}, {secondOperand}"));
        }

        [TestCase(1.34456, 4)]
        [TestCase(63, 34.23456)]
        public void GivenMultiply_WhenOperandsAreInValid_ThenReturnResult(double firstOperand, double secondOperand)
        {
            var exception = Assert.Throws<ApplicationException>(() =>
            {
                _calculatorManager.Add(firstOperand, secondOperand);
            });

            Assert.IsTrue(exception.Message.Contains($"Operands cannot exceed more than 5 numbers {firstOperand}, {secondOperand}"));
        }

        [TestCase(92, 0)]
        [TestCase(0, 16)]
        public void GivenDivide_WhenOperandsAreInValid_ThenReturnResult(double firstOperand, double secondOperand)
        {
            var exception = Assert.Throws<DivideByZeroException>(() =>
            {
                _calculatorManager.Divide(firstOperand, secondOperand);
            });

            Assert.IsTrue(exception.Message.Contains($"Division Operands must be non zero {firstOperand}, {secondOperand}"));
        }

    }
}
