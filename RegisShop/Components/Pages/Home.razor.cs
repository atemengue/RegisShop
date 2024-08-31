using RegisShop.Components.Widgets;

namespace RegisShop.Components.Pages
{
    public partial class Home
    {
        public List<Type> Widgets { get; set; } = new List<Type>()
        {
            typeof(EmployeeCountWidget), typeof(InboxWidget)
        };
    }
}
