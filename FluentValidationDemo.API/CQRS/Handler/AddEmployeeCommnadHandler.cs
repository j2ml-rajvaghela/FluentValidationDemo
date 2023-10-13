using FluentValidationDemo.API.CQRS.Command;
using FluentValidationDemo.API.Data;
using FluentValidationDemo.API.Factory;
using MediatR;

namespace FluentValidationDemo.API.CQRS.Handler
{
    public class AddEmployeeCommnadHandler : IRequestHandler<AddEmployeeCommnad, long>
    {
        private readonly EmployeeContext _employeeContext;

        public AddEmployeeCommnadHandler(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<long> Handle(AddEmployeeCommnad request, CancellationToken cancellationToken)
        {
            var employee = EmployeeFactory.MapToAddEmployeeRequest(request.AddEmployee);
            if (employee == null)
            {
                return 0;
            }
            try
            {
                var addedEmployee = await _employeeContext.Employees.AddAsync(employee);
                var response = await _employeeContext.SaveChangesAsync();

                if (response >= 1)
                {
                    return employee.EmployeeId;
                }
                else
                {
                    return 0;
                }
               
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
