using BethanysPieShopHRM.Shared.Domain;

namespace RegisShop.Contracts.Services
{
    public interface IEmployeeDataService
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeDetails(int employeeId);
    }
}
