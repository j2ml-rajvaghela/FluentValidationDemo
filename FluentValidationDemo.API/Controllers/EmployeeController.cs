using FluentValidationDemo.API.CQRS.Command;
using FluentValidationDemo.API.Request;
using FluentValidationDemo.API.Validators;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationDemo.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateEmployee([FromBody] AddEmployeeRequest addEmployee)
        {
            var validation = new AddEmployeeValidator();
            var validationResult = await validation.ValidateAsync(addEmployee);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            try
            {
                var command = new AddEmployeeCommnad(addEmployee);
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeRequest updateEmployee)
        {
            var validation = new UpdateEmployeeValidator();
            var validationResult = await validation.ValidateAsync(updateEmployee);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            try
            {
                var command = new UpdateEmployeeCommnad(updateEmployee);
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
