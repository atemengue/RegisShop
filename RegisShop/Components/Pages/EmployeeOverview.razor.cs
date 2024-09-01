using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using RegisShop.Contracts.Services;
using RegisShop.Services;

namespace RegisShop.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        private string Title = "Employee overview";

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
           Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }

        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee = selectedEmployee;
        }

      
    }
}
