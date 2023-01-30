export function showMessage() {
    console.time("JS new way");
    document.getElementById("result1").innerText = "Hello from CallJSNewWay.razor.js!";
    console.timeEnd("JS new way");
}