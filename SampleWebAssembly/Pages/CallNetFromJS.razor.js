export async function setMessage() {
    const { getAssemblyExports } = await globalThis.getDotnetRuntime(0);
    var exports = await getAssemblyExports("SampleBlazorWebAssembly.dll");
    console.log(exports);
    document.getElementById("result").innerText =
        exports.SampleBlazorWebAssembly.Pages.CallNetFromJS.GetMessageFromDotnet();
}