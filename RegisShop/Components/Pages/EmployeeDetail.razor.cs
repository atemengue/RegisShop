using RegisShop.Services;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Shared.Domain;

namespace RegisShop.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        protected override void OnInitialized()
        {
           Employee = MockDataService.Employees.Single( e => e.EmployeeId == EmployeeId);
        }
    }
}
