using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Shared.Domain;
using RegisShop.Contracts.Services;

namespace RegisShop.Components.Pages
{

    public partial class EmployeeAdd
    {
        [SupplyParameterFromForm]
        public Employee Employee { get; set; }
        protected string Message = string.Empty;
        protected bool IsSaved = false;
        [Inject]

        public IEmployeeDataService? EmployeeDataService { get; set; }

        protected override void OnInitialized()
        {
            Employee ??= new();
        }

        private async Task OnSubmit()
        {
            await EmployeeDataService.AddEmployee(Employee);
            IsSaved = true;
            Message = "Employee added successfully";
        }
    }
}
