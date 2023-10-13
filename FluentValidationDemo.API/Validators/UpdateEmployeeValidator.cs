using FluentValidation;
using FluentValidationDemo.API.Request;

namespace FluentValidationDemo.API.Validators
{
    public class UpdateEmployeeValidator : AbstractValidator<UpdateEmployeeRequest>
    {
        public UpdateEmployeeValidator() 
        {
            RuleFor(model => model.EmployeeName)
                .Length(5, 30)
                .WithMessage("Employee name must be between 3 to 30 characters");

            RuleFor(model => model.Age)
                .InclusiveBetween(21, 30)
                .WithMessage("Employee age must be between 21 to 30");

            RuleFor(model => model.Mobile)
                .Matches("^\\d{10}$")
                .WithMessage("Phone number must be 10 digits");
        }
    }
}
