using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace SampleBlazorWebAssembly.Pages
{
    [SupportedOSPlatform("browser")]
    public partial class CallJavaScript1
    {
        [JSImport("getMessage", "CallJavaScript1")]
        internal static partial string GetWelcomeMessage();
    }
}
