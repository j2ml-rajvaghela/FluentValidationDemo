using FluentValidationDemo.API.Request;
using MediatR;

namespace FluentValidationDemo.API.CQRS.Command
{
    public class AddEmployeeCommnad : IRequest<long>
    {
        public AddEmployeeCommnad(AddEmployeeRequest addEmployee)
        {
            AddEmployee = addEmployee;
        }

        public AddEmployeeRequest AddEmployee { get; }
    }
}
