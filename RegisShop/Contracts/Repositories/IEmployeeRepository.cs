using System.Collections;
using BethanysPieShopHRM.Shared.Domain;

namespace RegisShop.Contracts.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task <Employee> GetEmployeeById(int employeeId);
    }
}
