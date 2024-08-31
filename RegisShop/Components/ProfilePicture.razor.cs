using Microsoft.AspNetCore.Components;

namespace RegisShop.Components
{
    public partial class ProfilePicture
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }  
    }
}
