using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orion.Calculator.BusinessLogic;
using Orion.Calculator.Models;

namespace Orion.Calculator.API.Controllers
{
    [Route("api/calculator")]
    public class CalculatorController : Controller
    {

        private readonly ICalculatorManager _calculatorManager;
        private CalculatorResult _calculatorResult;

        public CalculatorController(ICalculatorManager calculatorManager)
        {
            _calculatorManager = calculatorManager;
            _calculatorResult = new CalculatorResult();
        }

        [HttpGet("add/{firstOperand}/{secondOperand}")]
        public CalculatorResult Add(double firstOperand, double secondOperand)
        {
            try
            {
                _calculatorResult.Result = _calculatorManager.Add(firstOperand, secondOperand);
                _calculatorResult.IsSuccessful = true;
            }
            catch(Exception e)
            {
                _calculatorResult.IsSuccessful = false;
                _calculatorResult.ErrorMessage = e.Message.ToString();
            }
            return _calculatorResult;
        }

        [HttpGet("subtract/{firstOperand}/{secondOperand}")]
        public CalculatorResult Subtract(double firstOperand, double secondOperand)
        {
            try
            {
                _calculatorResult.Result = _calculatorManager.Subtract(firstOperand, secondOperand);
                _calculatorResult.IsSuccessful = true;
            }
            catch (Exception e)
            {
                _calculatorResult.IsSuccessful = false;
                _calculatorResult.ErrorMessage = e.Message.ToString();
            }
            return _calculatorResult;
        }

        [HttpGet("multiply/{firstOperand}/{secondOperand}")]
        public CalculatorResult Multiply(double firstOperand, double secondOperand)
        {
            try
            {
                _calculatorResult.Result = _calculatorManager.Multiply(firstOperand, secondOperand);
                _calculatorResult.IsSuccessful = true;
            }
            catch (Exception e)
            {
                _calculatorResult.IsSuccessful = false;
                _calculatorResult.ErrorMessage = e.Message.ToString();
            }
            return _calculatorResult;
        }

        [HttpGet("divide/{firstOperand}/{secondOperand}")]
        public CalculatorResult Divide(double firstOperand, double secondOperand)
        {
            try
            {
                _calculatorResult.Result = _calculatorManager.Divide(firstOperand, secondOperand);
                _calculatorResult.IsSuccessful = true;
            }
            catch (Exception e)
            {
                _calculatorResult.IsSuccessful = false;
                _calculatorResult.ErrorMessage = e.Message.ToString();
            }
            return _calculatorResult;
        }
    }
}
