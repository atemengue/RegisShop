using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Shared.Domain;

namespace RegisShop.Components;

public partial class EmployeeCard
{
    [Parameter]
    public Employee Employee { get; set; } = default!;

    [Parameter]
    public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }

    protected override void OnInitialized()
    {
        if(string.IsNullOrEmpty(Employee.LastName))
        {
            throw new Exception("Last Name can't be empty");
        }
    }

}
