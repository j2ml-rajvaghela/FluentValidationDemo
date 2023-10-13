using FluentValidationDemo.API.Model;
using FluentValidationDemo.API.Request;

namespace FluentValidationDemo.API.Factory
{
    public class EmployeeFactory
    {
        public static Employee MapToAddEmployeeRequest(AddEmployeeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            Employee employee = new Employee();
            employee.EmployeeName = request.EmployeeName;
            employee.Age = request.Age;
            employee.Mobile = request.Mobile;
            return employee;
        }
    }
}
