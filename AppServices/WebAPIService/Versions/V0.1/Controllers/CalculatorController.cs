using System.Threading.Tasks;
using BusinessServices.Modules.CalculatorModule.Addition;
using BusinessServices.Modules.CalculatorModule.Subtraction;
using BusinessServices.Modules.CalculatorModule.Division;
using BusinessServices.Modules.CalculatorModule.Multiplication;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIService.Versions.V01.Controllers
{

    [Route ("api/{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("0.1")]
    public class CalculatorController : ControllerBase {
        private readonly IMediator mediator;
        public CalculatorController (IMediator mediator) {            
            this.mediator = mediator;
        }


        /// <summary>
        /// Addition
        /// </summary>
        /// <returns></returns>
        [HttpPost(nameof(Addition))]
        public async Task<IActionResult> Addition(AdditionCommand additionCommand) {
            return Ok(await mediator.Send(additionCommand));
        }


        /// <summary>
        /// Subtraction
        /// </summary>
        /// <returns></returns>
        [HttpPost(nameof(Subtraction))]
        [Authorize]
        public async Task<IActionResult> Subtraction(SubtractionCommand subtractionCommand) {
            return Ok(await mediator.Send(subtractionCommand));
        }


        /// <summary>
        /// Division
        /// </summary>
        /// <returns></returns>
        [HttpPost(nameof(Division))]
        public async Task<IActionResult> Division(DivisionCommand divisionCommand) {
            return Ok(await mediator.Send(divisionCommand));
        }


        /// <summary>
        /// Multiplication
        /// </summary>
        /// <returns></returns>
        [HttpPost(nameof(Multiplication))]
        [Authorize]
        public async Task<IActionResult> Multiplication(MultiplicationCommand multiplicationCommand) {
            return Ok(await mediator.Send(multiplicationCommand));
        }
    }
}