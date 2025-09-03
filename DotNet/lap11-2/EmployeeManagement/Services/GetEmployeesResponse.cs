using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public class GetEmployeesResponse
    {
        public List<Employee> Employees { get; internal set; }
        public int StatusCode { get; internal set; }
        public string Message { get; internal set; }
    }
}