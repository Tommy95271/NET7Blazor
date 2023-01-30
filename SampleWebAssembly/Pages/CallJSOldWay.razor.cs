using Microsoft.JSInterop;

namespace SampleBlazorWebAssembly.Pages
{
    public partial class CallJSOldWay
    {
        private IJSObjectReference module;
        protected override async Task OnInitializedAsync()
        {
            module = await JS.InvokeAsync<IJSObjectReference>("import", "../Pages/CallJSOldWay.razor.js");

            for (int i = 0; i < 10; i++)
            {
                await module.InvokeVoidAsync("showMessage");
            }
        }
    }
}
