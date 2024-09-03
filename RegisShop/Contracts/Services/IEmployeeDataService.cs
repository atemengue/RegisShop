using BethanysPieShopHRM.Shared.Domain;

namespace RegisShop.Contracts.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeDetails(int employeeId);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpadteEmployee(Employee employee);
        Task DeleteEmployee(int employeeId);
    }
}
