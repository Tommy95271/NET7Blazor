using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace SampleBlazorWebAssembly.Pages
{
    [SupportedOSPlatform("browser")]
    public partial class CallNetFromJS
    {
        [JSImport("setMessage", "CallNetFromJS")]
        internal static partial void SetWelcomeMessage();

        [JSExport]
        internal static string GetMessageFromDotnet()
        {
            return "Olá do Blazor!";
        }
    }
}
