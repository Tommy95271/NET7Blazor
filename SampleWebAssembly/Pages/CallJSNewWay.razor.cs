using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace SampleBlazorWebAssembly.Pages
{
    [SupportedOSPlatform("browser")]
    public partial class CallJSNewWay
    {
        [JSImport("showMessage", "CallJSNewWay")]
        internal static partial string ShowWelcomeMessage();
    }
}
