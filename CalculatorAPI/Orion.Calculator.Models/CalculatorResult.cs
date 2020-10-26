using System;

namespace Orion.Calculator.Models
{
    public class CalculatorResult
    {
        public bool IsSuccessful { get; set; }

        public double Result { get; set; }

        public string ErrorMessage { get; set; }
    }
}