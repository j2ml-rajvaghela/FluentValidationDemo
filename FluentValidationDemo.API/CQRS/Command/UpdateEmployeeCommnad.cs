using FluentValidationDemo.API.Request;
using MediatR;

namespace FluentValidationDemo.API.CQRS.Command
{
    public class UpdateEmployeeCommnad : IRequest<long>
    {
        public UpdateEmployeeCommnad(UpdateEmployeeRequest updateEmployee)
        {
            UpdateEmployee = updateEmployee;
        }

        public UpdateEmployeeRequest UpdateEmployee { get; }
    }
}
