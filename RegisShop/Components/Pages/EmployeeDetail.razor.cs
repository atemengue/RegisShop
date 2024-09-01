using RegisShop.Services;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Shared.Domain;
using RegisShop.Contracts.Services;

namespace RegisShop.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        protected override async void OnInitialized()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
           //Employee = MockDataService.Employees.Single( e => e.EmployeeId == EmployeeId);
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
