using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace RegisShop.Archives
{

    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }

        private Employee? _employee;

    }

}

