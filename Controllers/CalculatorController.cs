using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // Add method to return the sum of two numbers
        [HttpGet("add")]
        public ActionResult<decimal> Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        // Subtract method to return the difference of two numbers
        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        // Multiply method to return the product of two numbers
        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        // Divide method to return the quotient of two numbers
        [HttpGet("divide")]
        public ActionResult<decimal> Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                return BadRequest("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        // Modulo method to return the remainder of division of two numbers
        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo(decimal num1, decimal num2)
        {
            return num1 % num2;
        }
    }
}