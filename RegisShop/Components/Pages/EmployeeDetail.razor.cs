using RegisShop.Services;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Shared.Domain;
using RegisShop.Contracts.Services;
using Microsoft.AspNetCore.Components.Web.Virtualization;

namespace RegisShop.Components.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();
        public List<TimeRegistration> TimeRegistrations { get; set; } = [];

        [Inject]
        public IEmployeeDataService? EmployeeDataService { get; set; }

        [Inject]
        public ITimeRegistrationDataService? TimeRegistrationDataService { get; set; }
        private float itemHeight = 50;

        protected override async void OnInitialized()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(EmployeeId);
            TimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationsForEmployee(EmployeeId);
           //Employee = MockDataService.Employees.Single( e => e.EmployeeId == EmployeeId);
        }

        public async ValueTask<ItemsProviderResult<TimeRegistration>> LoadTimeRegistrations(ItemsProviderRequest request)
        {
            int totalNumberOfTimeRegistrations = await TimeRegistrationDataService.GetTimeRegistrationCountForEmployeeId(EmployeeId);

            var numberOfTimeRegistrations = Math.Min(request.Count, totalNumberOfTimeRegistrations - request.StartIndex);
            var listItems = await TimeRegistrationDataService.GetPagedTimeRegistrationsForEmployee(EmployeeId, numberOfTimeRegistrations, request.StartIndex);

            return new ItemsProviderResult<TimeRegistration>(listItems, totalNumberOfTimeRegistrations);
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
