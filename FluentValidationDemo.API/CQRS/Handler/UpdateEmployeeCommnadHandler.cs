using FluentValidationDemo.API.CQRS.Command;
using FluentValidationDemo.API.Data;
using MediatR;
using System.Data.Entity;

namespace FluentValidationDemo.API.CQRS.Handler
{
    public class UpdateEmployeeCommnadHandler : IRequestHandler<UpdateEmployeeCommnad, long>
    {
        private readonly EmployeeContext _employeeContext;

        public UpdateEmployeeCommnadHandler(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public async Task<long> Handle(UpdateEmployeeCommnad request, CancellationToken cancellationToken)
        {
            var employee = await _employeeContext.Employees.FirstOrDefaultAsync(x => x.EmployeeId == request.UpdateEmployee.EmployeeId);
            if (employee == null)
            {
                return 0;
            }
            else
            {
                employee.EmployeeId = request.UpdateEmployee.EmployeeId;
                employee.EmployeeName = request.UpdateEmployee.EmployeeName;
                employee.Age = request.UpdateEmployee.Age;
                employee.Mobile = request.UpdateEmployee.Mobile;
            }
            try
            {
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
