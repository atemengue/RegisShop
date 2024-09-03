using BethanysPieShopHRM.Shared.Domain;
using RegisShop.Contracts.Repositories;
using RegisShop.Contracts.Services;

namespace RegisShop.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeDataService(IEmployeeRepository employeeRepository) { 
            _employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _employeeRepository.GetAllEmployees();
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            return await _employeeRepository.GetEmployeeById(employeeId);
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            return await _employeeRepository.AddEmployee(employee);
        }
        public async Task<Employee> UpadteEmployee(Employee employee)
        {
            return await _employeeRepository.UpdateEmployee(employee);
        }
        public async Task DeleteEmployee(int employeeId)
        {
             await _employeeRepository.DeleteEmployee(employeeId);
        }
    }
}
