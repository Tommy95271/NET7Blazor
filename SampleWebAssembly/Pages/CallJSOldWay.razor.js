export function showMessage() {
    console.time("JS old way");
    document.getElementById("result2").innerText = "Hello from CallJSOldWay.razor.js!";
    console.timeEnd("JS old way");
}