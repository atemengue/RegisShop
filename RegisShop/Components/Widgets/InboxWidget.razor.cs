using Microsoft.AspNetCore.Components;
using RegisShop.State;

namespace RegisShop.Components.Widgets
{
    public partial class InboxWidget
    {

        [Inject]
        public ApplicationState ApplicationState { get; set; }
        public int MessageCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            // MessageCount = new Random().Next(10);
            MessageCount = ApplicationState.NumberOfMessages;
        }
    }
}
