namespace FluentValidationDemo.API.Request
{
    public class UpdateEmployeeRequest
    {
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
    }
}
